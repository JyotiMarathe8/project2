using System;
using System.Collections.Generic;
using System.Text;

namespace project2.Delegate
{
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
                mydelegtes d2 = square;
                d2 = d2 + d1.cube;
                d2 = d2 + DemoDelegates.doubleup;


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


    class demo3
    {
        int count = 0;
        string Result;
        public delegate string mydel(int x);

    public string isprime(int x)
        {
            for(int i = 1; i <= x ; i++)
            {
                if (x % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Result="prime";
            }
            return Result;
       }
      static void Main(string[] args)
        {
            demo3 d = new demo3();
            mydel d3 = d.isprime;
            d3(5);
        }
    }
    //////////////////////////////////////////////////////////
    ///


    public delegate int mydel4(int a, int b);
    internal class LambdaExpression
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            mydel4 dd = (a, b) => (a + b);
            int r = dd(12, 15);
            Console.WriteLine(r);
        }
    }
    //Func Delegate
    class demoff
    {
        static string greet()
        { return "Good Morning"; }

        static int product(int a, int b, int c)
        {
            return (a * b * c);
        }
        static bool iseven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
            //return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            Func<string> d1 = greet;
            Func<int, int, int, int> d2 = product;
            int prod = d2(2, 3, 4);
            Console.WriteLine("Multiplication: " + prod);

            Action<int, int> d3 = (a, b) => Console.WriteLine("Add=" + (a + b));
            d3(3, 5);

            /*Func<int, bool> d4 = iseven;

            bool b = d4(89);*/

            Predicate<int> d5 = iseven;
            bool result = d5(25);
            Console.WriteLine(result);
        }
    }
    //Func --use when function compulsory returns a value back
    //and can take zero or max 16 parameters
    //Action Delegate-if function return type is void and may 0 or more parameters
    //Predicate - if function return compulsory boolean value back and may take 0 or more parameters

    //Call Back Function
    internal class MyCallBack
    {
        static void display()
        {
            Console.WriteLine("Good Morning");
        }
        public static void square(int a, Action d1)
        {
            Console.WriteLine("Square : " + a * a);
            d1();
        }

        static void Main(string[] args)
        {
            square(10, () => Console.WriteLine("Happy Morning"));
        }
    }
    ////////////////////////////////
    ///

    class dem4
    {
        static void display( out int x)
        {
            x =  1;
        }
        static void Main(string[] args)
        {
            int x = 0;
            display(out x);
            Console.WriteLine(x);
        }
        //static void display(ref int x)
        //{
        //    x = 1;
        //}
        //static void Main(string[] args)
        //{
        //    int x = 0;
        //    display(ref x);
        //    Console.WriteLine(x);
        //}
    }


}


