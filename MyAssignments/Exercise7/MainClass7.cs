using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise7
{
    public class MainClass7
    {
        public static void MainFun7()
        {

            int imp7, ch7 ,s7;
            List<DuckClassExtended> myList1 = new List<DuckClassExtended>();
            IDuckInterfaceExtended ref2 = null;
  label7iv: Console.WriteLine(@"            Press 1 to create a duck");
            Console.WriteLine(@"            Press 2 to show the details of the last duck created");
            Console.WriteLine(@"            Press 3 to show the details of all the ducks created so far");
            Console.WriteLine(@"            Press 4 to remove a duck");
            Console.WriteLine(@"            Press 5 to remove all ducks");
            Console.WriteLine(@"            Press 6 to show details of the ducks in the increasing order of the weights");
            Console.WriteLine(@"            Press 7 to show details of the ducks in the increasing order of the wings");
   label7i: if (int.TryParse(Console.ReadLine(), out ch7))
            {
                switch (ch7)
                {
                    case 1:
              label7ii: Console.WriteLine(@"                Press 1 to create {0} Duck", (Ducktype1)1);
                        Console.WriteLine(@"                Press 2 to create {0} Duck", (Ducktype1)2);
                        Console.WriteLine(@"                Press 3 to create {0} Duck", (Ducktype1)3);
                        if (int.TryParse(Console.ReadLine(), out imp7))
                        {
                            if (imp7 == 1)
                            {
                                DuckClassExtended ob = new DuckClassExtended(imp7);
                                myList1.Add(ob);
                                ref2 = ob;
                            }
                            else if (imp7 == 2)
                            {
                                DuckClassExtended ob = new DuckClassExtended(imp7);
                                myList1.Add(ob);
                                ref2 = ob;
                            }
                            else if (imp7 == 3)
                            {
                                DuckClassExtended ob = new DuckClassExtended(imp7);
                                myList1.Add(ob);
                                ref2 = ob;
                            }
                            else
                            {
                                Console.WriteLine(@"                Please select the valid options");
                                goto label7ii;
                            }
                        }
                        else
                        {
                            Console.WriteLine(@"                Please enter valid input");
                            goto label7ii;
                        }
                        break;

                    case 2:
                        if (!(ref2 is null))
                        {
                            ref2.ShowDetails();
                        }
                        else
                        {
                            Console.WriteLine(@"                Sorry! currently there are no ducks in the collection");
                        }
                        break;

                    case 3:
                        if (myList1.Count() != 0)
                        {
                            foreach (var item in myList1)
                            {
                                item.ShowDetails();
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine(@"                Sorry! currently there are no ducks in the collection");
                        }
                        break;

                    case 4:
                        if (myList1.Count() == 0)
                        {
                            Console.WriteLine(@"                Sorry! currently there are no ducks in the collection");
                        }
                        else
                        {
                            int p = myList1.Count();
                            myList1.RemoveAt(p - 1);
                            if (myList1.Count() != 0)
                            {
                                ref2 = myList1[myList1.Count() - 1];

                            }
                            else
                            {
                                ref2 = null;
                            }
                            Console.WriteLine(@"                Duck has been sucessfully removed!");
                        }
                        break;

                    case 5:
                        if (myList1.Count() == 0)
                        {
                            Console.WriteLine(@"                Sorry! currently there are no ducks in the collection");
                        }
                        else
                        {
                            myList1.RemoveAll(item => item.wings > 0);
                            ref2 = null;
                            Console.WriteLine(@"                Duck has been sucessfully removed!");
                        }
                        break;

                    case 6:


                        if (ref2 is null)
                        {
                            Console.WriteLine(@"                Sorry! currently there are no ducks in the collection");
                        }
                        else
                        {
                            var newList = myList1.OrderBy(item => item.weight);
                            foreach (var item in newList)
                            {
                                item.ShowDetails();
                                Console.Write("\n");
                            }
                        }
                        break;

                    case 7:

                        if (ref2 is null)
                        {
                            Console.WriteLine(@"                Sorry! currently there are no ducks in the collection");
                        }
                        else
                        {
                            var newList = myList1.OrderBy(item => item.wings);
                            foreach (var item in newList)
                            {
                                item.ShowDetails();
                                Console.Write("\n");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine(@"                Wrong input entered");
                        break;
                }
                Console.Write("\n");
                Console.WriteLine(@"            Do you want to go back to main menu? If yes then press 1 else any key to exit");
                if (int.TryParse(Console.ReadLine(), out s7))
                {
                    if (s7 == 1)
                    {
                        goto label7iv;
                    }
                }
            }
            else
            {
                Console.WriteLine(@"            Please enter valid input");
                goto label7i;
            }

        }
    }
}
