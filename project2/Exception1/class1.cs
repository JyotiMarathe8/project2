using System;
using System.Collections.Generic;
using System.Text;

namespace project2.Exception1
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
        public InvalidPasswordException()
        {

        }
        public InvalidPasswordException(string msg) : base(msg)
        {

        }
    }
    class studd
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
                    throw new InvalidPasswordException("password length should be greater than 5");
                else
                    this.password = value;
            }
            get { return password; }

        }

        static void Main(string[] args)
        {
            studd s1 = new studd();
            s1.Username = "tiya";
            try
            {
                s1.Password = "abcd";
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
        }
    }

   

    }


