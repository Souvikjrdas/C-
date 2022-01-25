using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise3
{
    public class Prime1
    {
        public void PrimeNo(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                int d = 0;
                if (i <= 1)
                {
                    continue;
                }
                else if (i == 2 || i == 3)
                {
                    Console.Write("    " + i);
                }
                else
                {
                    double root = Math.Floor(Math.Sqrt(i));
                    for (int j = 2; j <= root; j++)
                    {
                        if (i % j == 0)
                        {
                            d = 1;
                            break;
                        }
                    }
                    if (d == 1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("  "+ i );
                    }
                }
            }
        }
    }
}
