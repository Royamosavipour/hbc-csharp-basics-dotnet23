namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give your percent [0 - 100]:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num < 60)
            {
                Console.WriteLine("Grade: 1");
            }
            else if (num < 70)
            {
                Console.WriteLine("Grade: 2");

            }
            else if (num < 80)
            {
                Console.WriteLine("Grade: 3");

            }
            else if (num < 90)
            {
                Console.WriteLine("Grade: 4");

            }
            else if (num < 100)
            {
                Console.WriteLine("Grade: 5");

            }
            else
            {
                Console.WriteLine("Outstanding!");

            }

        }
    }
}
