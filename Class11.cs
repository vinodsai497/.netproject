using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class10
    {
        class Geek
        {

            int num;
            string name;

            // this would be invoked while the
            // object of that class created.
            Geek()
            {
                Console.WriteLine("Constructor Called");
            }

        }

        class Coords
        {
            public int x, y;

            // Default constructor.
            public Coords()
            {
                x = 0;
                y = 0;
            }

            // A constructor with two arguments.
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // Override the ToString method.
            public override string ToString()
            {
                return $"({x},{y})";
            }
        }

        class MainClass
        {
            static void Main()
            {
                var p1 = new Coords();
                var p2 = new Coords(5, 3);

                // Display the results using the overriden ToString method.
                Console.WriteLine($"Coords #1 at {p1}");
                Console.WriteLine($"Coords #2 at {p2}");
                Console.ReadKey();
            }
        }

        class paraconstrctor
        {
            public int a, b;
            public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
            {
                a = x;
                b = y;
            }
        }

        public class ConstructMe
        {
            public string name;
            public int id;
            public ConstructMe(string Name, int id)
            {
                this.name = Name;
                this.id = id;
            }

        }
        class cnstrct
        {
            static void Main(string[] args)
            {
                ConstructMe a = new ConstructMe("Daniel", 28);
                Console.WriteLine($"The instance with name: {nameof(a)}, has property name: {a.name} and id: {a.id}");
                Console.ReadKey(); ;
            }
        }
    }
}
