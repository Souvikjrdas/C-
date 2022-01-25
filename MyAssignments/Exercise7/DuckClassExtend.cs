using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class DuckClassExtended : IDuckInterfaceExtended
    {
        public int wings;
        public double weight;
        public Ducktype1 ducktype;

        public DuckClassExtended(int m)
        {

            Console.WriteLine("                 Enter the Wings:");
        label1: if (!(int.TryParse(Console.ReadLine(), out wings)) || wings < 0)
            {
                Console.WriteLine("                 Please enter valid wings");
                goto label1;
            }
        label2: Console.WriteLine("                 Enter the Weight:");
            try
            {
                weight = Convert.ToDouble(Console.ReadLine());
                if (weight < 0)
                {
                    Console.WriteLine("                 Please enter valid weight");
                    goto label2;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("                 Please enter valid weight");
                goto label2;
            }

            this.ducktype = (Ducktype1)m;
            Console.WriteLine("                 {0} duck has been created", ducktype);
        }
        public void ShowDetails()
        {
            if (ducktype == Ducktype1.Rubber)
            {
                Console.WriteLine("                  Rubber Duck ");
                Console.WriteLine("                  Wings:     {0}", this.wings);
                Console.WriteLine("                  Weight:    {0}", this.weight);
                Console.WriteLine("                  Traits:    These kind of ducks don’t fly and squeak");
            }
            else if (ducktype == Ducktype1.Mallard)
            {
                Console.WriteLine("                  Mallard Duck ");
                Console.WriteLine("                  Wings:     {0}", this.wings);
                Console.WriteLine("                  Weight:    {0}", this.weight);
                Console.WriteLine("                  Traits:    These kind of ducks fly fast and quack loud");
            }
            else
            {
                Console.WriteLine("                  Redhead duck ");
                Console.WriteLine("                  Wings:     {0}", this.wings);
                Console.WriteLine("                  Weight:    {0}", this.weight);
                Console.WriteLine("                  Traits:    These kind of ducks  fly slow and quack mild");
            }

        }
    }
}
