namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            Division(5, 2);


        }
        public static void Division(int n, int m)
        {
            double result = Convert.ToDouble(n) / Convert.ToUInt32(m);
            Console.WriteLine(result);

        }

        //Write your method here
    }
}
