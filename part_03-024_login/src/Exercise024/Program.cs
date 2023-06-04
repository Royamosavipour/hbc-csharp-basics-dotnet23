namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string alexuser = "alex";
            string emmauser = "emma";
            string sunshinepass = "sunshine";
            string haskellpass = "haskell";

            System.Console.WriteLine("Enter username:");
            string username = System.Console.ReadLine();
            System.Console.WriteLine("Enter password:");
            string pass = System.Console.ReadLine();

            if ((username == alexuser && pass == sunshinepass) || (username == emmauser && pass == haskellpass))
            {
                System.Console.WriteLine("You have successfully logged in!");
            }
            else
            {
                System.Console.WriteLine("Incorrect username or password!");

            }









        }
    }
}