namespace Exercise032
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Speak, friend, and enter!");
            string name = "Mellon";
            string name2 = Console.ReadLine();
            if (name2 == name)
            {
                Console.WriteLine("Welcome, friend");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");
            }

        }
    }
}
