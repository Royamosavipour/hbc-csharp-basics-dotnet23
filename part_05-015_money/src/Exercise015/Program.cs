namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Money mony = new Money(100, 50);
            Money moremony = new Money(200, 50);
            Money combind = mony.Plus(moremony);

            System.Console.WriteLine(mony);
            System.Console.WriteLine(moremony);
            System.Console.WriteLine(combind);
        }
    }
}