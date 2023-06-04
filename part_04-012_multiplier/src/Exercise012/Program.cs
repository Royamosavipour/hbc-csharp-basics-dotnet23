namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Multiplier roya = new Multiplier(3);
            System.Console.WriteLine(roya.Multiply(2));
            Multiplier reza = new Multiplier(4);
            System.Console.WriteLine(reza.Multiply(2));
            System.Console.WriteLine(roya.Multiply(1));
            System.Console.WriteLine(reza.Multiply(1));
            System.Console.WriteLine(reza.Multiply(3));
        }
    }
}