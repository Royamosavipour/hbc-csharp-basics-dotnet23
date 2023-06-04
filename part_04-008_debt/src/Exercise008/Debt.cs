namespace Exercise008
{
    using System;
    public class Debt
    {
        private double balance;
        private double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);

        }

        public void WaitOneYear()
        {
            balance = balance * interestRate;
        }

    }

}