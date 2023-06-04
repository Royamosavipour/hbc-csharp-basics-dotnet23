namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] practice = { 2, 3, 4 };
            PrintNeatly(practice);

            // You can test your method here
        }

        public static void PrintNeatly(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            System.Console.WriteLine();

        }
    }
}
