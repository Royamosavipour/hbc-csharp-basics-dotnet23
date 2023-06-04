namespace Exercise007
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where to?");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
            int minNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = minNumber; i <= maxNumber; i++)
            {

                Console.WriteLine(i);
            }



        }
    }
}
