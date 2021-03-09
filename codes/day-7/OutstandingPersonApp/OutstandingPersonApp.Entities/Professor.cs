namespace OutstandingPersonApp.Entities
{
    //Concrete class
    public class Professor : Person
    {
        int publications;
        public Professor()
        {
        }

        public Professor(string name, int publications)
        : base(name)
        {
            this.publications = publications;
        }

        public int Publications { get => publications; set => publications = value; }

        //override DOES NOT MEAN overwrite
        public override bool IsOutstanding()
        {
            return publications > 5 ? true : false;
        }

        // public string Print()
        // {
        //     // return base.ToString() + $", Publications: {publications}";

        //     return $"{base.ToString()}, Publications:{publications}";
        // }

        //overriding ToString() method of Person class
        public override string ToString()
        {
            return $"{base.ToString()}, Publications:{publications}";
        }
    }
}
