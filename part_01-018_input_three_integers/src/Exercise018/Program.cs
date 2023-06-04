namespace Exercise018
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            int Second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the third number!");
            int third = Convert.ToInt32(Console.ReadLine());
            int sum = first + Second + third;
            Console.WriteLine("The sum is " + sum);

        }
    }
}
