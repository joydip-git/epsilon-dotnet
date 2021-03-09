using System;

namespace OutstandingPersonApp.Entities
{
    public class Student : Person
    {
        int marks;

        public Student()
        {

        }
        public Student(string name, int marks)
        : base(name)
        {
            this.marks = marks;
        }

        public int Marks { get => marks; set => marks = value; }

        //this abstract method of bae class must be implemented in this class
        //otherwise this class will be an abstract class
        public override bool IsOutstanding()
        {
            return marks > 85;
        }

        // public string Show()
        // {
        //     return $"{base.ToString()}, Marks:{marks}";
        // }

        //overriding ToString() method of Person class
        public override string ToString()
        {
            return $"{base.ToString()}, Marks:{marks}";
        }
    }
}
