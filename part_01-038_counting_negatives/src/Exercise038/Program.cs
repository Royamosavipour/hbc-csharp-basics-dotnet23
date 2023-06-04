namespace Exercise038
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                int inputnum = Convert.ToInt32(Console.ReadLine());
                if (inputnum == 0)
                {
                    break;
                }
                if (inputnum < 0)
                {
                    num++;

                }
            }
            Console.WriteLine("Total amount of negative numbers: " + num);
        }
    }
}
