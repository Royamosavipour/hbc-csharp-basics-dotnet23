namespace Exercise013
{
    public class Statistics
    {
        public int count { get; set; }
        public int sum { get; set; }

        public Statistics()
        {
            this.count = 0;
            this.sum = 0;


            // initialize the variables here
        }


        public void AddNumber(int number)
        {
            count++;
            sum += number;
            // write code here
        }
    }
}
