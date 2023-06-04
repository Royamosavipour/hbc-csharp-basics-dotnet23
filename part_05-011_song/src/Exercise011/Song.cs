namespace Exercise011
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Song))
            {
                return false;
            }

            Song otherSong = (Song)obj;

            return this.artist == otherSong.artist &&
                   this.name == otherSong.name &&
                   this.durationInSeconds == otherSong.durationInSeconds;
        }

    }
}
