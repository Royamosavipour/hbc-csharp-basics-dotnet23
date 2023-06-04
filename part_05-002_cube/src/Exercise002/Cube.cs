namespace Exercise002
{
    using System;
    public class Cube
    {
        public int edgeLength { get; set; }
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }
        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }
        public override string ToString()
        {
            int volume = Volume();
            return $"The length of the edge is {edgeLength} and the volume {volume}";
        }




    }
}