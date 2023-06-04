namespace Exercise018
{
    using System;

    public class Book
    {
        public string Taitel { get; set; }
        public int NumPages { get; set; }
        public int PublicationYear { get; set; }

        public Book(string titel, int numpages, int publicationyear)
        {
            this.Taitel = titel;
            this.NumPages = numpages;
            this.PublicationYear = publicationyear;
        }



    }
}