namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard roya = new PaymentCard(10);
            System.Console.WriteLine(roya);
            roya.EatLunch();
            System.Console.WriteLine(roya);
            roya.DrinkCoffee();
            System.Console.WriteLine(roya);

        }
    }
}