namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            PrintFromNumberToOne(2);
        }
        public static void PrintFromNumberToOne(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                System.Console.WriteLine(i);
            }
        }

    }
}
