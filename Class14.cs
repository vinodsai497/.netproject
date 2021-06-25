using System;
namespace exception_example1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i, k = 0, j;
                Console.Write("Enter a number one: ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number two: ");
                j = Convert.ToInt32(Console.ReadLine());
                k = i / j;
                Console.WriteLine("Output of division : {0}", k);
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
namespace exceptionHandling_example3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Operand1, Operand2;
            double Result = 0.00;
            char Operator;
            Console.WriteLine("This program allows you to perform an operation on two numbers");
            try
            {
                Console.Write("Enter a number: ");
                Operand1 = double.Parse(Console.ReadLine());
                Console.Write("Enter an operator: ");
                Operator = char.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                Operand2 = double.Parse(Console.ReadLine());
                if (Operator != '+' &&
                    Operator != '-' &&
                    Operator != '*' &&
                    Operator != '/')
                    throw new Exception(Operator.ToString());
                if (Operator == '/') if (Operand2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");
                switch (Operator)
                {
                    case '+':
                        Result = Operand1 + Operand2;
                        break;
                    case '-':
                        Result = Operand1 - Operand2;
                        break;
                    case '*':
                        Result = Operand1 * Operand2;
                        break;
                    case '/':
                        Result = Operand1 / Operand2;
                        break;
                    default:
                        Console.WriteLine("Bad Operation");
                        break;
                }
                Console.WriteLine("\n{0} {1} {2} = {3}", Operand1, Operator, Operand2, Result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nOperation Error: {0} is not a valid operator", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
class MyClient
{
    public static void Main()
    {
        int x = 0;
        int div = 0;
        try
        {
            div = 100 / x;
            Console.WriteLine("This linein not executed");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception occured");
        }
        Console.WriteLine($"Result is {div}");
    }
}
  
class g
{

    // Main Method
    static void Main()
    {

        // Here, number is greater than divisor
        int[] number = { 8, 17, 24, 5, 25 };
        int[] divisor = { 2, 0, 0, 5 };

        // --------- try block ---------

        for (int j = 0; j < number.Length; j++)

            // Here this block raises two different
            // types of exception, i.e. DivideByZeroException
            // and IndexOutOfRangeException
            try
            {

                Console.WriteLine("Number: " + number[j]);
                Console.WriteLine("Divisor: " + divisor[j]);
                Console.WriteLine("Quotient: " + number[j] / divisor[j]);
            }

            // Catch block 1

            // This Catch block is for
            // handling DivideByZeroException
            catch (DivideByZeroException)
            {

                Console.WriteLine("Not possible to Divide by zero");
            }

            // Catch block 2

            // This Catch block is for
            // handling IndexOutOfRangeException
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is Out of Range");
            }
    }
}
public class InsufficientFuncException : System.Exception
{
    private static readonly string DefaultMessage = "Account balance is insufficient for the transaction.";

    public string AccountName { get; set; }
    public int AccountBalance { get; set; }
    public int TransactionAmount { get; set; }

    public InsufficientFuncException() : base(DefaultMessage) { }
    public InsufficientFuncException(string message) : base(message) { }
    public InsufficientFuncException(string message, System.Exception innerException)
    : base(message, innerException) { }

    public InsufficientFuncException(string accountName, int accountBalance, int transactionAmount)
    : base(DefaultMessage)
    {
        AccountName = accountName;
        AccountBalance = accountBalance;
        TransactionAmount = transactionAmount;
    }

    public InsufficientFuncException(string accountName, int accountBalance, int transactionAmount, System.Exception innerException)
    : base(DefaultMessage, innerException)
    {
        AccountName = accountName;
        AccountBalance = accountBalance;
        TransactionAmount = transactionAmount;
    }

    protected InsufficientFuncException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

}
public class MyException : Exception
{
    //Constructors. It is recommended that at least all the
    //constructors of
    //base class Exception are implemented
    public MyException() : base() { }
    public MyException(string message) : base(message) { }
    public MyException(string message, Exception e) : base(message, e) { }
    //If there is extra error information that needs to be captured
    //create properties for them.

    private string strExtraInfo;
    public string ExtraErrorInfo
    {
        get
        {
            return strExtraInfo;
        }

        set
        {
            strExtraInfo = value;
        }
    }

    public class TestMyException
    {
        public static void Main()
        {
            try
            {
                MyException m;
                m = new MyException("My Exception Occured");
                m.ExtraErrorInfo = "My Extra Error Information";
                throw m;
            }

            catch (MyException e)
            {
                Console.WriteLine(String.Concat(e.StackTrace, e.Message));
                Console.WriteLine(e.ExtraErrorInfo);
            }

            Console.ReadLine();
        }
    }
}
//a class called program is defined
class program
{
    // a method called ClassA() is defined
    static void ClassA()
    {
        try
        {
            Console.WriteLine("We are inside class A");
            //An exception is thrown
            throw new Exception("An exception is thrown");
        }
        //finally block is executed regardless of the exception is handled or not
        finally
        {
            Console.WriteLine("This is the finally block of Class A");
        }
    }
    // a method called ClassB() is defined
    static void ClassB()
    {
        try
        {
            Console.WriteLine("We are Inside class B");
            return;
        }
        //finally block is executed regardless of the exception is handled or not
        finally
        {
            Console.WriteLine("This is the finally block of class B");
        }
    }
    // Main Method is called
    public static void Main(String[] args)
    {
        try
        {
            ClassA();
        }
        catch (Exception)
        {
            Console.WriteLine("The exception that is thrown is caught");
        }
        ClassB();
    }
}
public class G
{

    // Main Method
    public static void Main(String[] args)
    {
        int[] ar = { 1, 2, 3, 4, 5 };

        // causing exception
        for (int i = 0; i <= ar.Length; i++)
            Console.WriteLine(ar[i]);
    }
}
