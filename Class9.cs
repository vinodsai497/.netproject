using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class8
    {
        // Abstract class
        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Pig : Animal
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Pig myPig = new Pig(); // Create a Pig object
                myPig.animalSound();  // Call the abstract method
                myPig.sleep();  // Call the regular method
            }
        }

        public abstract class MyClass
        {
            public abstract void calculate(double x);
        }
        class Sub1 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
            }
        }
        public class Sub2 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("SQUARE is :" + (x * x));
            }
        }
        public class Sub3 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("CUBE is :" + (x * x * x));
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                Sub1 obj1 = new Sub1();
                Sub2 obj2 = new Sub2();
                Sub3 obj3 = new Sub3();
                obj1.calculate(9);
                obj2.calculate(9);
                obj3.calculate(9);
                Console.ReadKey();
            }
        }

        abstract class AbstractClass
        {

            // Non abstract method
            public int AddTwoNumbers(int Num1, int Num2)
            {
                return Num1 + Num2;
            }

            // An abstract method which
            // overridden in the derived class
            public abstract int MultiplyTwoNumbers(int Num1, int Num2);

        }

        // Child Class of AbstractClass
        class Derived : AbstractClass
        {

            // implementing the abstract
            // method 'MultiplyTwoNumbers'
            // using override keyword,
            public override int MultiplyTwoNumbers(int Num1, int Num2)
            {
                return Num1 * Num2;
            }
        }

        public class MyObject
        {

            // Some properties and a location.
            internal object Prop1;
            internal object Prop2;
        }

        public class MyObjectSearch : MyObject
        {

            public double Distance { get; set; }

            public MyObjectSearch(MyObject obj)
            {
                base.Prop1 = obj.Prop1;
                base.Prop2 = obj.Prop2;
            }
        }
    }
}
