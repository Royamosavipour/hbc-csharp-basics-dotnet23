namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> book = new List<Book>();
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int publicationyear = Convert.ToInt32(Console.ReadLine());

                Book sampel = new Book(name, pages, publicationyear);
                book.Add(sampel);
            }
            System.Console.WriteLine();
            Console.Write("What information will be printed? ");
            string input = Console.ReadLine();
            if (input == "title")
            {
                foreach (Book sample in book)
                {
                    Console.WriteLine(sample.Taitel);
                }
            }
            else if (input == "everything")
            {
                foreach (Book sample in book)
                {
                    Console.WriteLine(sample.Taitel + ", " + sample.NumPages + " pages, " + sample.PublicationYear);
                }
            }






            // implement here the program that allows the user to enter 
            // book information and to examine them

        }
    }
}