namespace Exercise013
{
    public class Item
    {

        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }
        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {
            if (compared == null || !(compared is Item))
            {
                return false;
            }
            Item other = (Item)compared;
            return this.identifier == other.identifier;
            //compare with Item.identifier


            return false;


        }
    }

}
