using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise1
{
    public class MainClass1
    {
        public static void MainFunc1()
        {
            int ch1i;

   label1a: Console.WriteLine("                 Enter 1 for integer conversion");
            Console.WriteLine("                 Enter 2 for float conversion");
            Console.WriteLine("                 Enter 3 for boolean conversion");
            Console.WriteLine("                 Enter 0 to exit");
            if (int.TryParse(Console.ReadLine(), out ch1i))
            {
                int n2 = 0;
                float n3;
                bool n4;
                switch (ch1i)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("                     Enter a number to convert it to integer");
                            Console.Write("\n");
                            var n1 = Console.ReadLine();
                            int.Parse(n1);
                            Console.WriteLine("                     Intger conversion by int.Parse() was sucessful");
                            Convert.ToInt32(n1);
                            Console.WriteLine("                     Integer conversion by Convert.ToInt() was successful");
                            if (int.TryParse(n1, out n2))
                            {
                                Console.WriteLine("                     Integer conversion by int.TryParse() was successful");
                            }
                            else
                            {
                                Console.WriteLine("                     Integer conversion by int.TryParse() was not successful");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("                     Integer conversion was not successful by int.Parse()");
                            Console.WriteLine("                     Integer conversion was not successful by Convert.ToInt()");
                            Console.WriteLine("                     Integer conversion was not successful by int.TryParse()");
                        }

                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("                     Enter a number to convert it to float");
                            Console.Write("\n");
                            var n1 = Console.ReadLine();
                            float.Parse(n1);
                            Console.WriteLine("                     Float conversion was successful by float.Parse() method");
                            if (float.TryParse(n1, out n3))
                            {
                                Console.WriteLine("                     Float conversion by float.TryParse() was successful");
                            }
                            else
                            {
                                Console.WriteLine("                     Float conversion by float.TryParse() was not successful");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("                     Float conversion by float.Parse() was not successful");
                            Console.WriteLine("                     Float conversion by float.TryParse() was not successful");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("                     Enter an input to convert it into boolean");
                            Console.Write("\n");
                            var n1 = Console.ReadLine();
                            bool.Parse(n1);
                            Console.WriteLine("                     Boolean conversion by bool.Parse() was successful");
                            Convert.ToBoolean(n1);
                            Console.WriteLine("                     Boolean conversion by Convert.ToBoolean() was successful");
                            if (bool.TryParse(n1, out n4))
                            {
                                Console.WriteLine("                     Boolean conversion by bool.TryParse() was successful");
                            }
                            else
                            {
                                Console.WriteLine("                     Boolean conversion by bool.TryParse() was not successful");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("                     Boolean conversion by bool.Parse() was not successful");
                            Console.WriteLine("                     Boolean conversion by Convert.ToBoolean() was not successful");
                            Console.WriteLine("                     Boolean conversion by bool.TryParse() was not successful");
                        }

                        break;

                    case 0:

                        break;

                    default:
                        Console.WriteLine("                     Wrong choice !");
                        break;
                }
            }
            else
            {
                Console.WriteLine("                     Invalid input entered");
                goto label1a;
            }
            Console.Write("\n");
            Console.WriteLine("                 Do you want to continue? If yes then press y else any key to exit");
            if (Console.ReadLine().ToLower() == "y")
            {
                goto label1a;
            }
        }
    }
}
