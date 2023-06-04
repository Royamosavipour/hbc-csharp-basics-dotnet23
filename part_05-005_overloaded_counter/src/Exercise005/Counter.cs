namespace Exercise005
{
    using System;
    public class Counter
    {
        public int value { get; set; }
        public Counter(int startValue)
        {
            this.value = startValue;

        }
        public Counter()
        {
            this.value = 0;
        }

        public void Increase()
        {
            value++;
        }
        public void Decrease()
        {
            value--;
        }
        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                this.value = value + increaseBy;
            }

        }

        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                this.value -= decreaseBy;
            }
        }

    }

}