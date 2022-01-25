using System;

namespace Exercise14
{
    public class MainClass14
    {
        public static void MainFunc14()
        {
            int ch14, mych14 = 0;
        label14ii: Console.WriteLine("             Press 1 to add a product in the inventory");
            Console.WriteLine("             Press 2 to remove a product in the inventory");
            Console.WriteLine("             Press 3 to update a product n the inventory");
            Console.WriteLine("             Press 4 to compute the total value in the inventory");
        label14i: if (int.TryParse(Console.ReadLine(), out ch14))
            {
                switch (ch14)
                {
                    case 1:
                        ProductClass ob1 = new ProductClass();
                        InventoryClass.Add(ob1);
                        break;
                    case 2:
                        InventoryClass.Remove();
                        break;
                    case 3:
                        InventoryClass.UpdateProduct();
                        break;
                    case 4:
                        InventoryClass.TotValue();
                        break;
                    default:
                    label14iii: Console.WriteLine("             Wrong input entered Please press 1 to go back to main menu or 0 to exit");
                        int x;
                        if (int.TryParse(Console.ReadLine(), out x) && x == 1)
                        {
                            goto label14ii;
                        }
                        else if (x == 0)
                        {
                            mych14 = 1;
                            break;
                        }
                        else
                        {
                            goto label14iii;
                        }
                }
                if (mych14 != 1)
                {
                    int p1;
                    Console.WriteLine("             Do you want to continue ? press 1 to go back to main menu else any key to exit");
                    if (int.TryParse(Console.ReadLine(), out p1) && p1 == 1)
                    {
                        goto label14ii;
                    }
                }
            }
            else
            {
                Console.WriteLine("             Please enter a valid input");
                goto label14i;
            }
        }
    }
}
