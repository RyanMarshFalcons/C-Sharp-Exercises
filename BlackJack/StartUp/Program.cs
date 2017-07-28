using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;
using BlackJackMessages;


namespace StartUp
{
    public enum RoundResult { PlayerBlackJack, DealerBlackJack, Won, Lost, Tied, Surrendered, Busted, DealerBusts, Split, Unknown};
    
    public class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var walletAmount = 250.00;
            while ((walletAmount >= 5) && (walletAmount < 500))
            {
                PlayAHand(ref walletAmount);
            }


            if (walletAmount < 5)
            {
                Message.WentBroke(walletAmount);
            }
            else
            {
                Message.Reached500(walletAmount);
            }
            Console.ReadLine();

        }

        

        public static List<Card> CreateDeck()
        {
            var deck = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    var card = new Card();
                    card.suit = suit;
                    card.face = face;
                    deck.Add(card);
                }
            }
            return deck;
        }

        

        public static Card GetRandomCard(int randomInt, ref List<Card> deck)
        {

            var card = deck[randomInt];
            deck.Remove(card);
            return card;
        }
        

        public static void PlayAHand(ref double walletAmount)
        {
            var bet = new Bet();
            Message.PlaceBet(walletAmount);
            var betAmount = bet.GetValidBet(walletAmount);
            var splitBetAmount = betAmount;
            walletAmount -= betAmount;
            var deck = CreateDeck();
            var random = new Random();
            var playerCards = new List<Card>() { GetRandomCard(random.Next(0, deck.Count), ref deck), GetRandomCard(random.Next(0, deck.Count), ref deck) };
            var dealerCards = new List<Card>() { GetRandomCard(random.Next(0, deck.Count), ref deck), GetRandomCard(random.Next(0, deck.Count), ref deck) };
            var playerCardsSplit = new List<Card>();
            var roundResult = RoundResult.Unknown;
            var roundResultSplit = RoundResult.Unknown;
            var playerHand = new Hand();
            var dealerHand = new Hand();
            var nextCard = new Card();
            Message.DealtCards(playerCards[0].ToString(), playerCards[1].ToString(), dealerCards[1].ToString());
            bool boughtInsurance, surrendered, doubledDown = false;
            var splitHand = false;
            var doubledDownSplit = false;
            var continueHand = true;

            if (dealerCards[1].face == Face.Ace)
            {
                boughtInsurance = playerHand.Insurance();
                if (boughtInsurance == true)
                {
                    walletAmount -= betAmount;
                    if (dealerHand.Points(dealerCards) == 21)
                    {
                        walletAmount += betAmount * 2;
                    }
                }
            }

            if (playerHand.CheckIfThereWasABlackJack(playerHand, dealerHand, playerCards, dealerCards))
            {
                if ((playerHand.Points(playerCards) == 21) && (dealerHand.Points(dealerCards) != 21))
                {
                    roundResult = RoundResult.PlayerBlackJack;
                }
                else if ((dealerHand.Points(dealerCards) == 21) && (playerHand.Points(playerCards) != 21))
                {
                    roundResult = RoundResult.DealerBlackJack;
                }
                else
                {
                    roundResult = RoundResult.Tied;
                }
                continueHand = false;
            }

            if (((dealerCards[1].face == Face.Ace) || (dealerCards[1].face == Face.King) || (dealerCards[1].face == Face.Queen) || (dealerCards[1].face == Face.Jack) || (dealerCards[1].face == Face.Ten)) && (playerHand.Points(playerCards) == 16) && (roundResult == RoundResult.Unknown) && (playerCards[0].face != Face.Ace) && (playerCards[1].face != Face.Ace))
            {
                surrendered = playerHand.Surrender(dealerCards[1].face.ToString());
                if (surrendered == true)
                {
                    roundResult = RoundResult.Surrendered;
                }
            }

            if (((playerCards[0].face == playerCards[1].face)) && (playerCards[0].face != Face.Ten) && (playerCards[0].face != Face.Jack) && (playerCards[0].face != Face.Queen) && (playerCards[0].face != Face.King) && (roundResult == RoundResult.Unknown))
            {
                splitHand = playerHand.SplitTheHand(playerCards[0].face.ToString());
                if (splitHand == true)
                {
                    playerCardsSplit.Add(playerCards[1]);
                    playerCards.RemoveAt(1);
                    playerCards.Add(GetRandomCard(random.Next(0, deck.Count), ref deck));
                    playerCardsSplit.Add(GetRandomCard(random.Next(0, deck.Count), ref deck));
                    Message.ChoseToSplitHand(playerCards[1].ToString(), playerCardsSplit[1].ToString());
                    walletAmount -= betAmount;
                }
            }

            if (splitHand == true)
            {
                Message.FirstHand(playerCards[0].ToString(), playerCards[1].ToString());
            }

            if (((playerHand.Points(playerCards) == 9) || (playerHand.Points(playerCards) == 10) || (playerHand.Points(playerCards) == 11)) && (roundResult == RoundResult.Unknown))
            {
                doubledDown = playerHand.DoubleDown(playerHand.Points(playerCards));
                if (doubledDown == true)
                {
                    walletAmount -= betAmount;
                    betAmount += betAmount;
                    nextCard = GetRandomCard(random.Next(0, deck.Count), ref deck);
                    playerCards.Add(nextCard);
                    Message.NextCardForPlayerWas(nextCard.ToString());
                    Message.AfterDoublingDown(playerHand.Points(playerCards));
                }
            }

            if ((roundResult == RoundResult.Unknown) && (doubledDown == false))
            {
                continueHand = playerHand.HitMe(playerHand.Points(playerCards), dealerCards[1].ToString());
                while (continueHand == true)
                {
                    nextCard = GetRandomCard(random.Next(0, deck.Count), ref deck);
                    playerCards.Add(nextCard);
                    Message.NextCardForPlayerWas(nextCard.ToString());
                    if (playerHand.Points(playerCards) < 21)
                    {
                        continueHand = playerHand.HitMe(playerHand.Points(playerCards), dealerCards[1].ToString());
                    }
                    if (playerHand.Points(playerCards) >= 21)
                    {
                        continueHand = false;
                    }
                }
                if (playerHand.Points(playerCards) <= 21)
                {
                    Message.ChoseToStand(playerHand.Points(playerCards));
                }
            }

            if (splitHand == true)
            {
                Message.SecondHand(playerCardsSplit[0].ToString(), playerCardsSplit[1].ToString());
                if (((playerHand.Points(playerCardsSplit) == 9) || (playerHand.Points(playerCardsSplit) == 10) || (playerHand.Points(playerCardsSplit) == 11)) && (roundResultSplit == RoundResult.Unknown))
                {
                    doubledDownSplit = playerHand.DoubleDown(playerHand.Points(playerCardsSplit));
                    if (doubledDownSplit == true)
                    {
                        walletAmount -= splitBetAmount;
                        splitBetAmount += splitBetAmount;
                        nextCard = GetRandomCard(random.Next(0, deck.Count), ref deck);
                        playerCardsSplit.Add(nextCard);
                        Message.NextCardForPlayerWas(nextCard.ToString());
                    }
                }
                if (doubledDownSplit == false)
                {
                    continueHand = playerHand.HitMe(playerHand.Points(playerCardsSplit), dealerCards[1].ToString());
                    while (continueHand == true)
                    {
                        nextCard = GetRandomCard(random.Next(0, deck.Count), ref deck);
                        playerCardsSplit.Add(nextCard);
                        Message.NextCardForPlayerWas(nextCard.ToString());
                        if (playerHand.Points(playerCardsSplit) < 21)
                        {
                            continueHand = playerHand.HitMe(playerHand.Points(playerCardsSplit), dealerCards[1].ToString());
                        }
                        if (playerHand.Points(playerCardsSplit) >= 21)
                        {
                            continueHand = false;
                        }
                    }
                    if (playerHand.Points(playerCardsSplit) <= 21)
                    {
                        Message.ChoseToStand(playerHand.Points(playerCardsSplit));
                    }
                }
            }

            if (playerHand.Points(playerCards) > 21)
            {
                roundResult = RoundResult.Busted;
            }

            if (playerHand.Points(playerCardsSplit) > 21)
            {
                roundResultSplit = RoundResult.Busted;
            }

            if (((playerHand.Points(playerCards) <= 21) && (roundResult == RoundResult.Unknown)) || ((playerHand.Points(playerCardsSplit) <= 21) && (splitHand == true)))
            {
                Message.DealerFlipsOverHoleCard(dealerCards[0].ToString(), dealerHand.Points(dealerCards));
                while (dealerHand.Points(dealerCards) < 17)
                {
                    nextCard = GetRandomCard(random.Next(0, deck.Count), ref deck);
                    dealerCards.Add(nextCard);
                    Message.NextCardForDealerWas(nextCard.ToString(), dealerHand.Points(dealerCards));
                }

                if ((dealerHand.Points(dealerCards) >= 17) && (dealerHand.Points(dealerCards) <= 21))
                {
                    Message.DealerStands(dealerHand.Points(dealerCards).ToString());
                }

                if (playerHand.Points(playerCards) == dealerHand.Points(dealerCards))
                {
                    roundResult = RoundResult.Tied;
                }
                else if (playerHand.Points(playerCards) > dealerHand.Points(dealerCards))
                {
                    roundResult = RoundResult.Won;
                }
                else if (dealerHand.Points(dealerCards) > 21)
                {
                    roundResult = RoundResult.DealerBusts;
                }
                else
                {
                    roundResult = RoundResult.Lost;
                }
            }

            switch (roundResult)
            {
                case RoundResult.PlayerBlackJack:
                    Message.WonWithABlackJack(2.5 * betAmount);
                    walletAmount += 2.5 * betAmount;
                    break;
                case RoundResult.DealerBlackJack:
                    Message.LostToABlackJack(dealerCards[0].ToString());
                    break;
                case RoundResult.Won:
                    Message.WonHand(playerHand.Points(playerCards), dealerHand.Points(dealerCards), (2 * betAmount));
                    walletAmount += 2 * betAmount;
                    break;
                case RoundResult.Lost:
                    Message.LostHand(playerHand.Points(playerCards), dealerHand.Points(dealerCards));
                    break;
                case RoundResult.Tied:
                    Message.TiedHand(playerHand.Points(playerCards), betAmount);
                    walletAmount += betAmount;
                    break;
                case RoundResult.Surrendered:
                    Message.ChoseToSurrender(.5 * betAmount);
                    walletAmount += .5 * betAmount;
                    break;
                case RoundResult.Busted:
                    Message.YouBusted(playerHand.Points(playerCards));
                    break;
                case RoundResult.DealerBusts:
                    Message.DealerBusted(dealerHand.Points(dealerCards), (2 * betAmount));
                    walletAmount += 2 * betAmount;
                    break;
                case RoundResult.Unknown:
                    break;
                default:
                    break;
            }

            if ((splitHand == true) && (roundResultSplit != RoundResult.Busted))
            {
                if (playerHand.Points(playerCardsSplit) == dealerHand.Points(dealerCards))
                {
                    roundResultSplit = RoundResult.Tied;
                }
                else if (playerHand.Points(playerCardsSplit) > dealerHand.Points(dealerCards))
                {
                    roundResultSplit = RoundResult.Won;
                }
                else if (dealerHand.Points(dealerCards) > 21)
                {
                    roundResultSplit = RoundResult.DealerBusts;
                }
                else
                {
                    roundResultSplit = RoundResult.Lost;
                }

                Message.ResultOfSplitHand();
            }

            switch (roundResultSplit)
            {
                case RoundResult.Won:
                    Message.WonHand(playerHand.Points(playerCardsSplit), dealerHand.Points(dealerCards), (2 * splitBetAmount));
                    walletAmount += 2 * splitBetAmount;
                    break;
                case RoundResult.Lost:
                    Message.LostHand(playerHand.Points(playerCardsSplit), dealerHand.Points(dealerCards));
                    break;
                case RoundResult.Tied:
                    Message.TiedHand(playerHand.Points(playerCardsSplit), splitBetAmount);
                    walletAmount += splitBetAmount;
                    break;
                case RoundResult.Busted:
                    Message.YouBusted(playerHand.Points(playerCardsSplit));
                    break;
                case RoundResult.DealerBusts:
                    Message.DealerBusted(dealerHand.Points(dealerCards), (2 * splitBetAmount));
                    walletAmount += 2 * splitBetAmount;
                    break;
                case RoundResult.Unknown:
                    break;
                default:
                    break;
            }
        }
    }
}
