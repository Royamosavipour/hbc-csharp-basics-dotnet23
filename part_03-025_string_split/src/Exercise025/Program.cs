namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string[] pieces = input.Split();
                foreach (var item in pieces)
                {
                    System.Console.WriteLine(item);
                }
            }




        }
    }
}
