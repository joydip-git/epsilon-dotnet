using System;
using System.Collections; //ArrayList, ...,HashTable, SortedList
using System.Collections.Generic; //List<T>, HashSet<T>, Dictionary<TKey,TValue>,
//SortedList<TKey,TValue>

namespace CollectionsDemo
{
    class Person
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

        public override int GetHashCode()
        {
            const int random = 31;
            int hash = this.name != null ? this.name.GetHashCode() * random : random * random;
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person other = obj as Person;

                if (this == other)
                    return true;

                if (!this.name.Equals(other.name))
                    return false;

                return true;
            }
            else
                return false;
        }
    }
    class Program
    {
        static void ArrayListDemo()
        {
            //object[] arr = new object[4];
            //object[] temp = new object[arr.Length*2];
            //Array.Copy(arr,temp,arr.Length);
            //arr = temp;
            //temp=null;

            ArrayList al = new ArrayList();
            al.Add(12);
            al.Add(12.34);
            al.Add('a');
            al.Add("epsilon");
            al.Add(13);
            al.Add('a');
            //possible index number <= no of elements cuurently present
            al.Insert(1, 100);

            //al.Remove('a');
            //int index = al.IndexOf('a');
            //al.RemoveAt(index);

            Console.WriteLine($"No of elements: {al.Count}");
            Console.WriteLine($"Actual capacity: {al.Capacity}");
            //Length (Array) and Count (Collection) --> different
            //string[] arr = new string[10];

            //for (int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}
            //foreach (object item in al)
            //{
            //    if (item is char)
            //    {
            //        if ((char)item == 'a')
            //        {
            //            int index = al.IndexOf('a');
            //            al.RemoveAt(index);
            //        }
            //    }
            //}

            //IEnumerator enumerator = al.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
        }
        static void ListDemo()
        {
            List<int> intList = new List<int>();
            intList.Add(12);
            intList.Add(13);
            intList.Add('a');

            //intList.Add
            //intList.Insert
            //intList.Remove
            //intList.RemoveAt

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
            Console.WriteLine("\n\n");
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
            IEnumerator<int> enumerator = intList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        static void HashSetDemo()
        {
            HashSet<int> intSet = new HashSet<int>();
            intSet.Add(12);
            intSet.Add(13);
            intSet.Add(12);

            bool status = intSet.Remove(13);
            if (status)
                Console.WriteLine("removed");
            else
                Console.WriteLine("not removed");

            //for (int i = 0; i < intSet.Count; i++)
            //{
            //    Console.WriteLine(intSet[i]);
            //}
            foreach (int item in intSet)
            {
                Console.WriteLine(item);
            }
        }
        static void HashSetOfEntities()
        {
            Person anilPerson = new Person("anil");
            Person notduplicate = new Person("sunil");
            HashSet<Person> peopleSet = new HashSet<Person>();
            peopleSet.Add(anilPerson);
            peopleSet.Add(notduplicate);
            //if(anilPerson.Equals(duplicate))

            foreach (Person item in peopleSet)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void HashTableDemo()
        {
            //collection
            Hashtable hashtable = new Hashtable();

            hashtable.Add('a', 10);
            //new DictionaryEntry('a',10);
            hashtable.Add(9, "ëpsilon");
            hashtable.Add(12.34, 'x');

            //hashtable.Remove('a');

            //hashtable[key]

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
            }

            Console.WriteLine("\n\n");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"Key:{key}, Value:{hashtable[key]}");
            }
        }
        static void DictionaryDemo()
        {
            //generic hashtable kind of collection
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(9, "bangalore");
            //new DictionaryEntry('a',10);
            dictionary.Add(0, "ëpsilon");
            dictionary.Add(12, "dotnet");

            //hashtable.Remove('a');

            //hashtable[key]

            foreach (KeyValuePair<int, string> entry in dictionary)
            {
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
            }

            Console.WriteLine("\n\n");
            foreach (int key in dictionary.Keys)
            {
                Console.WriteLine($"Key:{key}, Value:{dictionary[key]}");
            }
        }
        static void SortedListDemo()
        {
            //collection
            SortedList sortedList = new SortedList();

            //ALL KEYS MUST BE OF SIMILAR TYPE (YOU MUST REMEMBER)--No compiltaion error, directly exception during runtime
            sortedList.Add(9, 10);
            //new DictionaryEntry('a',10);
            sortedList.Add(0, "ëpsilon");
            sortedList.Add(12, 'x');

            //sortedList.Remove('a');

            //sortedList[key]

            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
            }

            Console.WriteLine("\n\n");
            foreach (object key in sortedList.Keys)
            {
                Console.WriteLine($"Key:{key}, Value:{sortedList[key]}");
            }
        }
        static void SortedListGenericDemo()
        {
            //generic sortedlist collection
            SortedList<int, string> sortedList = new SortedList<int, string>();

            //ALL KEYS MUST BE OF SIMILAR TYPE (NO NEED TO REMEBER, GENERIC TYPE MAKES SURE ALL THE KEYS ENTERED ARE SAME)--will get compilation error if not followed
            sortedList.Add(9, "bng");
            //new DictionaryEntry('a',10);
            sortedList.Add(0, "ëpsilon");
            sortedList.Add(12, "dotnet");

            //sortedList.Remove('a');

            //sortedList[key]

            foreach (KeyValuePair<int, string> entry in sortedList)
            {
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
            }

            Console.WriteLine("\n\n");
            foreach (int key in sortedList.Keys)
            {
                Console.WriteLine($"Key:{key}, Value:{sortedList[key]}");
            }
        }
        static void Main()
        {
            //ArrayListDemo();
            //ListDemo();
            //HashSetDemo();
            //HashSetOfEntities();
            //HashTableDemo();
            //SortedListDemo();
            //DictionaryDemo();
            SortedListGenericDemo();
        }
    }
}
