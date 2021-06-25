using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        static void loop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("BRIGHT IT CAREER");
            }

        }

        static void Whileloop()
        {
            int a;
            a = 1;
            while (a <= 20)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();
        }

        static void equalandnotequalusingloops()
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("a==b:{0}", (a == b));
            Console.WriteLine("a!==b:{0}", (a != b));
            Console.ReadLine();
        }

        static void oddandeven()
        {

            int num1 = 100;
            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Number {0} is Even", i);
                }
                else
                {
                    Console.WriteLine("Number {0} is odd", i);
                }
            }
            Console.ReadLine();
        }

        static void largestamongthreenumbers()
        {
            int num1, num2, num3;
            // set the value of the three numbers
            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("Number two is the largest!\n");
            }
            else
            {
                Console.Write("Number three is the largest!\n");
            }

        }

        static void even()
        {
            int i = 0;
            Console.WriteLine("even nNumbers:");
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                    Console.ReadLine();
                }
            }
        }

        static void whileloop()
        {
            int a;
            a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
            {
                Console.ReadLine();
            }

        }

        static void amstrongnumber()
        {

            int number, rem, temp, sum = 0;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("          Check Number Is Armstrong Or Not             ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("371 :: ");
            number = int.Parse(Console.ReadLine());

            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
            Console.ReadLine();

        }

        static void prime()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("2: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }

        static void palindrome()
        {

            int n, r, sum = 0, temp;
            Console.Write("121: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.Write("Number is Palindrome.");
            }
            else
            {
                Console.Write("Number is not Palindrome");
            }
        }


        static void evenoddswitch()
        {
            int num;

            //Reading a number from user
            Console.Write("40: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2)
            {
                //If n%2 == 0
                case 0:
                    Console.WriteLine(num + " is even number");
                    break;

                //Else if n%2 == 1
                case 1:
                    Console.WriteLine(num + " is odd number");
                    break;
            }

            Console.ReadLine();
        }


        static void gender()
        {
            char gender;

            //Reading gender from user
            Console.WriteLine("Enter gender (M/m or F/f): ");
            gender = Convert.ToChar(Console.ReadLine());


            // checking vowel and consonant
            switch (gender)
            {
                case 'M':
                case 'm':
                    Console.WriteLine("MALE");
                    break;

                case 'F':
                case 'f':
                    Console.WriteLine("FEMALE");
                    break;

                default:
                    Console.WriteLine("Unspecified Gender");
                    break;
            }

            Console.ReadLine();
        }

        static void ifelsestatement()
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("30 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("20 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("10:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }

    }
}
