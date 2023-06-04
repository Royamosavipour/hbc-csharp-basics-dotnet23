namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(String[] args)
        {
            PrintRightTriangle(4);
            Console.WriteLine();
            ChristmasTree(4);
            Console.WriteLine();
            ChristmasTree(10);

        }


        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }

        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public static void PrintRightTriangle(int size)
        {
            int leftTreeSet = size - 1;
            for (int i = 1; i <= size; i++)
            {

                PrintSpaces(leftTreeSet);
                PrintStars(i);
                leftTreeSet--;
            }

        }

        public static void ChristmasTree(int height)
        {

            for (int i = 1; i <= height; i++)
            {
                PrintSpaces(height - i);
                PrintStars(i * 2 - 1);

            }


            for (int i = 0; i < 2; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(3);

            }
        }
    }
}
