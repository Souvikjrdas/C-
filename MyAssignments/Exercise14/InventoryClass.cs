using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public class InventoryClass
    {
        public static int q;
        public static double total;
        private static readonly Dictionary<ProductClass, int> dictionary = new Dictionary<ProductClass, int>();
        public static Dictionary<ProductClass, int> products1 = dictionary;
        public static void Add(ProductClass ob)
        {
            int s = 0;
            if (!(ob.isDefective))
            {
                Console.WriteLine("             Enter the number of quantities: ");
            label1: if (int.TryParse(Console.ReadLine(), out s) && s >= 0)
                {
                    products1.Add(ob, s);
                    Console.WriteLine("             Product with id {0} has been added succesfully", ob.id);
                }
                else
                {
                    Console.WriteLine("             Enter valid input ");
                    goto label1;
                }
            }
            else
            {
                Console.WriteLine("             Product cannot be added as it is defective");
            }
        }
        public static void Remove()
        {
            int ch = 0;
            if (products1.Count == 0)
            {
                Console.WriteLine("             Inventory is empty!");
            }
            else
            {
                Console.WriteLine("             Products present in the inventory are:");
                Console.WriteLine("             ");
                foreach (var item2 in products1)
                {
                    Console.Write(item2.Key.id);
                    Console.Write(" ");
                }
                Console.Write("\n");
                Console.WriteLine("             Enter the product id to be removed");
                ProductClass pro = null;
            label2: if (int.TryParse(Console.ReadLine(), out ch) && ch >= 100)
                {
                    foreach (var item in products1)
                    {
                        if (item.Key.id == ch)
                        {
                            pro = item.Key;
                            break;
                        }
                    }
                    if (pro != null)
                    {
                        products1.Remove(pro);
                        Console.WriteLine("             Product with id {0} has been removed succesfully.", pro.id);
                    }
                    else
                    {
                        Console.WriteLine("             Product id {0} not found in the inventory", ch);
                    }
                }
                else
                {
                    Console.WriteLine("             Enter valid input ");
                    goto label2;
                }
            }

        }
        public static void UpdateProduct()
        {
            int ch = 0, check = 0;
            if (products1.Count == 0)
            {
                Console.WriteLine("             Inventory is empty!");
            }
            else
            {
                Console.WriteLine("             Products present in the inventory are:");
                Console.WriteLine("             ");
                foreach (var item2 in products1)
                {
                    Console.Write(item2.Key.id);
                    Console.Write(" ");
                }
                Console.Write("\n");
                Console.WriteLine("             Enter the product id to be updated :");
            label5: if (int.TryParse(Console.ReadLine(), out ch) && ch >= 100)
                {
                    foreach (var item in products1)
                    {
                        if (item.Key.id == ch)
                        {
                            check = 1;
                            Console.WriteLine("             Enter the quantities to be updated ");
                            int q1;
                        label3: if (int.TryParse(Console.ReadLine(), out q1) && q1 > 0)
                            {
                                products1[item.Key] = q1;
                                Console.WriteLine("             Product has been updated succesfully.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("             Enter valid quantity");
                                goto label3;
                            }

                        }
                    }
                    if (check != 1)
                    {
                        Console.WriteLine("             Product id {0} not found in the inventory", ch);
                    }

                }
                else
                {
                    Console.WriteLine("             Please enter valid product id");
                    goto label5;
                }

            }

        }
        public static void TotValue()
        {
            foreach (var item in products1)
            {
                total += item.Key.price * item.Value;
            }
            Console.WriteLine("             Total value in the inventory is : {0}", total);
        }
    }
}
