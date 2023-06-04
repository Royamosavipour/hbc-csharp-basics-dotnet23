namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int CurrentYear = DateTime.Now.Year;
            string longname = "";
            int highage = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] parts = input.Split(",");
                string name = parts[0].Trim();
                int birthyear = int.Parse(parts[1].Trim());
                int age = CurrentYear - birthyear;
                if (name.Length > longname.Length)
                {
                    longname = name;
                }
                if (age > highage)
                {
                    highage = age;
                }

            }
            System.Console.WriteLine("Longest name: " + longname);
            System.Console.WriteLine("Highest age: " + highage);


        }
    }
}