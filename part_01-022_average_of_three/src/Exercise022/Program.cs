namespace Exercise022
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int first = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int second = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Give the third number!");
            int third = Convert.ToInt32(System.Console.ReadLine());

            Double avg = Convert.ToDouble((first + second + third) / 3.0);
            System.Console.WriteLine("The average is " + avg);



        }
    }
}
