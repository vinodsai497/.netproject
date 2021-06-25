using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {

        static void operators()
        {
            int result;
            int x = 40; int y = 10;
            result = (x + y);
            Console.WriteLine("add operator:" + result);
            result = (x - y);
            Console.WriteLine("sub operator:" + result);
            result = (x * y);
            Console.WriteLine("mul operator:" + result);
            result = (x / y);
            Console.WriteLine("div operator:" + result);
        }

        static void incementanddecrement()
        {
            int a = 4; int b = 5;
            Console.WriteLine(a++);
            Console.WriteLine(++b);
            Console.WriteLine(a--);
            Console.WriteLine(--b);
        }

        static void Equalandnotequal()
        {
            int a = 10;
            int b = 8;
            if (a == b)
                Console.WriteLine("both are equal");
            else
                Console.WriteLine("both are not equal");

        }

        static void equalandnotequal()
        {
            int int1, int2;
            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        }

        static void logicaloperators()
        {
            int x = 15, y = 10;
            bool a = true, result;
            // AND operator
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            // OR operator
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
            //NOT operator
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }

        static void relationaloperators()
        {
            int a = 21;
            int b = 10;

            if (a == b)
            {
                Console.WriteLine("Line 1 - a is equal to b");
            }
            else
            {
                Console.WriteLine("Line 1 - a is not equal to b");
            }

            if (a < b)
            {
                Console.WriteLine("Line 2 - a is less than b");
            }
            else
            {
                Console.WriteLine("Line 2 - a is not less than b");
            }

            if (a > b)
            {
                Console.WriteLine("Line 3 - a is greater than b");
            }
            else
            {
                Console.WriteLine("Line 3 - a is not greater than b");
            }

            /* Lets change value of a and b */
            a = 5;
            b = 20;

            if (a <= b)
            {
                Console.WriteLine("Line 4 - a is either less than or equal to  b");
            }

            if (b >= a)
            {
                Console.WriteLine("Line 5-b is either greater than or equal to b");
            }
        }

        static void largerandsmallernumber()
        {
            int i;
            int[] a = new int[30]; // Array Declaration in C#  
            Console.Write("Enter the Number of values to find Smallest and Largest Number: ");
            int n = Convert.ToInt16(Console.ReadLine());
            // read the string value and convert it in to integer  
            //Reading the values one by one  
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            //Display the Smallest value  
            Console.WriteLine("The smallest Value is " + a[1]);
            //Display the Biggest Value  
            Console.WriteLine("The Largest Value is " + a[n]);
            //Waiting for output  
            Console.ReadKey();
        }
    }
}
