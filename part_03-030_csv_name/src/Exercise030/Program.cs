namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            string Name1 = "";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] name = input.Split(",");
                if (oldest < Convert.ToInt32(name[1]))
                {
                    oldest = Convert.ToInt32(name[1]);
                    Name1 = name[0];
                }

            }
            Console.WriteLine("Name of the oldest: " + Name1);

        }
    }
}