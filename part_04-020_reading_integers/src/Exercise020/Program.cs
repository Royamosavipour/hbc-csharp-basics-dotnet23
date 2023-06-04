namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int num = Convert.ToInt32(input);
                int cup = num * num * num;
                Console.WriteLine(cup);

            }


        }
    }
}