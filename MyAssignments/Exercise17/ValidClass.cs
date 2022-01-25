using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    public class ValidClass
    {
        public static bool CheckRange(int check)
        {
            if (check >= 1 && check <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidEven(string text)
        {
            int n;
            if (int.TryParse(text, out n))
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new CheckException("Entered number was invalid to check");
            }
        }
        public static bool ValidOdd(string text)
        {
            int n;
            if (int.TryParse(text, out n))
            {
                if (n % 2 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new CheckException("Entered number was invalid to check");
            }
        }
        public static bool ValidPrime(string text)
        {
            int n;
            if (int.TryParse(text, out n))
            {
                if (n == 1 || n < 0)
                {
                    return false;
                }
                else if (n == 2)
                {
                    return true;
                }
                else
                {
                    for (int i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
                    {
                        if (n % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            else
            {
                throw new CheckException("Entered number was invalid to check");
            }
        }
        public static bool ValidNegative(string text)
        {
            int n;
            if (int.TryParse(text, out n))
            {
                if (n < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new CheckException("Entered number was invalid to check");
            }
        }
        public static bool ValidZero(string text)
        {
            int n;
            if (int.TryParse(text, out n))
            {
                if (n == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new CheckException("Entered number was invalid to check");
            }
        }
    }
}
