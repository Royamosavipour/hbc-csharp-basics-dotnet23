namespace Exercise001
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            Account RoyaAccount = new Account("roya", 100);
            RoyaAccount.Deposit(20);
            Console.WriteLine(RoyaAccount.balance);


        }

    }

}
