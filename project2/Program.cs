using System;
using System.Collections.Generic;
using System.Text;

namespace Star
{
    //Exception Handling
    class ProrigoTraining
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter two num");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Division=" + (n1 / n2));
                Console.WriteLine("try ends");
            }
            catch (FormatException e)
            {
                Console.WriteLine("In catch 1");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("In Catch 2");
                Console.WriteLine(e.Message);
            }

            catch (SystemException e) //Universal
            {
                Console.WriteLine("In Catch 3");
                Console.WriteLine(e.Message);
            }
        }
    }

    class UsingMethods
    {
        public static void m1(int a, int b)
        {
            Console.WriteLine("M1 starts");
            Console.WriteLine("Division=" + (a / b));
            Console.WriteLine("m1 Ends");
        }
        public static void m2(int x, int y)
        {
            Console.WriteLine("in m2 starts");
            m1(x, y);
            Console.WriteLine("in m2 ends");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            try
            {
                m2(10, 2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");

        }
    }
    //Custom exception

    class InvalidPasswordException : ApplicationException
    {

        public InvalidPasswordException(string msg) : base(msg)
        {
        }

    }
    class Studd
    {
        string username;
        string password;

        public string Username
        {
            set { this.username = value; }
            get { return username; }
        }
        public string Password
        {
            set
            {
                if (value.Length <= 5)
                    throw new InvalidPasswordException("Password Lenth should be greter than 5");
                else
                    this.password = value;
            }
            get { return password; }
        }

        static void Main(string[] args)
        {
            Studd s = new Studd();
            s.username = "tiya";
            try
            {
                s.password = "abcf";
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main Ends");
        }
    }

    class DemoDelegates
    {
        //for static mehtod
        public delegate void mydelegtes(int x);


        //using static method
        public static void square(int a)
        {
            Console.WriteLine("square=" + a * a);
        }

        //using non static method
        public void cube(int x)
        {
            Console.WriteLine("cube=" + (x * x * x));
        }

        public static void doubleup(int a)
        {
            Console.WriteLine("Double=" + 2 * a);
        }


        static void Main(string[] args)
        {
            //call non staic method

            DemoDelegates d1 = new DemoDelegates();
            mydelegtes d2 = DemoDelegates.square;
            d2 = d2 + d1.cube;
            d2 = d2 + DemoDelegates.doubleup;


            //called static method
            /*  mydelegtes d = square;
              d(7);*/
        }

    }

    class Demo2
    {
        public delegate int mydelagte(int x);

        public static int factorial(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            return f;
        }

        static void Main(string[] args)
        {
            mydelagte d = factorial;

            Console.WriteLine(d(5));
        }


    }


}
