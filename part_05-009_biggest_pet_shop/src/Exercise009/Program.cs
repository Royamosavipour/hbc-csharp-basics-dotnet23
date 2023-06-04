namespace Exercise009
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Pet lucy = new Pet("x", "y");
            Person leo = new Person("z", lucy);
            System.Console.WriteLine(leo);

            Person reza = new Person("rana");
            System.Console.WriteLine(reza);
            Person roya = new Person();
            System.Console.WriteLine(roya);
        }
    }
}