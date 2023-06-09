namespace Exercise015
{
    public class Money
    {

        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }


        public Money Plus(Money addition)
        {
            Money newMoney = new Money(this.euros, this.cents);
            newMoney.euros = newMoney.euros + addition.euros;
            newMoney.cents = newMoney.cents + addition.cents;
            if (newMoney.cents > 100)
            {
                newMoney.cents = newMoney.cents - 100;
                newMoney.euros++;


            }

            // create a new Money object that has the correct worth
            // return the new Money object
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            Money newMoney = new Money(this.euros, this.cents);
            newMoney.euros -= decreaser.euros;
            newMoney.cents -= decreaser.cents;
            if (newMoney.cents < 0)
            {
                newMoney.euros -= 1;
                newMoney.cents += 100;

            }
            if (newMoney.euros < 0)
            {
                newMoney.cents = 0;
                newMoney.euros = 0;
            }

            // create a new Money object that has the correct worth

            // return the new Money object
            return newMoney;
        }

        public bool LessThan(Money compared)
        {
            if (this.euros < compared.euros)
            {
                return true;
            }
            if (this.euros <= compared.euros && this.cents < compared.cents)
            {
                return true;
            }
            // Do something here
            return false;
        }

        public override string ToString()
        {
            string zero = "";
            if (this.cents <= 10)
            {
                zero = "0";
            }

            return this.euros + "." + zero + this.cents + "e";
        }
    }
}