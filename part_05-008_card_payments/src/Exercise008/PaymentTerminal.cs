namespace Exercise008
{
    public class PaymentTerminal
    {
        public double money { get; private set; }  // amount of cash
        public int coffeeAmount { get; private set; } // number of sold coffees
        public int lunchAmount { get; private set; }  // number of sold lunches

        public PaymentTerminal()
        {
            this.money = 1000;
            this.coffeeAmount = 0;
            this.lunchAmount = 0;
            // register initially has 1000 euros of money
        }

        public double DrinkCoffee(double payment)
        {
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment

            double coffeeprice = 2.5;
            if (payment >= coffeeprice)
            {
                this.money += coffeeprice;
                this.coffeeAmount++;
                return payment - coffeeprice;
            }
            else
            {
                return payment;
            }
        }

        public double EatLunch(double payment)
        {
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
            double lunchprice = 10.30;
            if (payment >= lunchprice)
            {
                this.money += lunchprice;
                this.lunchAmount++;
                return payment - lunchprice;
            }
            else
            {
                return payment;

            }

        }


        public bool DrinkCoffee(PaymentCard card)
        {

            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            double coffeeprice = 2.50;
            if (card.balance >= 2.50)
            {
                card.TakeMoney(2.50);
                this.coffeeAmount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EatLunch(PaymentCard card)
        {
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            double lunchprice = 10.30;
            if (card.balance >= 10.30)
            {
                card.TakeMoney(10.30);
                this.lunchAmount++;
                return true;
            }
            else
            {
                return false;

            }
        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            // Only add positive amounts
            if (sum > 0)
            {

                card.AddMoney(sum);
                this.money += sum;

            }
        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}