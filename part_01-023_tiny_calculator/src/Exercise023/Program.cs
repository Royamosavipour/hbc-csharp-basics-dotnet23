namespace Exercise023
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            int second = Convert.ToInt32(Console.ReadLine());
            int sum = first + second;
            int sub = first - second;
            int multi = first * second;
            double division = Convert.ToDouble(first) / Convert.ToDouble(second);


            Console.WriteLine(first + " + " + second + " = " + sum);
            Console.WriteLine(first + " - " + second + " = " + sub);
            Console.WriteLine(first + " * " + second + " = " + multi);
            Console.WriteLine(first + " / " + second + " = " + division);



        }
    }
}
