using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Mobile : Equipment
    {
        public int wheels;
        public Mobile()
        {
            Console.WriteLine("                 Enter name of the mobile equipment :");
            name = Console.ReadLine();
            Console.WriteLine("                 Enter description :");
            description = Console.ReadLine();
            type = (EquipType)1;
            Console.WriteLine("                 Enter number of wheels :");
        label4i: if (!(int.TryParse(Console.ReadLine(), out wheels)))
            {
                Console.WriteLine("                 Please enter valid number of wheels :");
                goto label4i;
            }
        }
        public override void MoveBy(double distance)
        {
            dismovtilldate += distance;
            mcost = mcost + (wheels * distance);
        }

        public void ShowDetailsOfMobile()
        {
            Console.WriteLine("                 Name is :                  {0}", name);
            Console.WriteLine("                 Description -             \"{0}\" ", description);
            Console.WriteLine("                 Wheels -                   {0}", wheels);
            Console.WriteLine("                 Distance moved till date - {0} km", dismovtilldate);
            Console.WriteLine("                 Maintainance cost :        {0} Rs", mcost);
        }
    }
}
