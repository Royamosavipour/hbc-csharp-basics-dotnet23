namespace Exercise033
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first string:");
            String first = Console.ReadLine();

            Console.WriteLine("Give the second string:");
            String second = Console.ReadLine();

            if (first == second)
            {
                Console.WriteLine("Echo!");
            }
            else
                Console.WriteLine("Nope!");
        }
    }
}
