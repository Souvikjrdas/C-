using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public class ProductClass : IEquatable<int>
    {
        public int id;
        public double price;
        public bool isDefective;
        public ProductClass()
        {
            id = (new Random()).Next(100, 1000);
        label1: Console.WriteLine("             Enter a valid  price of the product");
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
                if (price <= 0)
                {
                    goto label1;
                }
            }
            catch (Exception)
            {
                goto label1;
            }

            Console.WriteLine("             Is the product defective or not. Enter Y/N ");
        label2: var method = Console.ReadLine();
            if (method.ToLower() != "y")
            {
                if (method.ToLower() != "n")
                {
                    Console.WriteLine("             Enter valid answer please");
                    goto label2;
                }
            }
            isDefective = false;
            if (method.ToLower() == "y")
            {
                isDefective = true;
            }
        }

        public bool Equals(int id)
        {
            return this.id == id;
        }
    }
}
