namespace Exercise005
{
    using System;
    public class Whistle
    {
        private string sound;

        public Whistle(string WhistleSound)
        {
            this.sound = WhistleSound;
        }
        public void Sound()
        {
            Console.WriteLine(sound);
        }
    }

}