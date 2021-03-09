using System;
using OutstandingPersonApp.Entities;

namespace OutstandingPersonApp.UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //creatong an object of an array (Array) where type of references is Person or child classes of Person
            Person[] people = new Person[]
            {
                new Professor("anil",10),
                new Student("sunil",89),
                new Professor("suresh",3),
                new Student("mahesh",78),
            };

            foreach (Person person in people)
            {
                if (person != null)
                {
                    if (person.IsOutstanding())
                    {
                        // if (person is Professor)
                        // {
                        //     Professor professor = person as Professor;
                        //     System.Console.WriteLine(professor.Print());
                        // }
                        // if (person is Student)
                        // {
                        //     Student student = person as Student;
                        //     System.Console.WriteLine(student.Show());
                        // }
                        // System.Console.WriteLine(person.ToString());
                        
                        //ToString() method gets called implicitly
                        System.Console.WriteLine(person);
                    }
                }
            }
        }
    }
}
