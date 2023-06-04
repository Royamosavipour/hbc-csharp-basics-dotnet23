namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string message = Console.ReadLine();
            Console.WriteLine("Give an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a double:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give a boolean:");
            bool number2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your string: " + message);
            Console.WriteLine("Your integer: " + number);
            Console.WriteLine("Your double: " + number1);
            Console.WriteLine("Your boolean: " + number2);




        }
    }
}
