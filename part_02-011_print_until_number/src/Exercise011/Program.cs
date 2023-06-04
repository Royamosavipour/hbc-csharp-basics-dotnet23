namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintUntilNumber(3);

        }
        //write your method here:
        public static void PrintUntilNumber(int n)
        {

            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }



    }
}
