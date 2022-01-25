using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class MobileExtend : EquipmentExtend
    {
        public int wheels;
        public MobileExtend()
        {
            Console.WriteLine("                 Enter name of the mobile equipment :");
            name = Console.ReadLine();
            Console.WriteLine("                 Enter description :");
            description = Console.ReadLine();
            type = (EquipTypeExtend)1;
            Console.WriteLine("                 Enter number of wheels :");
        label6i: if (!(int.TryParse(Console.ReadLine(), out wheels)))
            {
                Console.WriteLine("                 Please enter valid number of wheels :");
                goto label6i;
            }
            else if (wheels <= 0)
            {
                Console.WriteLine("                 Please enter valid number of wheels :");
                goto label6i;
            }
            else
            {

            }
        }
        public override void MoveByExtend(double distance)
        {
            dismovtilldate += distance;
            mcost = mcost + (wheels * distance);
        }

        public void ShowDetailsOfMobileExtend()
        {
            Console.WriteLine("                 Name is :                  {0}", name);
            Console.WriteLine("                 Description -             \"{0}\" ", description);
            Console.WriteLine("                 Wheels -                   {0}", wheels);
            Console.WriteLine("                 Distance moved till date - {0} km", dismovtilldate);
            Console.WriteLine("                 Maintainance cost :        {0} Rs", mcost);
        }
    }
}
