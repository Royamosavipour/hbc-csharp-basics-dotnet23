namespace Exercise004
{
    using System;
    public class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfseats)
        {
            this.code = classCode;
            this.seats = numberOfseats;
        }

    }

}