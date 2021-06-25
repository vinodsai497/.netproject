using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    partial class Class9
    {
        public interface IControl
        {
            void Paint();
        }
        public interface ISurface
        {
            void Paint();
        }
        public class SampleClass : IControl, ISurface
        {
            // Both ISurface.Paint and IControl.Paint call this method.
            public void Paint()
            {
                Console.WriteLine("Paint method in SampleClass");
            }
        }

        interface ILeft
        {
            int P { get; }
        }
        interface IRight
        {
            int P();
        }

        class Middle : ILeft, IRight
        {
            public int P() { return 0; }
            int ILeft.P { get { return 0; } }
        }

        // interface declaration
        interface Vehicle
        {

            // all are the abstract methods.
            void changeGear(int a);
            void speedUp(int a);
            void applyBrakes(int a);
            void printStates();
        }

        // class implements interface
        class Bicycle : Vehicle
        {

            int speed;
            int gear;

            // to change gear
            public void changeGear(int newGear)
            {

                gear = newGear;
            }

            // to increase speed
            public void speedUp(int increment)
            {

                speed = speed + increment;
            }

            // to decrease speed
            public void applyBrakes(int decrement)
            {

                speed = speed - decrement;
            }

            public void printStates()
            {
                Console.WriteLine("speed: " + speed + " gear: " + gear);
            }
        }

        // interface declaration
        public interface Race
        {

            // declaration of abstract methods of
            // interface that will be implemented 
            // by the class which inherits the interface
            void Speed(int s);
            void Distance(int d);
        }

        // class implementing interface
        public class Person1 : Race
        {

            int sp1, di1;

            // abstract method of 
            // Race interface
            public void Speed(int p1s)
            {

                sp1 = p1s;
                Console.WriteLine("Speed Method implemented by Person1");

            }

            // abstract method of 
            // Race interface
            public void Distance(int p1d)
            {

                di1 = p1d;
                Console.WriteLine("Distance Method implemented by Person1");

            }

            // method of class Person1
            public void display1()
            {

                Console.WriteLine("The Speed of 1st person is: " + sp1);
                Console.WriteLine("The distance covered by 1st person is: " + di1);

            }

        }

        public class MorrisGarage
        {
            public void GetMileage()
            {
                Console.WriteLine("10 KM Per Liter");
            }

            public void GetSpeed()
            {
                Console.WriteLine("200 KMPH");
            }

            public void SendCommand()
            {
                Console.WriteLine("Command Sent via Morris Garage Class");
            }
        }

        // declaring an interface
        public interface A
        {

            // method of interface
            void mymethod1();
            void mymethod2();
        }

        // The methods of interface A 
        // is inherited into interface B
        public interface B : A
        {

            // method of interface B
            void mymethod3();
        }


        // Below class is inherting
        // only interface B
        // This class must 
        // implement both interfaces
        class Geeks : B
        {

            // implementing the method
            // of interface A
            public void mymethod1()
            {
                Console.WriteLine("Implement method 1");
            }

            // Implement the method 
            // of interface A
            public void mymethod2()
            {
                Console.WriteLine("Implement method 2");
            }

            // Implement the method
            // of interface B
            public void mymethod3()
            {
                Console.WriteLine("Implement method 3");
            }
        }
    }
}