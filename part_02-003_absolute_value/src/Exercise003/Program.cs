namespace Exercise003
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write your code here
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine(number = number * -1);
            }
            else
            {
                Console.WriteLine(number);
            }

        }
    }
}
