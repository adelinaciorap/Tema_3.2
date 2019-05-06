using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Transaction
{
    class Program
    {
        static void Main(string[] args)

        {
            int balance = 1000;
            int deposit, withdraw;
            Console.WriteLine(" ======= Welcome to your Bank ATM =======");
            Console.WriteLine("Please type your PIN:");
            Console.WriteLine();
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please select one of the options");
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Check Balance.");
            Console.WriteLine("2. Withdraw Cash.");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Exit");
            Console.WriteLine("=========================================");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your account balance si: {0} ", balance);
                    break;

                case 2:
                    Console.WriteLine("Enter the amount to be withdrawn: ");
                    withdraw = Convert.ToInt32(Console.ReadLine());

                    if (withdraw % 50 != 0)
                    {

                        Console.WriteLine("Enter multiple of 50");
                    }
                    else if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    else
                    {
                        balance = balance - withdraw;
                        Console.WriteLine("Please collect money.");
                        Console.WriteLine("The current balance is " + balance);
                    }
                    break;
                case 3:
                    Console.WriteLine("What amount do you wish to deposit?");
                    deposit = Convert.ToInt32(Console.ReadLine());

                    balance = balance + deposit;
                    
                    Console.WriteLine("Deposit was successful");
                    Console.WriteLine("Your balance is {0}", balance);
                    break;

                case 4:
                    Console.WriteLine("Goodbye");
                    break;
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Thank you for using our Bank ATM services");
            Console.ReadKey();
        }
    }
}

