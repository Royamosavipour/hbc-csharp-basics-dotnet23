namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pices = input.Split(" ");
                for (int i = 0; i < pices.Length; i++)
                {
                    if (pices[i].Contains("av"))
                    {
                        System.Console.WriteLine(pices[i]);

                    }
                }



            }


        }
    }
}