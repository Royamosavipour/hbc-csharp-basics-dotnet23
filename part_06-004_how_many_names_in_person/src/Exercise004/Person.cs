namespace Exercise004
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string givenName)
        {
            this.name = givenName;
            this.age = 0;
        }

        public bool IsOfAge()
        {
            return (this.age >= 18);
        }

        public int HowManyNames()
        {
            string[] name = this.name.Split(' ');
            return name.Length;
        }

        public void GrowOlder()
        {
            this.age++;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}