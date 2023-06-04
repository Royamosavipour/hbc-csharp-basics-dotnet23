namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int answer = Greatest(5, 7, 3);
            Console.WriteLine("Greatest: " + answer);
        }
        public static int Greatest(int number1, int number2, int number3)
        {
            int answer = number1;
            if (number2 > answer)
            {
                answer = number2;
            }
            if (number3 > answer)
            {
                answer = number3;
            }
            return answer;

        }

        //Write your method here
    }
}
