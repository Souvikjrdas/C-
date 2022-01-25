using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise3
{
    public class MainClass3
    {
        public static void MainFunc3()
        {
            int a, b;
            Console.WriteLine("                 Enter two numbers such the First number is smaller than the Second number");
        label1: if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
            {
                if (a < 0 || b < 0)
                {
                    Console.WriteLine("                 Please enter positive numbers");
                    goto label1;
                }
                else if (a > b)
                {
                    Console.WriteLine("                 Please enter two numbers such the First number is smaller than the Second number");
                    goto label1;
                }
                else
                {
                    var ob = new Prime1();
                    Console.WriteLine("                 The prime numbers between {0} and {1} are as follows:",a,b);
                    Console.Write("\n");
                    ob.PrimeNo(a, b);
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("                 Please enter valid numbers:");
                goto label1;
            }
        }
    }
}
