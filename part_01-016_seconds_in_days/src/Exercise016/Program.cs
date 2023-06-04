namespace Exercise016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("How many days?");
            int day1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine(day1 * 86400);
        }
    }
}
