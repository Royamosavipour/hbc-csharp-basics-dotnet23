namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<PersonalInformation> list = new List<PersonalInformation>();
            // IMPLEMENT YOUR CODE IN HERE!
            while (true)
            {
                System.Console.WriteLine("First name:");
                string firstname = Console.ReadLine();
                if (firstname == "")
                {
                    break;
                }
                System.Console.WriteLine("Last name:");
                string lastname = Console.ReadLine();
                System.Console.WriteLine("Identification number:");
                string id = Console.ReadLine();
                PersonalInformation item = new PersonalInformation(firstname, lastname, id);
                list.Add(item);

            }

            Console.WriteLine();

            foreach (PersonalInformation item in list)
            {
                System.Console.WriteLine(item.firstName + " " + item.lastName);
                // Print only first and last name!

            }

        }
    }
}