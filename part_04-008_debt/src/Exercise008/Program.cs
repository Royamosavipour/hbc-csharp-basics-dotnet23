namespace Exercise008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Debt mortgage = new Debt(120000, 1.01);
            mortgage.PrintBalance();
            mortgage.WaitOneYear();
            mortgage.PrintBalance();
            // int years = 0;
            // while (years < 20)
            // {
            //     mortgage.WaitOneYear();
            //     years = years + 1;
            // }
            // mortgage.PrintBalance();
        }
    }
}