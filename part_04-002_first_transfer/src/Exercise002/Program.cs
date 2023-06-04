namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Account Heikki = new Account("Heikki's account", 1000);
            Account personal = new Account("Personal account", 0);
            Heikki.Withdrawal(100.0);
            personal.Deposit(100);
            Console.WriteLine("Heikki's account balance: " + Heikki.balance);
            Console.WriteLine("Personal account balance: " + personal.balance);

        }
    }
}