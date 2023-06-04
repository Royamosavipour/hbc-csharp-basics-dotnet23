namespace Exercise036
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(System.Console.ReadLine());
                if (number == 0)
                    break;
                else if (number < 0)
                    System.Console.WriteLine("That is negative");
                else
                {
                    System.Console.WriteLine(number * number);
                }

            }
        }
    }
}
