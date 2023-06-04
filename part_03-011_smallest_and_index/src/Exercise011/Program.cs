namespace Exercise011
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }

            int smallestnumber = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallestnumber)
                {
                    smallestnumber = list[i];
                }
            }
            Console.WriteLine("Smallest number: " + smallestnumber);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == smallestnumber)
                {
                    Console.WriteLine("Found at index: " + i);
                }
            }
        }
    }
}
