namespace Exercise017
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            System.Console.WriteLine("The sum is " + sum);

        }
    }
}