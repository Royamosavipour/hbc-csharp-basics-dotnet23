namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int firstnumber = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Give the second number!");
            int second = Convert.ToInt32(Console.ReadLine());
            int multiplies = firstnumber * second;
            Console.WriteLine(firstnumber + " * " + second + " = " + multiplies);

        }
    }
}
