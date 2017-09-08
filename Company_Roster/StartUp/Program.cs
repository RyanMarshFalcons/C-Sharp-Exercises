using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Roster;
using Company_Roster_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var personSelectionLetter = "";
            var typeOfPerson = new TypeOfPerson();
            var employeeList = new List<Employee>();
            var customerList = new List<Customer>();
            do
            {
                personSelectionLetter = utility.GetValidPersonSelection();
                typeOfPerson = utility.ConvertLetterToPersonType(personSelectionLetter);
                if (typeOfPerson == TypeOfPerson.Customer)
                {
                    var customer = utility.GetCustomerInfo();
                    customerList.Add(customer);
                }
                else
                {
                    var employee = utility.GetEmployeeInfo();
                    employeeList.Add(employee);
                    
                }
            } while (utility.AskToContinue());
            Message.DisplayCustomers();
            foreach (var customer in customerList)
            {
                Console.WriteLine($"Name: {customer.Full_Name()}");
                Console.WriteLine($"Email Address: {customer.Email_Address}");
                Console.WriteLine($"Phone Number: {customer.Phone_Number}");
                Console.WriteLine($"Credit Card Number: {customer.Credit_Card_Number}");
                Console.WriteLine($"Billing Address: {customer.Billing_Address}");
                Console.WriteLine($"Shipping Address: {customer.Shipping_Address}");
                Console.WriteLine($"Home Address: {customer.Home_Address}");

            }
            Message.DisplayEmployees();
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"Name: {employee.Full_Name()}");
                Console.WriteLine($"Email Address: {employee.Email_Address}");
                Console.WriteLine($"Home Address: {employee.Home_Address}");
                Console.WriteLine($"Phone Number: {employee.Phone_Number}");
                Console.WriteLine($"Job Title: {employee.Job_Title}");
                Console.WriteLine($"Department: {employee.Department.ToString()}");
                Console.WriteLine($"Yearly Salary: {employee.Yearly_Salary}");
            }
            Message.ThankYou();
        }
    }
}
