﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ComparisonDemo
{
    class Person //: IComparable<Person>
    {
        private int id;
        private string name;

        public Person()
        {

        }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Id: {this.id}";
        }
        public override int GetHashCode()
        {
            return this.id.GetHashCode() * (this.name != null ? this.name.GetHashCode() : 31);
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Person)
                {
                    Person other = obj as Person;
                    if (this == other)
                        return true;

                    if (!this.id.Equals(other.id))
                        return false;

                    if (!this.name.Equals(other.name))
                        return false;

                    return true;
                }
                else
                    throw new ArgumentException($"Desired argument type:{nameof(Person)}, but passed agument type is:{obj.GetType().Name}");
            }
            else
                throw new NullReferenceException("Can't check eqaulity, since null reference has been passed");
        }

        /*
         public int CompareTo([AllowNull] Person other)
         {
             //int idResult = this.id.CompareTo(other.id);
             if (this.id.CompareTo(other.id) == 0)
             {
                 return this.name.CompareTo(other.name);
             }
             else
                 return this.id.CompareTo(other.id);
         }
         */
        public static bool operator >(Person left, Person right)
        {
            if (left.id == right.id)
            {
                if (left.name.CompareTo(right.name) > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                if (left.id > right.id)
                    return true;
                else
                    return false;
            }
        }
        public static bool operator <(Person left, Person right)
        {
            if (left.id == right.id)
            {
                if (left.name.CompareTo(right.name) < 0)
                    return true;
                else
                    return false;
            }
            else
            {
                if (left.id < right.id)
                    return true;
                else
                    return false;
            }
        }
    }

    class PersonComparison : IComparer<Person>
    {
        private char choice;

        public PersonComparison()
        {

        }

        public PersonComparison(char choice)
        {
            this.choice = choice;
        }

        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            //if (x.Id.CompareTo(y.Id) == 0)
            //{
            //    return x.Name.CompareTo(y.Name);
            //}
            //else
            //    return x.Id.CompareTo(y.Id);
            int res = 0;
            switch (choice)
            {
                case 'n':
                    res = x.Name.CompareTo(y.Name);
                    break;

                case 'i':
                    res = x.Id.CompareTo(y.Id);
                    break;

                default:
                    res = x.Id.CompareTo(y.Id);
                    break;
            }
            return res;
        }
    }
    class Program
    {
        static void Main()
        {
            //SortNumberList();
            SortPersonList();
        }
        private static void SortNumberList()
        {
            List<int> numberList = new List<int> { 1, 4, 3, 6, 5, 2, 9, 7, 8, 0 };
            //for (int i = 0; i < numberList.Count; i++)
            //{
            //    for (int j = i + 1; j < numberList.Count; j++)
            //    {
            //        int temp = 0;
            //        //if (numberList[i] > numberList[j])
            //        if (numberList[i].CompareTo(numberList[j]) > 0)
            //        {
            //            temp = numberList[i];
            //            numberList[i] = numberList[j];
            //            numberList[j] = temp;
            //        }
            //    }
            //}
            numberList.Sort();
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
        }
        private static void SortPersonList()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(3, "anil"));
            people.Add(new Person(2, "sunil"));
            people.Add(new Person(1, "Joydip"));

            Console.WriteLine("1. sort by name");
            Console.WriteLine("2. sort by id");

            Console.Write("Enter Choice[n/i]: ");
            char choice = char.Parse(Console.ReadLine());

            PersonComparison comparison = new PersonComparison(choice);
            /*
            for (int i = 0; i < people.Count; i++)
            {
                for (int j = i + 1; j < people.Count; j++)
                {
                    Person tempRef = null;
                    //if (people[i] > people[j])
                    //if (people[i].CompareTo(people[j]) > 0)
                    if (comparison.Compare(people[i], people[j]) > 0)
                    {
                        tempRef = people[i];
                        people[i] = people[j];
                        people[j] = tempRef;
                    }
                }
            }
            */
            //people.Sort(); <-- call this method when Person has implemented IComparable<Person> and CompareTo method
            people.Sort(comparison);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

        }
    }
}