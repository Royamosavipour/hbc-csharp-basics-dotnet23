namespace Exercise017
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

            List<TelevisionProgram> list = new List<TelevisionProgram>();
            // IMPLEMENT YOUR CODE IN HERE!
            while (true)
            {
                Console.Write("Name: ");
                string inputname = Console.ReadLine();
                if (inputname == "")
                {
                    break;
                }
                Console.Write("Duration: ");
                int inpurduration = Convert.ToInt32(Console.ReadLine());
                TelevisionProgram item = new TelevisionProgram(inputname, inpurduration);
                list.Add(item);

            }
            System.Console.WriteLine();
            Console.Write("Program's maximum duration? ");
            int maxduration = Convert.ToInt32(System.Console.ReadLine());
            foreach (TelevisionProgram item in list)
            {
                if (item.duration <= maxduration)
                {
                    Console.WriteLine(item.ToString());
                }


            }

        }
    }
}