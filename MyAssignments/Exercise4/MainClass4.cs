using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise4
{
    public class MainClass4
    {
        public static void MainFun4()
        {
            int ch4, s4;
            List<Mobile> mbList = new List<Mobile>();
            List<Immobile> ibList = new List<Immobile>();
            Mobile mb = null;
            Immobile ib = null;
        label4vi: Console.WriteLine("             Press 1 to create an equipment");
            Console.WriteLine("             Press 2 to move an equipment");
            Console.WriteLine("             Press 3 to show the details of all equipments");
        label4i: if (int.TryParse(Console.ReadLine(), out ch4))
            {
                int imp4;
                switch (ch4)
                {
                    case 1:
                        Console.WriteLine("                 Enter 1 to create a Mobile equipment");
                        Console.WriteLine("                 Enter 2 to create a Immobile equipment");
                        Console.Write("\n");
                    label4ii: if (int.TryParse(Console.ReadLine(), out imp4))
                        {
                            if (imp4 == 1)
                            {
                                mb = new Mobile();
                                mbList.Add(mb);
                            }
                            else if (imp4 == 2)
                            {
                                ib = new Immobile();
                                ibList.Add(ib);
                            }
                            else
                            {
                                Console.WriteLine("                 Please enter valid options ");
                                goto label4ii;
                            }
                        }
                        else
                        {
                            Console.WriteLine("                 Please enter valid input :");
                            goto label4ii;
                        }

                        break;
                    case 2:
                        Console.WriteLine("                 Enter 1 to move a mobile equipment");
                        Console.WriteLine("                 Enter 2 to move an immobile equipment");
                    label4iii: if (int.TryParse(Console.ReadLine(), out imp4))
                        {
                            if (imp4 == 1)
                            {
                                if (mb is null)
                                {
                                    Console.WriteLine("                     No Mobile equipment found");
                                }
                                else
                                {
                                    double d;
                                label4iv: Console.WriteLine("                       Enter valid distance to be moved");
                                    try
                                    {
                                        d = Convert.ToDouble(Console.ReadLine());
                                        if (d < 0)
                                        {
                                            goto label4iv;
                                        }
                                        mb.MoveBy(d);
                                        Console.WriteLine("                       Equipment moved by {0} km successfully", d);
                                    }
                                    catch (Exception)
                                    {
                                        goto label4iv;
                                    }
                                }
                            }
                            else if (imp4 == 2)
                            {
                                if (ib is null)
                                {
                                    Console.WriteLine("                     No Immmobile equipment found");
                                }
                                else
                                {
                                    double d;
                                label4v: Console.WriteLine("                        Enter valid distance to be moved");
                                    try
                                    {
                                        d = Convert.ToDouble(Console.ReadLine());
                                        if (d < 0)
                                        {
                                            goto label4v;
                                        }
                                        ib.MoveBy(d);
                                        Console.WriteLine("                       Equipment moved by {0} km successfully", d);
                                    }
                                    catch (Exception)
                                    {
                                        goto label4v;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("                     Please select valid option");
                                goto label4iii;
                            }
                        }
                        else
                        {
                            Console.WriteLine("                     Please enter valid input ");
                            goto label4iii;
                        }
                        break;
                    case 3:
                        Console.WriteLine("                 Details of Mobile Equipments :");
                        Console.Write("\n");
                        foreach (var item in mbList)
                        {
                            item.ShowDetailsOfMobile();
                            Console.Write("\n");
                        }
                        Console.Write("\n\n");
                        Console.WriteLine("                 Details of Immobile Equipments :");
                        Console.Write("\n");
                        foreach (var item in ibList)
                        {
                            item.ShowDetailsOfImmobile();
                            Console.Write("\n");
                        }
                        Console.Write("\n");
                        break;
                    default:
                        Console.WriteLine("                 Wrong input entered !");
                        break;
                }
                Console.WriteLine("             Do you want to return to main menu ? Then press 1 else any key to exit");
                if (int.TryParse(Console.ReadLine(), out s4))
                {
                    goto label4vi;
                }
            }
            else
            {
                Console.WriteLine("             Please enter valid input");
                goto label4i;
            }
        }
    }
}
