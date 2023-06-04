namespace Exercise039
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                else
                {
                    sum += num;

                }

            }
            Console.WriteLine("Total sum of numbers: " + sum);

        }
    }
}

