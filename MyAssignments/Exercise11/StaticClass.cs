using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    public static class StaticClass
    {
        public static string IsEven(this Int_Class iclass)
        {
            if (iclass.i % 2 == 0)
                return "                " + iclass.i + " is an even number";
            else
                return "                " + iclass.i + " is not an even number";
        }
        public static string IsOdd(this Int_Class iclass)
        {
            if (iclass.i % 2 != 0)
                return "                " + iclass.i + " is an odd number";
            else
                return "                " + iclass.i + " is not an odd number";
        }

        public static string IsPrime(this Int_Class iclass)
        {
            double sqrt;
            if (iclass.i == 1)
                return "                " + iclass.i + " is not a prime number";
            else if (iclass.i == 2 || iclass.i == 3)
                return "                " + iclass.i + " is a prime number";
            else
                sqrt = Math.Floor(Math.Sqrt(iclass.i));
            for (int j = 2; j <= sqrt; j++)
            {
                if (iclass.i % j == 0)
                {
                    return "                " + iclass.i + " is not a prime number";
                }
            }
            return "                " + iclass.i + " is a prime number"; ;
        }
        public static string IsDivisible(this Int_Class iclass, int param)
        {
            if (iclass.i % param == 0)
            {
                return "                " + iclass.i + " is divisible by " + param;
            }
            else
            {
                return "                " + iclass.i + " is not divisible by " + param;
            }
        }
    }
}
