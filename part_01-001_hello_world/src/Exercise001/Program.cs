namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] number = { 2, 4, 6 };
            int sum = sumofinarry(number);
            Console.WriteLine(sum);


        }
        public static int sumofinarry(int[] number)
        {
            int metodsum = 0;
            foreach (var item in number)
            {
                metodsum += item;
            }
            return metodsum;

        }


    }
}
