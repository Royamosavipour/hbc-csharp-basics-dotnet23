namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<String> strings = new List<string>();
            strings.Add("First");
            strings.Add("Second");
            strings.Add("roya");
            strings.ForEach(Console.WriteLine);
            RemoveLast(strings);
            // RemoveLast(strings);
            System.Console.WriteLine("*********");
            strings.ForEach(Console.WriteLine);



            //Write your method here:
        }

        public static void RemoveLast(List<string> strings)
        {
            if (strings.Count > 0)
            {
                strings.RemoveAt(strings.Count - 1);
            }

        }
    }
}
