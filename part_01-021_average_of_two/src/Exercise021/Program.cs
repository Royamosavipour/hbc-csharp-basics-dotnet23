namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int firstnumbet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            double average = Convert.ToDouble((firstnumbet + secondnumber) / 2.0);
            Console.WriteLine("The average is " + average);

        }
    }
}
