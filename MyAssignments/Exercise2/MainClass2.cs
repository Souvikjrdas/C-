using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise2
{
    public class MainClass2
    {
        public static void Mainfunc2()
        {
            string name = "Souvik";
            string myname = "Das";
            string name1 = "Virat";
            string name2 = name;

            object o = 90;
            object m = o;
            object l = null;

            // == operator actually compares the reference identity.
            Console.Write("             Checking for == operator : Result  for object o and m is :");
            Console.WriteLine(o == m);                                                    //True
            Console.Write("             Checking for == operator : Result  for object o and l is :");
            Console.WriteLine(o == l);                                                    //False

            Console.Write("\n");

            //Equals() method compares the contents of an object 
            Console.Write("             Checking for Equals method : Result  for name and name1 is :");  
            Console.WriteLine(name.Equals(name1));                                              //False
            Console.Write("             Checking for Equals method : Result  for name and name2 is :");
            Console.WriteLine(name.Equals(name2));                                              //True

            Console.Write("\n");

            //Object.ReferenceEquals() checks whether the specified Object instances are the same instance or not.
            Console.Write("             checking for Object.ReferenceEquals() : Result for object o and object m :");
            Console.WriteLine(Object.ReferenceEquals(o,m));                                                     //True
            Console.Write("             checking for Object.ReferenceEquals() : Result for object o and object l :");
            Console.WriteLine(Object.ReferenceEquals(o, l));                                                    //False
            Console.WriteLine("\n");
        }
    }
}
