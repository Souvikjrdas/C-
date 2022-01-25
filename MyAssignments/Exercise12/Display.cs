using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Display
    {
        public static void Show(string info, IEnumerable<int> list)
        {
            Console.Write("                       " + info + " : ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
