using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise6
{
    public class MainClass6
    {
        public static void MainFun6()
        {
            int ch6, s6;
            List<MobileExtend> mbListExtend = new List<MobileExtend>();
            List<ImmobileExtend> ibListExtend = new List<ImmobileExtend>();
            MobileExtend mbExtend = null;
            ImmobileExtend ibExtend = null;
  label6vi: Console.WriteLine("             Press 1 to create an equipment");
            Console.WriteLine("             Press 2 to delete an equipment");
            Console.WriteLine("             Press 3 to move an equipment");
            Console.WriteLine("             Press 4 to list all the equipments with name and description");
            Console.WriteLine("             Press 5 to show the details of all equipments");
            Console.WriteLine("             Press 6 to list all Mobile equipment ");
            Console.WriteLine("             Press 7 to list all Immobile equipment");
            Console.WriteLine("             Press 8 to list all equipment that have not been moved till now");
            Console.WriteLine("             Press 9 to delete all equipment");
            Console.WriteLine("             Press 10 to delete all Immobile equipment");
            Console.WriteLine("             Press 11 to delete all Mobile equipment");
        label6i: if (int.TryParse(Console.ReadLine(), out ch6))
            {
                int imp6, p6;
                switch (ch6)
                {
                    case 1:
                        Console.WriteLine("                 Enter 1 to create a Mobile equipment");
                        Console.WriteLine("                 Enter 2 to create a Immobile equipment");
                    label6ii: if (int.TryParse(Console.ReadLine(), out imp6))
                        {
                            if (imp6 == 1)
                            {
                                mbExtend = new MobileExtend();
                                mbListExtend.Add(mbExtend);
                            }
                            else if (imp6 == 2)
                            {
                                ibExtend = new ImmobileExtend();
                                ibListExtend.Add(ibExtend);
                            }
                            else
                            {
                                Console.WriteLine("                 Please enter valid options ");
                                goto label6ii;
                            }
                        }
                        else
                        {
                            Console.WriteLine("                 Please enter valid input :");
                            goto label6ii;
                        }

                        break;
                    case 2:
                    label6vii: Console.WriteLine("                 Enter 1 to delete a Mobile Equipment");
                        Console.WriteLine("                 Enter 2 to delete a Immobile Equipment");
                        if (int.TryParse(Console.ReadLine(), out p6))
                        {
                            if (p6 == 1)
                            {
                                if (mbListExtend.Count() != 0)
                                {
                                    mbListExtend.RemoveAt(mbListExtend.Count() - 1);
                                    Console.WriteLine("                 Equipment deleted successfully");
                                    if (mbListExtend.Count() != 0)
                                    {
                                        mbExtend = mbListExtend[mbListExtend.Count() - 1];
                                    }
                                    else
                                    {
                                        mbExtend = null;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("                 Sorry! currently no  Mobile equipment is available");
                                }
                            }
                            else if (p6 == 2)
                            {
                                if (ibListExtend.Count() != 0)
                                {
                                    ibListExtend.RemoveAt(ibListExtend.Count() - 1);
                                    Console.WriteLine("                 Equipment deleted successfully");
                                    if (ibListExtend.Count() != 0)
                                    {
                                        ibExtend = ibListExtend[ibListExtend.Count() - 1];
                                    }
                                    else
                                    {
                                        ibExtend = null;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("                 Sorry! currently no Immobile equipment is available");
                                }
                            }
                            else
                            {
                                Console.WriteLine("                 Enter valid options");
                                goto label6vii;
                            }
                        }
                        else
                        {
                            Console.WriteLine("                 Enter valid options");
                            goto label6vii;
                        }
                        break;

                    case 3:
                        Console.WriteLine("                 Enter 1 to move a mobile equipment");
                        Console.WriteLine("                 Enter 2 to move an immobile equipment");
                    label6iii: if (int.TryParse(Console.ReadLine(), out imp6))
                        {
                            if (imp6 == 1)
                            {
                                if (mbExtend is null)
                                {
                                    Console.WriteLine("                 No Mobile equipment found");
                                }
                                else
                                {
                                    double d6;
                                label6iv: Console.WriteLine("                 Enter valid distance to be moved");
                                    try
                                    {
                                        d6 = Convert.ToDouble(Console.ReadLine());
                                        if (d6 < 0)
                                        {
                                            goto label6iv;
                                        }
                                        mbExtend.MoveByExtend(d6);
                                        Console.WriteLine("                 Equipment moved by {0} km succesfully", d6);
                                    }
                                    catch (Exception)
                                    {
                                        goto label6iv;
                                    }
                                }
                            }
                            else if (imp6 == 2)
                            {
                                if (ibExtend is null)
                                {
                                    Console.WriteLine("                 No Immmobile equipment found");
                                }
                                else
                                {
                                    double d6;
                                label6v: Console.WriteLine("                 Enter valid distance to be moved");
                                    try
                                    {
                                        d6 = Convert.ToDouble(Console.ReadLine());
                                        if (d6 < 0)
                                        {
                                            goto label6v;
                                        }
                                        ibExtend.MoveByExtend(d6);
                                    }
                                    catch (Exception)
                                    {
                                        goto label6v;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("                 Please select valid option");
                                goto label6iii;
                            }
                        }
                        else
                        {
                            Console.WriteLine("                 Please enter valid input ");
                            goto label6iii;
                        }
                        break;

                    case 4:
                        Console.WriteLine("                 Details of Mobile Equipment with name and description:");
                        Console.Write("\n");
                        foreach (var item in mbListExtend)
                        {
                            Console.Write("                 " + item.name);
                            Console.Write("         ");
                            Console.Write(item.description);
                            Console.Write("\n");
                        }
                        Console.Write("\n");
                        Console.WriteLine("                 Details of Immobile Equipment with name and description: ");
                        Console.Write("\n");
                        foreach (var item in ibListExtend)
                        {
                            Console.Write("                 " + item.name);
                            Console.Write("         ");
                            Console.Write(item.description);
                            Console.Write("\n");
                        }
                        Console.Write("\n");
                        break;
                    case 5:
                        Console.WriteLine("                 Details of Mobile Equipments :");
                        Console.Write("\n");
                        foreach (var item in mbListExtend)
                        {
                            item.ShowDetailsOfMobileExtend();
                            Console.Write("\n");
                        }
                        Console.Write("\n\n");
                        Console.WriteLine("                 Details of Immobile Equipments :");
                        Console.Write("\n");
                        foreach (var item in ibListExtend)
                        {
                            item.ShowDetailsOfImmobileExtend();
                            Console.Write("\n");
                        }
                        Console.Write("\n");
                        break;

                    case 6:
                        if (mbListExtend.Count() != 0)
                        {
                            Console.WriteLine("                 List of all Mobile Equipments :");
                            Console.Write("\n");
                            var newList = mbListExtend.Where(item => item.type == (EquipTypeExtend)1);
                            foreach (var item in newList)
                            {
                                item.ShowDetailsOfMobileExtend();
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("                 Sorry! currently there are no Mobile equipments");
                        }

                        break;
                    case 7:
                        if (ibListExtend.Count() != 0)
                        {
                            Console.WriteLine("                 List of all Immobile Equipments :");
                            Console.Write("\n");
                            var newList = ibListExtend.Where(item => item.type == (EquipTypeExtend)2);
                            foreach (var item in newList)
                            {
                                item.ShowDetailsOfImmobileExtend();
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("                 Sorry! currently there are no Immobile equipments");
                        }
                        break;
                    case 8:
                        if (mbListExtend.Where(item => item.dismovtilldate == 0).ToList().Count() > 0)
                        {
                            var method = mbListExtend.Where(item => item.dismovtilldate == 0);
                            foreach (var item in method)
                            {
                                item.ShowDetailsOfMobileExtend();
                                Console.Write("\n");
                            }
                            Console.Write("\n");
                        }
                        if (ibListExtend.Where(item => item.dismovtilldate == 0).ToList().Count() > 0)
                        {
                            var method = ibListExtend.Where(item => item.dismovtilldate == 0);
                            foreach (var item in method)
                            {
                                item.ShowDetailsOfImmobileExtend();
                                Console.Write("\n");
                            }
                        }
                        break;
                    case 9:

                        if (mbListExtend.Count() == 0 && ibListExtend.Count == 0)
                        {
                            Console.WriteLine("                 No equipments are there to delete");
                            break;
                        }
                        Console.WriteLine("                 Equipments are deleted successfully!");
                        if (mbListExtend.Count() != 0)
                        {
                            mbListExtend.RemoveAll(item => item.wheels > 0);
                            mbExtend = null;
                        }
                        if (ibListExtend.Count() != 0)
                        {
                            ibListExtend.RemoveAll(item => item.weight > 0);
                            ibExtend = null;
                        }
                        break;
                    case 10:
                        if (ibListExtend.Count() != 0)
                        {
                            ibListExtend.RemoveAll(item => item.weight > 0);
                            ibExtend = null;
                            Console.WriteLine("                 All Immobile equipments are deleted succesfully");
                        }
                        else
                        {
                            Console.WriteLine("                 Sorry! no Immobile equipment is currently there ");
                        }
                        break;

                    case 11:
                        if (mbListExtend.Count() != 0)
                        {
                            mbListExtend.RemoveAll(item => item.wheels > 0);
                            mbExtend = null;
                            Console.WriteLine("                 All Mobile equipments are deleted succesfully");
                        }
                        else
                        {
                            Console.WriteLine("                 Sorry! no Mobile equipment is currently there ");
                        }
                        break;

                    default:
                        Console.WriteLine("                 Wrong input entered !");
                        break;
                }
                Console.Write("\n");
                Console.WriteLine("                 Do you want to return to main menu ? Then press 1 else any key to exit");
                if (int.TryParse(Console.ReadLine(), out s6))
                {
                    goto label6vi;
                }
            }
            else
            {
                Console.WriteLine("                 Please enter valid input");
                goto label6i;
            }
        }
    }
}
