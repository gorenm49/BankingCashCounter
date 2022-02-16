using System;

namespace BankingCashCounter
{
    public class CashCounter
    {
        public int TOTAL_BALANCE_AMT = 100000;
        public int deposit_Amt =0;
        public int withdraw_Amt = 0;

        QueueClass qObj = new QueueClass();

        public void Withdraw()
        {   
            System.Console.WriteLine("Total Balance of your account : "+TOTAL_BALANCE_AMT);

            System.Console.WriteLine("Please Enter Amount for Withdraw :\n");
            withdraw_Amt = Convert.ToInt32(Console.ReadLine());
            
            if (withdraw_Amt > TOTAL_BALANCE_AMT)
            {
                System.Console.WriteLine("Insufficient balance in your account..");
            }
            else
            {
                TOTAL_BALANCE_AMT -= withdraw_Amt;
                System.Console.WriteLine(withdraw_Amt+" amount withdrawn from your account \n");
                System.Console.WriteLine("Your Avaialble Balance is :"+TOTAL_BALANCE_AMT);
            }
            qObj.Dequeue();
        }

        public void Deposit()
        {
            System.Console.WriteLine("Total Balance of your account : "+TOTAL_BALANCE_AMT);
            System.Console.WriteLine("Please Enter Amount for Deposit :\n");
            deposit_Amt = Convert.ToInt32(Console.ReadLine());
            
            TOTAL_BALANCE_AMT += deposit_Amt;
            System.Console.WriteLine(deposit_Amt+" Money depositted in your account \n");
            System.Console.WriteLine("Now Your Avaialble Balance is :"+TOTAL_BALANCE_AMT);

            qObj.Dequeue();
            
        }
    }
}