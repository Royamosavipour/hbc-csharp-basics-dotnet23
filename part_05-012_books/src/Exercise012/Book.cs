namespace Exercise012
{
    public class Book
    {

        private string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }



        public override bool Equals(object compared)
        {
            if ((compared == null) || !(compared is Book))
            {
                return false;
            }
            Book comparedbook = (Book)compared;
            return this.name == comparedbook.name && this.publicationYear == comparedbook.publicationYear;




        }
    }
}