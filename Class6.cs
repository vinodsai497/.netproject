using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class5
    {
        static void strings()
        {
            string ch = "S";
            string word = "String";
            string text = "This is a string.";

            Console.WriteLine(ch);
            Console.WriteLine(word);
            Console.WriteLine(text);
        }

        static void concatente()
        {
            string userName = "<my name is teja >";
            string dateString = DateTime.Today.ToShortDateString();

            // Use the + and += operators for one-time concatenations.
            string str = "Hello " + userName + ". Today is " + dateString + ".";
            System.Console.WriteLine(str);

            str += " How are you today?";
            System.Console.WriteLine(str);
        }

        static void lengthofstring()
        {
            string str;
            int length = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                length += 1;

            }
            Console.Write("Length of the string is : {0}\n\n", length);

            Console.ReadLine();
        }

        static void substing()
        {
            String value = "This is a string.";
            int startIndex = 5;
            int length = 2;
            String substring = value.Substring(startIndex, length);
            Console.WriteLine(substring);

            // The example displays the following output:
            //       is
        }

        static void indexof()
        {
            string str = "TEJA";

            // Finding the index of character 
            // which is present in string and
            // this will show the value 5
            int index1 = str.IndexOf('F');

            Console.WriteLine("The Index Value of character 'F' is " + index1);

            // Now finding the index of that character which
            //  is not even present with the string
            int index2 = str.IndexOf('C');

            // As expected, this will output value -1
            Console.WriteLine("The Index Value of character 'C' is " + index2);

        }

        static void matching()
        {
            string pattern = @"\ba\w*\b";
            string input = "An extraordinary day dawns with each new day.";
            Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            if (m.Success)
                Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);

        }

        static void equal()
        {
            string str1 = "LONDON";
            string str2 = "london";

            str1.Equals(str2, StringComparison.CurrentCultureIgnoreCase); // true
        }

        static void endwith()
        {
            String[] strings = { "This is a string.", "Hello!", "Nothing.",
                           "Yes.", "randomize" };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("'{0}' ends in a period: {1}",
                                  value, endsInPeriod);
            }

        }

        static void trim()
        {
            // String with whitespaces  
            string hello = " hello C# Corner has white spaces ";
            // Remove whitespaces from both ends  
            Console.WriteLine(hello.Trim());

            // String with characters  
            string someString = ".....My name is Mahesh Chand**";
            char[] charsToTrim = { '*', '.' };
            string cleanString = someString.Trim(charsToTrim);
            Console.WriteLine(cleanString);
        }

        static void replace()
        {
            /* Replace sample */
            // Replace a char    
            string odd = "1, 3, 5, 7, 9, 11, 13, 15, 17, 19";
            Console.WriteLine("Original odd: {odd}");
            string newOdd = odd.Replace(',', ':');
            Console.WriteLine("New Odd: {newOdd}");
            string authors = "Mahesh Beniwal, Neel Beniwal, Raj Beniwal, Dinesh Beniwal";
            Console.WriteLine("Authors with last names: {authors}");
            // Remove all Beniwal with space and remove space with empty string    
            string firstNames = authors.Replace(" Beniwal", "");
            Console.WriteLine("Authors without last names: {firstNames}");
            Console.ReadKey();
        }

        static void split()
        {
            Console.WriteLine("Split with multiple separators");
            // Split with multiple separators  
            string multiCharString = "Mahesh..Chand, Henry\n He\t, Chris-Love, Raj..Beniwal, Praveen-Kumar";
            // Split authors separated by a comma followed by space  
            string[] multiArray = multiCharString.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string author in multiArray)
            {
                if (author.Trim() != "")
                    Console.WriteLine(author);
            }
        }

        static void convering()
        {
            String s;
            int num = 299;
            s = num.ToString();
            Console.WriteLine("String = " + s);
            Console.ReadLine();
        }

        static void converting()
        {
            int number = Int32.MaxValue;
            // creating and initializing the object of CultureInfo
            CultureInfo provider = new CultureInfo("fr-FR");
            // declaring and intializing format
            string format = "D5";
            // using the method
            string str = number.ToString(format, provider);
        }

        static void uppercasetolowercase()
        {
            string author = "Mahesh Chand";
            string bio = "Mahesh Chand is a founder of C# Corner.";

            // Covert everything to uppercase  
            string ucaseAuthor = author.ToUpper();
            Console.WriteLine($"Uppercase: {ucaseAuthor}");

            // Covert everything to lowercase  
            string lcaseAuthor = author.ToLower();
            Console.WriteLine($"Lowercase: {lcaseAuthor}");

            // We can direct convert to uppercase or lowercase  
            Console.WriteLine(bio.ToLower());
            Console.WriteLine(bio.ToUpper());
        }
    }
}