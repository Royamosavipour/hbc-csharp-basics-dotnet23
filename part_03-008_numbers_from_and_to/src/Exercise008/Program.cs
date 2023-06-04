namespace Exercise008
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
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                list.Add(number);
            }
            Console.WriteLine("From where?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            foreach (var item in list)
            {
                if (item >= num1 & item <= num2)
                {
                    Console.WriteLine(item);
                }
            }

            //Write your code here
        }
    }
}
