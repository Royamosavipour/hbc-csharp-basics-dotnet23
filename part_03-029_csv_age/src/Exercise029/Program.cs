namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                string[] parts = input.Split(",");
                string name = parts[0];
                int age = int.Parse(parts[1]);
                ages.Add(age);
            }


            int OldestAge = ages[0];
            foreach (int age in ages)
            {
                if (age > OldestAge)
                {
                    OldestAge = age;
                }
            }
            Console.WriteLine("Age of the oldest: " + OldestAge);




        }





    }
}



