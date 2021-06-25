using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class3
    {
        private static object arr;

        static void arrays()
        {
            int[] arr = new int[100];
            int i, num, sum = 0;

            ////Reads size and elements in array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Adding all elements        
            for (i = 0; i < num; i++)
            {
                sum = sum + arr[i]; // Calculating sum
            }

            Console.WriteLine("Sum of all elements of array: " + sum);

            Console.ReadLine();
        }

        static void averagevalue()
        {
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            double avg = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("Average=" + avg);
            Console.ReadLine();
        }

        static void index()
        {
            int[] array = { 2, 4, 6, 8, 6, 2 };

            int result1 = Array.IndexOf(array, 6);
            Console.WriteLine(result1);

            int result2 = Array.LastIndexOf(array, 6);
            Console.WriteLine(result2);

            int result3 = Array.LastIndexOf(array, 100);
            Console.WriteLine(result3);
        }

        static void specificvalue()
        {

            // Create and initialize array
            string[] ds = {"Array", "Queue", "LinkedList",
                               "Stack", "Graph" };

            // Display ds array
            Console.WriteLine("Given Array: ");

            foreach (string i in ds)
            {
                Console.WriteLine(i);
            }

            // Display and check the given elements with the
            // specified letter is present in the array or not
            // Using Exists() method
            Console.WriteLine("Is element start with L letter is present in array: {0}",
                              Array.Exists(ds, element => element.StartsWith("L")));

            Console.WriteLine("Is element start with O letter is present in array: {0}",
                              Array.Exists(ds, element => element.StartsWith("O")));
        }

        static void remove()
        {
            int[] array = { 1, 3, 4, 5, 4, 2 };
            int item = 4;

            array = array.Where(e => e != item).ToArray();
            Console.WriteLine(String.Join(",", array));
        }

        static void copy()
        {
            int[] arr = new int[100];

            int[] first = new int[100];
            int[] second = new int[100];

            int i, num;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                first[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Copy all elements from first array to second array
            for (i = 0; i < num; i++)
            {
                second[i] = first[i];
            }

            //Printing all elements of first array entered by user
            Console.WriteLine("Elements of first array are:");
            for (i = 0; i < num; i++)
            {
                Console.Write(first[i] + "\t");
            }

            //Printing all elements of second array
            Console.WriteLine("\nElements of second array are:");
            for (i = 0; i < num; i++)
            {
                Console.Write(second[i] + "\t");
            }


            Console.ReadLine();

        }

        static void insert()
        {

            int[] arr = new int[100];
            int i, num, size, position;

            // Reading array size & elements in the array
            Console.WriteLine("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Reading element to insert & position of the element

            Console.WriteLine("Enter element to insert: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the element position: ");
            position = Convert.ToInt32(Console.ReadLine());

            //checking elements valis position

            if (position > size + 1 || position <= 0)
            {
                Console.WriteLine("Invalid position! Please enter position between 1 to " + num);
            }
            else
            {
                //Inserting element in an array & increasing the size of the array

                for (i = size; i >= position; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[position - 1] = num;
                size++;

                // Printing new array with new element

                Console.WriteLine("Array elements after insertion :");

                for (i = 0; i < size; i++)
                {
                    Console.WriteLine(arr[i] + "\t");
                }
            }

            Console.ReadLine();
        }

        static void minmax()
        {

            int[] Arr = { 20, -10, -30, 0, 15, 10, 30 };
            Console.WriteLine("Maximum Element : " + Arr.Max());
            Console.WriteLine("Minimum Element : " + Arr.Min());
            Console.Read();
        }

        static void reverse()
        {
            int[] array = new int[100];
            int size, i;


            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Print array in reversed order
            Console.WriteLine("\nArray in reverse order: ");
            for (i = size - 1; i >= 0; i--)
            {
                Console.Write("\t" + array[i]);
            }

            Console.ReadLine();
        }

        static void dupluicate()
        {
            int[] arr = new int[100];
            int i, j, num, count = 0;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Find all duplicate elements in array
            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadLine();
        }

        static void commonvalues()
        {
            int[] array1 = { 11, 14, 22, 28, 37 };
            int[] array2 = { 37, 35, 59, 21, 40, 32, 56 };
            // Call Intersect extension method.  
            var intersect = array1.Intersect(array2);

            foreach (int value in intersect)
            {
                Console.WriteLine(value);
            }
        }

        static void deleteduplicatearrays()
        {
            int[] arr = new int[100];
            int num; // Total number of elements in array
            int i, j, k;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Finding all duplicate elements in array

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    //If any duplicate found */
                    if (arr[i] == arr[j])
                    {
                        // Delete the current duplicate element
                        for (k = j; k < num; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        //Decrement size after removing duplicate element
                        num--;

                        // If shifting of elements occur then don't increment j
                        j--;
                    }
                }
            }

            // Print array after deleting duplicate elements
            Console.WriteLine("\nArray elements after deleting duplicates : ");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }

        static void secondlargest()
        {
            int num, i, j = 0, lrg, lrg2nd;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            num = Convert.ToInt32(Console.ReadLine());

            //Stored values into the array
            Console.Write("Input {0} elements in the array :\n", num);
            for (i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // find location of the largest element in the array 
            lrg = 0;

            for (i = 0; i < num; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            // ignore the largest element and find the 2nd largest element in the array 
            lrg2nd = 0;
            for (i = 0; i < num; i++)
            {
                if (i == j)
                {
                    i++;  //ignoring the largest element 
                    i--;
                }
                else
                {
                    if (lrg2nd < arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
            Console.ReadLine();
        }

        static void oddevenarray()
        {
            int[] arr = new int[100];
            int i, num, evennum, oddnum;

            ////Reads size and elements in array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; // Assuming 0 even numbers
            oddnum = 0; // Assuming 0 odd numbers

            for (i = 0; i < num; i++)
            {
                /* If the current element of array is evennumber then increment evennumber count */
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; // increment oddnumber count
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);


            Console.ReadLine();
        }

        static void largesmallarray()
        {
            Console.WriteLine("Difference between the largest and smallest values: ");
            Console.WriteLine(test(new[] { 1, 5, 7, 9, 10, 12 }));
        }
        static int test(int[] nums)
        {
            int small_num = 0, biggest_num = 0;

            if (nums.Length > 0) small_num = biggest_num = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                small_num = Math.Min(small_num, nums[i]);
                biggest_num = Math.Max(biggest_num, nums[i]);
            }

            return biggest_num - small_num;
        }

        static void specificvalueblw()
        {
            // Create and initialize array
            string[] ds = { "" };

            // Display ds array
            Console.WriteLine("Given Array: ");

            foreach (string i in ds)
            {
                Console.WriteLine(i);
            }

            // Display and check the given elements with the
            // specified letter is present in the array or not
            // Using Exists() method
            Console.WriteLine("Is element start with L letter is present in array: {0}",
                              Array.Exists(ds, element => element.StartsWith("L")));

            Console.WriteLine("Is element start with O letter is present in array: {0}",
                              Array.Exists(ds, element => element.StartsWith("O")));
        }

        static void returnvalue()
        {
        }

        static void miss()
        {
            int[] arr = { 1, 2, 3, 5 };
            Console.Write(getMissingNo(arr, (arr.Length)));

            // Console.Write(getMissingNo(arr, 4));
        }

        private static string getMissingNo(int[] arr, int length)
        {
            throw new NotImplementedException();
        }
    }
}