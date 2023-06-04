namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 0 || num2 > 0)
            {
                double sum = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                double sq = Math.Sqrt(sum);
                Console.WriteLine(sq);
            }


        }
    }
}
