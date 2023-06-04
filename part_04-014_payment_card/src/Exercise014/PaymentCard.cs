
namespace Exercise014
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
            // write code here
        }


        public override string ToString()
        {
            return "The card has a balance of " + balance + " euros";
            // write code here
        }

        public void EatLunch()
        {
            if (balance >= 10.60)
            {
                balance -= 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if (balance >= 2.0)
            {
                balance -= 2.0;
            }

        }
        public void AddMoney(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;


            }
            if (balance > 150)
            {
                balance = 150;
            }
        }
    }
}