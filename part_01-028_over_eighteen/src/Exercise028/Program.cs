namespace Exercise028
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You're under age!");
            }
            if (age >= 18)
            {
                Console.WriteLine("You're an adult!");
            }
        }
    }
}
