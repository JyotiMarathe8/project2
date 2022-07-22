using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace project2.Collections
{
    internal class List1
        {
            static void Main(string[] args)
            {
                //Array growable default size is --4
                //Duplicates are allowed,insertion,index base,

                List<string> l2 = new List<string>() { "A", "B", "C", "D" };

                List<string> lst = new List<string>();
                lst.Add("Om");
                lst.Add("Sham");
                lst.Add("Gana");
                lst.Add("Om");
                lst.Add("Pratyush");
                lst.Add("Om");
                //lst.AddRange(l2);
               // lst.InsertRange(0, l2);

                lst.Remove("Om");
            
             lst.RemoveAt(0);
             foreach (string names in lst)
             Console.WriteLine(names);
             lst.Clear();
             lst.Insert(4, "Golu");

             string[] str = lst.ToArray();
             int idx1 = lst.IndexOf("Ganu");//0
             int idx2 = lst.LastIndexOf("Pratyush");


             Console.WriteLine(lst.Contains("Golu"));//Return type is bool --True
             Console.WriteLine(idx1);
             Console.WriteLine(idx2);

             foreach (string names in lst)
                 Console.WriteLine(names);
             Console.WriteLine(lst.Count);
             Console.WriteLine(lst.Capacity);

             Console.WriteLine("-------------Iterate Using For Loop---------------");
             for (int i = 0; i < lst.Count; i++)
                 Console.WriteLine(lst[i] + " ");


        }
    }


    /////////////////////////////////////////////////////////////
    ///


    class B
    {
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>();
            slist.Add(new Student("jyoti", 10, "be"));
            slist.Add(new Student("shubham", 20, "nursery"));
            slist.Add(new Student("sarvesh", 30, "3rd standard"));
            slist.Add(new Student("Niraj", 40, "9th standard"));
            slist.ForEach(s1 => Console.WriteLine(s1));
        }
    }

    class Student : IComparable<Student>
    {
        string name;
        int percent;
        string qualification;

        public Student(string name, int percent, string qualification)
        {
            this.name = name;
            this.percent = percent;
            this.qualification = qualification;
        }

        public int CompareTo( Student other)
        {
            return this.percent.CompareTo(other.percent);
        }
        public override string ToString()
        {
            return "name"+name+"percent"+percent+"qualification"+qualification;
        }
    }

}

