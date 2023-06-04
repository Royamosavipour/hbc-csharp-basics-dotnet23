namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintTriangle(4);
            // you can print one star with the command
            // Console.Write("*");
            // call the print command n times
            // in the end print a line break with the comand
            // Console.WriteLine("");
        }
        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }
        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }
        public static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintStars(i);
            }

        }
    }
    //Write you methods here
}

