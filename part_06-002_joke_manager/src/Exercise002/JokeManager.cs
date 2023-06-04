namespace Exercise002
{
    using System.Collections.Generic;
    using System;
    public class JokeManager
    {
        private List<string> jokes;
        public JokeManager()
        {
            jokes = new List<string>();
        }

        public void Addjokes(string joke)
        {
            jokes.Add(joke);
        }
        public string Drawjoke()
        {
            if (jokes.Count == 0)
            {
                return "jokes are in short supply.";

            }
            else
            {
                Random draw = new Random();
                int index = draw.Next(0, jokes.Count);
                return jokes[index];

            }
        }
        public void PrintJokes()
        {
            foreach (string item in jokes)
            {
                System.Console.WriteLine(item);
            }
        }
    }

}