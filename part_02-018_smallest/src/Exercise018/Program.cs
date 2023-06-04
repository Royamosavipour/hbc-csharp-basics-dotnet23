namespace Exercise018
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int answer = Smallest(2, 3);
            Console.WriteLine("smalest: " + answer);
            //Call your method here:
        }
        public static int Smallest(int n, int m)
        {
            if (n > m)
            {
                return m;
            }
            else
            {
                return n;
            }

        }
        //Write your method here:
    }
}
