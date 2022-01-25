using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise12
{
    public class MainClass12
    {
        public static void MainFun12()
        {
            List<int> myList = new List<int>();
            int z1, z2;
            Console.WriteLine("How many numbers do you want to add?");
    label1: if (int.TryParse(Console.ReadLine(), out z1))
            {
                if (z1 > 0)
                {
                    Console.WriteLine("Please enter the {0} numbers ", z1);
                    while (z1 > 0)
                    {
                    label2: if (int.TryParse(Console.ReadLine(), out z2))
                        {
                            if (z2 >= 0)
                            {
                                myList.Add(z2);
                            }
                            else
                            {
                                Console.WriteLine("Please enter positive integers only");
                                goto label2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid integer numbers only");
                            goto label2;
                        }
                        z1--;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter positive numbers only");
                    goto label1;
                }
            }
            else if (z1 < 0)
            {
                Console.WriteLine("Please enter valid  numbers");
                goto label1;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                goto label1;
            }

            Console.Write("\n\n");
            Console.Write("                       " + "List entered : ");
            foreach (int item in myList)
            {

                Console.Write(item);
                Console.Write(" ");
            }
            Console.Write("\n\n");

            //call Main1 func to execute the program
            Lambda_Delegates.Main1(myList);
        }
    }
}
