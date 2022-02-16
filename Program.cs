using System;

namespace BankingCashCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Banking Cash Counter !!!");

            System.Console.WriteLine("Banking Services Are :\n 1. Withdraw\n 2. Deposit\n ");

            CashCounter counter = new CashCounter();
            QueueClass queue = new QueueClass();

            Random random = new Random();
            int user = random.Next(1,11);
            System.Console.WriteLine(user+" Users are in Cash Counter queue ");
            for (int i = 1; i <=user; i++)
            {
                int option = random.Next(1,3);

                switch (option)
                {
                    case 1:
                        queue.Enqueue(i);
                        counter.Withdraw();
                        break;
                    case 2:
                        queue.Enqueue(i);
                        counter.Deposit();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Proceess");
                        break;
                }
 
            }
        }
    }
}