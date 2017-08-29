using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rollercoaster_Queue;
using Rollercoaster_Queue_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var queueOfPeople = new Queue<string>();
            for (int i = 1; i < 11; i++)
            {
                queueOfPeople.Enqueue(utility.GetName(i));
            }
            var personsWeight = 0.0;
            var placeholder = 0.0;
            var carNumber = 1;
            for (int i = 1; i < 11; i++)
            {
                personsWeight = utility.GetValidWeight(queueOfPeople.Peek());
                if (personsWeight > 500)
                {
                    Message.TooHeavy(queueOfPeople.Peek());
                }
                else
                {
                    if (utility.CheckIfRoomOnCar(placeholder, personsWeight))
                    {
                        placeholder += personsWeight;
                    }
                    else
                    {
                        carNumber++;
                        placeholder = personsWeight;
                        
                    }
                    Message.GoesOnCar(queueOfPeople.Peek(), carNumber);
                }
                queueOfPeople.Dequeue();
            }
            Message.SayGoodbye();
            Console.ReadLine();
        }
    }
}
