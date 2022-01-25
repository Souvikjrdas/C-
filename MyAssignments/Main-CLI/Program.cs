using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1;
using Exercise2;
using Exercise3;
using Exercise4;
using Exercise5;
using Exercise6;
using Exercise7;
using Exercise11;
using Exercise12;
using Exercise13;
using Exercise14;
using Exercise16;
using Exercise17;
namespace Main_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            int zo;
            Console.WriteLine("\n");
 label1:    Console.WriteLine("                             Press 1 for Exercise 1");
            Console.WriteLine("                             Press 2 for Exercise 2");
            Console.WriteLine("                             Press 3 for Exercise 3");
            Console.WriteLine("                             Press 4 for Exercise 4");
            Console.WriteLine("                             Press 5 for Exercise 5");
            Console.WriteLine("                             Press 6 for Exercise 6");
            Console.WriteLine("                             Press 7 for Exercise 7");
            Console.WriteLine("                             Press 8 for Exercise 8");
            Console.WriteLine("                             Press 9 for Exercise 9");
            Console.WriteLine("                             Press 10 for Exercise 10");
            Console.WriteLine("                             Press 11 for Exercise 11");
            Console.WriteLine("                             Press 12 for Exercise 12");
            Console.WriteLine("                             Press 13 for Exercise 13");
            Console.WriteLine("                             Press 14 for Exercise 14");
            Console.WriteLine("                             Press 15 for Exercise 15");
            Console.WriteLine("                             Press 16 for Exercise 16");
            Console.WriteLine("                             Press 17 for Exercise 17");
 label2:    if(int.TryParse(Console.ReadLine() , out zo))
            {
                switch (zo)
                {
                    case 1:
                        MainClass1.MainFunc1();
                        break;

                    case 2:
                        MainClass2.Mainfunc2();
                        break;

                    case 3:

                        MainClass3.MainFunc3();
                        break;

                    case 4:
                        MainClass4.MainFun4();
                        break;

                    case 5:
                        MainClass5.MainFun5();
                        break;

                    case 6:
                        MainClass6.MainFun6();
                        break;

                    case 7:
                        MainClass7.MainFun7();
                        break;

                    case 8:
                        Console.WriteLine("                 I was unable to solve this Exercise");
                        Console.Write("\n");
                        break;

                    case 9:
                        Console.WriteLine("                 I was unable to solve this Exercise");
                        Console.Write("\n");
                        break;

                    case 10:
                        Console.WriteLine("                 I was unable to solve this Exercise");
                        Console.Write("\n");
                        break;

                    case 11:
                        MainClass11.MainFun11();
                        break;

                    case 12:
                        MainClass12.MainFun12();
                        break;

                    case 13:

                        MainClass13.MainFunc13();
                        break;

                    case 14:

                        MainClass14.MainFunc14();
                        break;

                    case 15:
                        Console.WriteLine("                 I was unable to solve this Exercise");
                        break;

                    case 16:

                        MainClass16.MainFunc16();
                        break;

                    case 17:

                        MainClass17.MainFunc17();
                        break;

                    default:
                        Console.WriteLine("                 Wrong choice entered !");
                        break;
                }
                Console.WriteLine("                 If you want to continue viewing the Exercises then press Y ; Else press any key to exit");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("                 Press any key from 1-17 for the respective exercises");
                    Console.Write("\n");
                    goto label2;
                }
            }
            else
            {
                Console.WriteLine("                 Invalid input entered! Do you want to return to main menu ? then press y else any key to exit");
                if(Console.ReadLine().ToLower() == "y")
                {
                    goto label1;
                }
            }
            
        }
    }
}
