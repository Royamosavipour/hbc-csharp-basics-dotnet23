namespace Exercise035
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                System.Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 42)
                {
                    break;
                }
            }


        }
    }
}
