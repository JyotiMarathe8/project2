using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace project2.Collections.collections_Assignment
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int> { 5, 2, 8, 9, 4 };
            L1.Add(10);
            foreach (int numb in L1)
                Console.WriteLine(numb);
            Console.WriteLine("---------------------------------------------------------------------");

            List<string> L2 = new List<String> { "Jyoti", "Sarvesh", "Monika", "deepak" };
            L2.Add("Niraj");
            foreach (String names in L2)
                Console.WriteLine(names);
        }
    }


    class Class2
    {
        static void Main(string[] args)
        {
            List<Employee> E3 = new List<Employee>();
            E3.Add(new Employee(101, "jyoti"));
            E3.Add(new Employee(102, "Ashwini"));
            E3.Add(new Employee(103, "Anita"));
            E3.Add(new Employee(104, "Pooja"));
            E3.Add(new Employee(105, "Vaishali"));
            E3.ForEach(data => Console.WriteLine(data));

        }
    }
    class Employee
    {
        int Empid;
        string Enmae;

        public Employee(int empid, string enmae)
        {
            Empid = empid;
            Enmae = enmae;
        }

        public override string ToString()
        {
            return Empid + " " + Enmae;
        }
    }


    class Class3
    {
        static void Main(string[] args)
        {
            List<string> L2 = new List<String> { "red", "green", "yello", "white" };
            L2.Add("purple");
            foreach (String colours in L2)
                Console.WriteLine(colours);


        }
    }


    class Class4
    {
        static void Main(string[] args)
        {
            List<string> L1 = new List<string>();
            L1.Add("Jyoti");
            L1.Add("Ashwini");
            string temp = L1[0];
            L1[0] = L1[1];
            L1[1] = temp;
            Console.WriteLine(L1[0]);
            Console.WriteLine(L1[1]);

        }
    }



    class Class5
    {
        static void Main(string[] args)
        {
            List<string> l2 = new List<string>() { "Jyoti", "Ashwini" };
            l2.Insert(1, "deepak");
            foreach (String values in l2)
                Console.WriteLine(values); ;

        }
    }


    class Class6
    {

        static void Main(string[] args)
        {
            List<Student> L1 = new List<Student>();
            L1.Add(new Student("jyoti", 101, 85));
            L1.Add(new Student("Sarvesh", 102, 86));
            L1.Add(new Student("niraj", 103, 87));
            L1.Add(new Student("Dinesh", 104, 88));
            foreach (Student details in L1)
                Console.WriteLine(details);
        }
    }
    class Student
    {
        String name;
        int id;
        int pecentage;

        public Student(string name, int id, int pecentage)
        {
            this.name = name;
            this.id = id;
            this.pecentage = pecentage;
        }
        public override string ToString()
        {
            return "Name= " + name + " Id= " + id + " percentage= " + pecentage;
        }



    }

    class Class7
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 9, 7, 5, 6, 4 };
            List<int[]> L1 = new List<int[]>();
            L1.Add(arr);

            foreach (int[] values1 in L1)
                foreach (int values2 in values1)
                    Console.WriteLine(values2);




        }
    }

    class Class8
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int> { 5, 6, 8, 9, 4, 2, 1 };
            Console.Write("Original Values -");
            foreach (int values in L1)
                Console.Write(values);
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.Write("Reverse Values-");
            for (int i = L1.Count - 1; i >= 0; i--)
            {
                Console.Write(L1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("******************************");

        }
    }

      public  class Class9
        {
            static void Main(string[] args)
            {
                
            employee1 a=new employee1("Pooja");
            employee1 b = new employee1("Jyoti");
            employee1 c = new employee1("Ananya");
            List<employee1> E3 = new List<employee1> { a, b, c };
            List<employee1> sorted = E3.OrderBy(x=>x.ename1).ToList();
            Console.WriteLine(string.Join(",",sorted));
            }

        }
   public class employee1
    {
       public string ename1;

        public employee1(string ename1)
        {
            this.ename1 = ename1;
        }
        public override string ToString()
        {
            return ename1;
        }
    }




    public class Class10
    {
        static void Main(string[] args)
        {

            employee2 a = new employee2("Pooja","associate",35);
            employee2 b = new employee2("Jyoti","Sr.Associate",40);
            employee2 c = new employee2("Ananya","Software Engineer",38);
            List<employee2> E3 = new List<employee2> { a, b, c };
            List<employee2> sorted = E3.OrderBy(x => x.age).ToList();
            for (int i = sorted.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(sorted[i]);
            }
        }

    }
    public class employee2
    {
        public string ename2;
        public int age;
        string designation;

        public employee2(string ename2, string designation, int age)
        {
            this.ename2 = ename2;
            this.designation = designation;
            this.age = age;
        }
        public override string ToString()
        {
            return "Name "+ename2+" Designation "+designation+" Age "+age;
        }
    }



    class Class11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(100, "jyoti");
            d1.Add(101, "Ashu");
            d1.Add(102, "Monu");
            d1.Add(103, "Choti");
            foreach (KeyValuePair<int, string> val in d1)
            
                Console.WriteLine("{0} and {1}", val.Key, val.Value);

            Console.WriteLine("*********************************************");

            Dictionary< string,int> d2 = new Dictionary< string,int>();
            d2.Add( "jyoti",89);
            d2.Add( "Ashu",94);
            d2.Add( "Monu",78);
            d2.Add( "Choti",86);
            foreach (KeyValuePair< string,int> val in d2)

                Console.WriteLine("{0} and {1}", val.Key, val.Value);

        }
    }




    class Class12
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(100, "jyoti");
            d1.Add(101, "Ashu");
            d1.Add(102, "Monu");
            d1.Add(103, "Choti");
            foreach (KeyValuePair<int, string> val in d1)

                Console.WriteLine("{0} ", val.Key);

        }
    }



    class Class13
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(100, "jyoti");
            d1.Add(101, "Ashu");
            d1.Add(102, "Monu");
            d1.Add(103, "Choti");
            foreach (KeyValuePair<int, string> val in d1)

                Console.WriteLine("{0} ", val.Value);

        }
    }




    class Class14
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student1> d2 = new Dictionary<int, Student1>();
            d2.Add (101,(new Student1("jyoti")) );
            d2.Add(102, (new Student1("Monika")));
            d2.Add(103, (new Student1("Dinesh")));
            foreach(KeyValuePair<int,Student1> elements in d2)
                Console.WriteLine("{0} and {1}", elements.Key , elements.Value);
        }
    }

class Student1
    {
        string name;

        public Student1(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }


    class Class15
    {

        static void Main(string[] args)
        {
            Queue<student2> myqueue = new Queue<student2>();
            myqueue.Enqueue(new student2("jyoti", 101));
            myqueue.Enqueue(new student2("Monika", 102));
            myqueue.Enqueue(new student2("Ashwini", 103));
            myqueue.Enqueue(new student2("Kirti", 104));
            myqueue.Enqueue(new student2("choti", 105));
            foreach(student2 elements in myqueue)
                Console.WriteLine(elements);

        }
    }
    class student2
    {
        string name;
        int id;

        public student2(string name, int id)
        {
            this.name = name;
            this.id = id;
        }


        public override string ToString()
        {
            return "name -"+name+", ID - "+id;
        }
    }




    class Class16
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(101);
            s1.Push(102);
            s1.Push(103);

            foreach(int elements in s1)
                Console.WriteLine(elements);
            Console.WriteLine("********************** ");
            s1.Pop();
            foreach (int elements in s1)
                Console.WriteLine(elements);
            Console.WriteLine("*******************");
            s1.Peek();
            foreach (int elements in s1)
                Console.WriteLine(elements);



        }
    }



}





























