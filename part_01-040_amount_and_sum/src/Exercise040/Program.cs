namespace Exercise040
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int add = 0;
            while (true)
            {
                System.Console.WriteLine("Give a number:");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                else
                {
                    sum += input;
                    add = add + 1;
                }

            }
            Console.WriteLine("Total sum of numbers: " + sum);
            Console.WriteLine("Total amount of numbers: " + add);
        }
    }
}
