using System;
namespace OutstandingPersonApp.Entities
{
    //an abstract class object can't be created
    public abstract class Person //:Object --> virtual string ToString(){}
    {
        string name;

        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }

        //public sbstarct string Name { get; set ; }

        //V1
        //public virtual bool IsOutstanding()
        // {
        //     return false;
        // }

        public abstract bool IsOutstanding();

        //overriding ToString() method of Object class
        public override string ToString()
        {
            return $"Name:{name}";
        }
    }
}
