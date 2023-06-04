namespace Exercise001
{
    using System;
    public class Timer
    {
        public ClockHand secend { get; set; }
        public ClockHand hundred { get; set; }

        public Timer()
        {
            this.secend = new ClockHand(60);
            this.hundred = new ClockHand(100);
        }
        public void Advance()
        {
            this.hundred.Advance();
            if (this.hundred.value == 0)
            {
                this.secend.Advance();
            }
        }
        public override string ToString()
        {
            return this.secend.ToString() + ":" + this.hundred.ToString();
        }


    }
}