namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            string input = "";
            while (input != "end")
            {
                input = Console.ReadLine();
                if (input != "end")
                {
                    count++;
                }
            }
            Console.WriteLine(count);






        }
    }
}