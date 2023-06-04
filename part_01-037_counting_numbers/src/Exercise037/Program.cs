namespace Exercise037
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            int amount = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else
                {
                    amount = amount + 1;
                }
            }
            Console.WriteLine("Total amount of numbers: " + amount);


        }
    }
}
