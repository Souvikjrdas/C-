using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise13
{
    public class MainClass13
    {
        public static void MainFunc13()
        {

            int n13;
            Console.WriteLine("             Please enter the total numbers you want to add.");
  label13i: if (!(int.TryParse(Console.ReadLine(), out n13) && n13 >= 0))
            {
                Console.WriteLine("             Please enter a valid input :");
                goto label13i;
            }
            var array = new int[n13];
            Console.WriteLine("             Enter the necessary numbers:");
            int i13;
            for (int i = 0; i < n13; i++)
            {
   label13ii: if (int.TryParse(Console.ReadLine(), out i13))
                {
                    array[i] = i13;
                }
                else
                {
                    Console.WriteLine("             Enter valid numbers only");
                    goto label13ii;
                }
            }
            Console.Write("         CustomAll");
            Console.Write("      To check if all elements are greater than 1 or not         ");
            Console.WriteLine(array.CustomAll(x => x > 1)); //To check if all elements are greater than 1 or not.
            Console.Write("         CustomAny");
            Console.Write("      To check if any element is lesser than 0 or not            ");
            Console.WriteLine(array.CustomAny(x => x < 0)); //To check if any element is smaller than zero or not.
            Console.Write("         CustomMax");
            Console.Write("      To find the maximum element in the collection              ");
            Console.WriteLine(array.CustomMax(x => x)); //To print the maximum element in the list.
            Console.Write("         CustomMin");
            Console.Write("      To find the minimum element in the collection              ");
            Console.WriteLine(array.CustomMin(x => x)); //To print the minimum element in the list.
            Console.Write("         CustomWhere");
            Console.Write("    Elements in the collection which are greater than 3        ");
            Console.WriteLine(string.Join(", ", array.CustomWhere(x => x > 3))); //To return those specific inputs which are greater than 3.
            Console.Write("         CustomSelect");
            Console.Write("   To add 1 with every element in the collection              ");
            Console.WriteLine(string.Join(", ", array.CustomSelect(x => x + 1))); //To add 1 with the inputs and print them.

        }
    }
}
