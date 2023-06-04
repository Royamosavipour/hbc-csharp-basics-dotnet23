namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            while (true)
            {
                System.Console.WriteLine("Identifier? (empty will stop):");
                string Identifier = System.Console.ReadLine();
                if (Identifier == "")
                {
                    break;
                }
                System.Console.WriteLine("Name? (empty will stop):");
                string Name = System.Console.ReadLine();
                if (Name == "")
                {
                    break;
                }
                Item newitem = new Item(Identifier, Name);
                if (!items.Contains(newitem))
                {
                    items.Add(newitem);

                }

            }




            // Ask for input as shown in the exercise.


            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}