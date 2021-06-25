using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Stopwatch
    {
        // static constructor
        static Stopwatch()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public Stopwatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }
    class Marks
    {
        // These variables are instance variables.
        // These variables are in a class and
        // are not inside any function
        int engMarks;
        int mathsMarks;
        int phyMarks;

        // Main Method
        public static void Main(String[] args)
        {

            // first object
            Marks obj1 = new Marks();
            obj1.engMarks = 90;
            obj1.mathsMarks = 80;
            obj1.phyMarks = 93;

            // second object
            Marks obj2 = new Marks();
            obj2.engMarks = 95;
            obj2.mathsMarks = 70;
            obj2.phyMarks = 90;

            // displaying marks for first object
            Console.WriteLine("Marks for first object:");
            Console.WriteLine(obj1.engMarks);
            Console.WriteLine(obj1.mathsMarks);
            Console.WriteLine(obj1.phyMarks);

            // displaying marks for second object
            Console.WriteLine("Marks for second object:");
            Console.WriteLine(obj2.engMarks);
            Console.WriteLine(obj2.mathsMarks);
            Console.WriteLine(obj2.phyMarks);
        }

        class Emp
        {

            // static variable salary
            static double salary;
            static String name = "Aks";

            // Main Method
            public static void Main(String[] args)
            {

                // accessing static variable
                // without object
                Emp.salary = 100000;

                Console.WriteLine(Emp.name + "'s average salary:"
                                                   + Emp.salary);
            }



            public class MyClass
            {
                private void data1()
                {
                }
                private static void data2()
                {
                    MyClass c = new MyClass();
                    c.data1();
                }
            }

            class Car
            {
                //Static method or class method
                public static void run()
                {
                    Console.WriteLine("I'm Static method");
                }

                //non static method or instanse method
                public void engine()
                {
                    Console.WriteLine("I'm non-static/instance method!!!");
                }

            }
        }
    }
}
