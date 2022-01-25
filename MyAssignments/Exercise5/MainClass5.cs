using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class MainClass5
    {
        public static void MainFun5()
        {

            int imp, ch5, s = 0;
            List<IDuckInterface> myList = new List<IDuckInterface>();
            IDuckInterface ref1 = null;
        label5iv: Console.WriteLine(@"            Press 1 to create a duck");
            Console.WriteLine(@"            Press 2 to show the details of the last duck created");
            Console.WriteLine(@"            Press 3 to show the details of all the ducks created so far");
        label5i: if (int.TryParse(Console.ReadLine(), out ch5))
            {
                switch (ch5)
                {
                    case 1:
                    label5ii: Console.WriteLine(@"                Press 1 to create {0} Duck", (Ducktype)1);
                        Console.WriteLine(@"                Press 2 to create {0} Duck", (Ducktype)2);
                        Console.WriteLine(@"                Press 3 to create {0} Duck", (Ducktype)3);
                        if (int.TryParse(Console.ReadLine(), out imp))
                        {
                            if (imp == 1)
                            {
                                IDuckInterface ob = new DuckClass(imp);
                                myList.Add(ob);
                                ref1 = ob;
                            }
                            else if (imp == 2)
                            {
                                IDuckInterface ob = new DuckClass(imp);
                                myList.Add(ob);
                                ref1 = ob;
                            }
                            else if (imp == 3)
                            {
                                IDuckInterface ob = new DuckClass(imp);
                                myList.Add(ob);
                                ref1 = ob;
                            }
                            else
                            {
                                Console.WriteLine("  Please select the valid options");
                                goto label5ii;
                            }
                        }
                        else
                        {
                            Console.WriteLine(@"                Please enter valid input");
                            goto label5ii;
                        }

                        break;
                    case 2:
                        if (!(ref1 is null))
                        {
                            ref1.ShowDetails();
                        }
                        else
                        {
                            Console.WriteLine(@"                Sorry! no duck has been created!");
                        }
                        break;
                    case 3:
                        if (myList.Count() != 0)
                        {
                            foreach (var item in myList)
                            {
                                item.ShowDetails();
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine(@"                Sorry! no duck has been created");
                        }
                        break;
                    default:
                        Console.WriteLine(@"                Wrong input entered");
                        break;
                }
                Console.Write("\n");
                Console.WriteLine(@"            Do wou want to go back to main menu? If yes then press 1 else any key to exit");
                if (int.TryParse(Console.ReadLine(), out s))
                {
                    if (s == 1)
                    {
                        goto label5iv;
                    }
                }

            }
            else
            {
                Console.WriteLine(@"            Please enter valid input");
                goto label5i;
            }

        }
    }
}
