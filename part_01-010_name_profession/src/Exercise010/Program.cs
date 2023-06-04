namespace Exercise010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\nGive a name for main character:");
            String input1 = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            String input2 = Console.ReadLine();
            Console.WriteLine("Here is the story:\n" + "Once upon a time there was a " + input2 + " called " + input1 + "\n" + "On her way to work, " + input1 + " often pondered what being " + input2 + " meant to them.\nWhen you work as a " + input2 + " you meet interesting people.\n" + input1 + " enjoys their work as " + input2 + ", The end.");

        }
    }
}
