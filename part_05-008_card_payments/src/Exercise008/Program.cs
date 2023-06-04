namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard petesCard = new PaymentCard(10);
            Console.WriteLine("money " + petesCard.balance);
            bool wasSuccessful = petesCard.TakeMoney(8);
            System.Console.WriteLine("successfully withdrew: " + wasSuccessful);
            System.Console.WriteLine("money " + petesCard.balance);
            wasSuccessful = petesCard.TakeMoney(4);
            System.Console.WriteLine("successfully withdrew: " + wasSuccessful);
            System.Console.WriteLine("money " + petesCard.balance);

        }
    }
}