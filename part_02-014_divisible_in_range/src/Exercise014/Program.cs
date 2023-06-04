namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here:
            DivisibleByThreeInRange(2, 20);
        }

        public static void DivisibleByThreeInRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
        //Write your method here:
    }
}
