using System;

namespace ConsoleApp2
{
    class Class7
    {
        // private field (Located near wrapping "Date" property).
        private DateTime _date;

        // Public property exposes _date field safely.
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                // Set some reasonable boundaries for likely birth dates.
                if (value.Year > 1900 && value.Year <= DateTime.Today.Year)
                {
                    _date = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // public field (Generally not recommended).
        public string Day;
        private string hireDay;

        // Public method also exposes _date field safely.
        // Example call: birthday.SetDate("1975, 6, 30");
        public void SetDate(string dateString)
        {
            DateTime dt = Convert.ToDateTime(dateString);

            // Set some reasonable boundaries for likely birth dates.
            if (dt.Year > 1900 && dt.Year <= DateTime.Today.Year)
            {
                _date = dt;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public TimeSpan GetTimeSpan(string dateString)
        {
            DateTime dt = Convert.ToDateTime(dateString);

            if (dt.Ticks < _date.Ticks)
            {
                return _date - dt;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        class multiplication
        {
            int a, b;

            // default Constructor
            public multiplication()
            {
                a = 10;
                b = 5;
            }
        }

        class Point
        {
            protected int x;
            protected int y;
        }

        class DerivedPoint : Point
        {
            static void Main()
            {
                var dpoint = new DerivedPoint();

                // Direct access to protected members.
                dpoint.x = 10;
                dpoint.y = 15;
                Console.WriteLine($"x = {dpoint.x}, y = {dpoint.y}");
            }
        }


        // accessing protected member of itself
        public void foo1()
        {
            Console.WriteLine("" + this.hireDay);  // OK
        }

        // access protected member of instance of same type
        public void Foo2(AppDomainManager manager)
        {
            Console.WriteLine("" + manager);  // OK
        }

        // access protected member of instance of super-class
        public void foo3(Employee employee)
        {
            Console.WriteLine("" + employee.hireDay);  // NOT ALLOWED!
        }

        class Car
        {
            public string model = "Mustang";
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car myObj = new Car();
                Console.WriteLine(myObj.model);
            }
        }
    }
}