using System;
using System.Collections.Generic;

namespace Genericlist_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> myList = new List<string>();
            myList.Add("Samiksha");
            myList.Add("parag");
            myList.Add("Narkhede");


            foreach (string s in myList)
                Console.Write (s.ToString() + " ");

            
            myList.Sort();
            Console.WriteLine("\n After Sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            
            myList.Remove("samiksha");
            Console.WriteLine("\nRemoving samiksha");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

           
            myList.Insert(2, "samu");
            Console.WriteLine("\nInserting samu at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
}
    