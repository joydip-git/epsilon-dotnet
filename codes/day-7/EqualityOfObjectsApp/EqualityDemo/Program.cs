using System;

namespace EqualityDemo
{
    class Person
    {
        string name;
        int id;
        public Person()
        {

        }
        public Person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        //overriding Object class "int GetHashCode()" method
        public override int GetHashCode()
        {
            const int seed = 23;
            int hash = 0;
            hash = this.id.GetHashCode() * seed;
            hash = this.name.GetHashCode() * hash;
            return hash;
        }
        //overriding Object class "bool Equals(objcet obj)" method
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Person)
                {
                    Person other = obj as Person;

                    if (this == other)
                        return true;

                    if (this.id != other.id)
                        return false;

                    if (this.name != other.name)
                        return false;

                    return true;
                }
                else
                {
                    //return false;
                    ArgumentException argEx = new ArgumentException($"argiment is not of type {nameof(Person)}, rather of type {obj.GetType().Name}");
                    throw argEx;
                }
            }
            else
            {
                //return false;
                NullReferenceException nullEx = new NullReferenceException("You have passed no reference to the method");
                throw nullEx;
            }
        }

        // public NullReferenceException Test()
        // {
        //     return new NullReferenceException();
        // }
        //overloading == operator to check eqaulity between two instances of Person 
        public static bool operator ==(Person first, Person second)
        {
            if (first.name.Equals(second.name))
            {
                if (first.id.Equals(second.id))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        //overloading != operator to check Not eqaulity between two instances of Person 
        public static bool operator !=(Person first, Person second)
        {
            if (!first.name.Equals(second.name))
            {
                if (!first.id.Equals(second.id))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        /*
        public static bool operator >(Person first, Person second)
        {
            return false;
        }
        public static bool operator <(Person first, Person second)
        {
            return false;
        }
        public static bool operator >=(Person first, Person second)
        {
            return false;
        }
        public static bool operator <=(Person first, Person second)
        {
            return false;
        }
        */
    }
    class Program
    {
        static void Main()
        {
            /*
            int x = 10;
            int y = 20;
            //if (x == y)
            if (x.Equals(y))
            {
                System.Console.WriteLine("equal");
            }
            else
                System.Console.WriteLine("not equal");
            */
            Person obj1 = new Person("anil", 1);
            //Person obj2 = obj1;
            Person obj2 = new Person("anil", 1);


            //if (obj1.Equals(null))
            if (obj1.Equals(10))
            //if (obj1.Equals(obj1))

            //if (obj1 == obj2)
            //if (obj1.Equals(obj2))
            // if (obj1.GetHashCode() == obj2.GetHashCode())
            // {
            //if (obj1.Equals(obj2))
            {
                System.Console.WriteLine("objects are equal");
            }
            else
                System.Console.WriteLine("objects are not equal");
            // }
            // else
            //     System.Console.WriteLine("objects are not equal");           
        }
    }
}
