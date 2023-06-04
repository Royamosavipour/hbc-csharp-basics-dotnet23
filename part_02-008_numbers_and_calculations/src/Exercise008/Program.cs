namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give numbers:");
            double sum = 0;
            int count = 0;
            double avg = 0;
            int even = 0;
            int odd = 0;
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {

                    Console.WriteLine("Thx! Bye!");
                    Console.WriteLine("Sum: " + sum);
                    Console.WriteLine("Numbers: " + count);
                    Console.WriteLine("Average: " + Convert.ToDouble(avg));
                    Console.WriteLine("Even: " + even);
                    Console.WriteLine("Odd: " + odd);
                    break;
                }
                else if (input % 2 == 0)
                {
                    even++;
                }
                else if (input % 2 != 0)
                {
                    odd++;
                }
                sum += input;
                count++;
                avg = sum / count;




            }

        }

    }
}