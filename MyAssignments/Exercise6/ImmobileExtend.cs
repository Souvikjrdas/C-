using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class ImmobileExtend : EquipmentExtend
    {
        public double weight;

        public ImmobileExtend()
        {
            Console.WriteLine("                 Enter name of the immobile equipment :");
            name = Console.ReadLine();
            Console.WriteLine("                 Enter description :");
            description = Console.ReadLine();
            type = (EquipTypeExtend)2;
        label6ii: Console.WriteLine("                   Enter the weight :");
            try
            {
                weight = Convert.ToDouble(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("                 Please enter valid weight");
                    goto label6ii;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("                 Please enter valid weight");
                goto label6ii;
            }
        }
        public override void MoveByExtend(double distance)
        {
            dismovtilldate += distance;
            mcost = mcost + (weight * distance);
        }
        public void ShowDetailsOfImmobileExtend()
        {
            Console.WriteLine("                 Name is :                  {0}", name);
            Console.WriteLine("                 Description -             \"{0}\" ", description);
            Console.WriteLine("                 Weight -                   {0}", weight);
            Console.WriteLine("                 Distance Moved Till Date - {0} km", dismovtilldate);
            Console.WriteLine("                 Maintainance cost :        {0} Rs", mcost);
        }
    }
}
