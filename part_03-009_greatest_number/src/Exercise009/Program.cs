namespace Exercise009
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
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int s = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > s)
                {
                    s = list[i];
                }
                Console.WriteLine("The greatest number: " + s);

            }
        }
    }
}

