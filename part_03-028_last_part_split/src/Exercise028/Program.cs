﻿namespace Exercise028
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
                string[] Lastpart = input.Split(" ");
                Console.WriteLine(Lastpart[Lastpart.Length - 1]);
            }
        }
    }
}