namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Statistics roya = new Statistics();
            roya.AddNumber(3);
            roya.AddNumber(5);
            roya.AddNumber(1);
            roya.AddNumber(2);
            Console.WriteLine($"Count:{roya.count}");
            Console.WriteLine("Sum: " + roya.sum);

        }
    }
}