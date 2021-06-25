using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class11
    {
        public class Book
        {
            private string author;
            private string title;
            private string publisher;
            private DateTime publishedOn;
            private decimal price;
            public Book(string author, string title, string publisher,
            DateTime pubdate, decimal price)
            {
                this.author = author;
                this.title = title;
                this.publisher = publisher;
                this.publishedOn = pubdate;
                this.price = price;
            }
            public decimal Price { get => price; }
        }

        public class Animal
        {
            public string color = "white";
        }
        public class Dog : Animal
        {
            string color = "black";
            public void showColor()
            {
                Console.WriteLine(base.color);
                Console.WriteLine(color);
            }
        }

        class Geek
        {
            // Constructor without parameter
            public Geek()
            {
                Console.WriteLine("Hello! Constructor 1");
            }

            // Constructor with parameter
            // Here this keyword is used
            // to call Geek constructor
            public Geek(int a)
            : this()
            {
                Console.WriteLine("Hello! Constructor 2");
            }
        }


        class ToyCar
        {
            public string nameToy;
            public int speed;

            public ToyCar() { }
            public ToyCar(int s) : this("", s) { }
            public ToyCar(string n) : this(n, 0) { }
            public ToyCar(string n, int s)
            {
                if (s < 10)
                    speed = 10;
                speed = s;
                nameToy = n;
            }

            public void SetName(string name)
            {
                this.nameToy = name;
            }

            public void PrintState()
            {
                Console.WriteLine("{0}'s speed is {1} mph.", nameToy, speed);
            }

            static void Main(string[] args)
            {
                ToyCar myToy = new ToyCar(100);
                myToy.SetName("Boom Boom Boom");
                myToy.PrintState();

                Console.WriteLine();
            }
        }
    }
}
