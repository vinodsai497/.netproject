using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class6
    {

        public class WorkItem
        {
            private static int currentID;


            protected int ID { get; set; }
            protected string Title { get; set; }
            protected string Description { get; set; }
            protected TimeSpan jobLength { get; set; }
            public WorkItem()
            {
                ID = 0;
                Title = "Default title";
                Description = "Default description.";
                jobLength = new TimeSpan();
            }
            public WorkItem(string title, string desc, TimeSpan joblen)
            {
                this.ID = GetNextID();
                this.Title = title;
                this.Description = desc;
                this.jobLength = joblen;
            }
            static WorkItem() => currentID = 0;
            protected int GetNextID()
            {
                return ++currentID;
            }

            public void Update(string title, TimeSpan joblen)
            {
                this.Title = title;
                this.jobLength = joblen;
            }
            public override string ToString() =>
                $"{this.ID} - {this.Title}";
        }
        public class ChangeRequest : WorkItem
        {
            protected int originalItemID { get; set; }

            // Default constructor for the derived class.
            public ChangeRequest() { }

            // Instance constructor that has four parameters.
            public ChangeRequest(string title, string desc, TimeSpan jobLen,
                                 int originalID)
            {

                this.ID = GetNextID();
                this.Title = title;
                this.Description = desc;
                this.jobLength = jobLen;
                this.originalItemID = originalID;
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            // Other properties, methods, events...
        }

        class Program
        {
            static void Main()
            {
                Person person1 = new Person("Leopold", 6);
                Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

                // Declare new person, assign person1 to it.
                Person person2 = person1;

                // Change the name of person2, and person1 also changes.
                person2.Name = "Molly";
                person2.Age = 16;

                Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
                Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);
            }
        }



    }

    public struct Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Application
    {
        static void Main()
        {
            // Create  struct instance and initialize by using "new".
            // Memory is allocated on thread stack.
            Person p1 = new Person("Alex", 9);
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            // Create  new struct object. Note that  struct can be initialized
            // without using "new".
            Person p2 = p1;

            // Assign values to p2 members.
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);
        }
    }

    class baseClass
    {

        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    // Base Class
    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("teja");
        }
    }
}
