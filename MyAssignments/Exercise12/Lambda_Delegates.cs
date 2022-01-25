using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Lambda_Delegates
    {
        public static void Main1(List<int> list)
        {

            // odd  Lambda Expression
            IEnumerable<int> odd = list.Where(x => x % 2 == 1);
            Display.Show("Numbers which are odd", odd);

            //Even  Lambda Expression 
            IEnumerable<int> even = list.Where(x => { return x % 2 == 0; });
            Display.Show("Numbers which are even", even);

            //Prime  Anonymous Method
            IEnumerable<int> primes = list.Where(delegate (int x)
            {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            Display.Show("Numbers which are prime", primes);

            // Prime Another  Lambda Expression
            IEnumerable<int> primesAnother = list.Where(x =>
            {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            Display.Show("Primes Another", primesAnother);

            // Elements Greater Than Five  Method Group Conversion Syntax
            Func<int, bool> CMore = NecessaryFunctions.GreaterThanFive;

            //  delegate
            IEnumerable<int> greatfive = list.Where(CMore);
            Display.Show("Numbers which are greater than five", greatfive);

            // Less than Five  delegate Object in Where  Method Group Conversion Syntax in Constructor of Object
            Func<int, bool> b = new Func<int, bool>(NecessaryFunctions.LessThanFive);
            IEnumerable<int> lessfive = list.Where(b);
            Display.Show("Numbers which are less than five", lessfive);

            // Find 3k  Delegate Object in Where  Lambda Expression in Constructor of Object
            Func<int, bool> k3 = new Func<int, bool>(x => x % 3 == 0);
            IEnumerable<int> list3k = list.Where(k3);
            Display.Show("Numbers which are multiple of 3 ie 3k", list3k);

            // Find 3k + 1  Delegate Object in Where  Anonymous Method in Constructor of Object
            Func<int, bool> k3plus1 = new Func<int, bool>(delegate (int x)
            {
                return x % 3 == 1;
            }
            );
            IEnumerable<int> list3kplus1 = list.Where(k3plus1);
            Display.Show("Numbrs which are 1 more than multiple of 3 ie 3k+1", list3kplus1);

            // Find 3k + 2  Delegate Object in Where  Lambda Expression.
            Func<int, bool> k3plus2 = x => x % 3 == 2;
            IEnumerable<int> list3kplus2 = list.Where(k3plus2);
            Display.Show("Numbers which are 2 more than multiple of 3 ie 3k+2", list3kplus2);

            // Find anything  Delegate Object in Where  Anonymous Method.
            Func<int, bool> Any_number = delegate (int x)
            {
                return x != 0;
            };
            IEnumerable<int> anything = list.Where(Any_number);
            Display.Show("Any number", anything);

            // Find anything  Delegate Object in Where  Method Group Conversion .
            Func<int, bool> another_1 = NecessaryFunctions.AnythingMethod;
            IEnumerable<int> another_2 = list.Where(another_1);
            Display.Show("Anything", another_2);
        }
    }
}
