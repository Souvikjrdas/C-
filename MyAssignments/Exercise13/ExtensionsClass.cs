using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    public static class ExtensionsClass
    {
        //All operation - with custom logic being passed
        public static bool CustomAll<T>(this IEnumerable<T> collection, Func<T, bool> myfun)
        {
            //if (collection is null)
            //{
            //    throw new ArgumentNullException(nameof(collection));
            //}


            //iterate through the collection to check for the custom logic.
            foreach (var item in collection)
            {
                if (!myfun(item))
                {
                    return false;
                }

            }
            return true;
        }

        //Any operation - with custom logic being passed
        public static bool CustomAny<T>(this IEnumerable<T> collection1, Func<T, bool> myfun)
        {
            if (collection1 is null)
            {
                throw new ArgumentNullException(nameof(collection1));
            }

            //iterate through the collection to check for the custom logic and return accordingly.
            foreach (var elem in collection1)
            {
                if (myfun(elem))
                    return true;
            }
            return false;
        }

        //Max operation - with custom logic being passed
        public static Res CustomMax<T, Res>(this IEnumerable<T> collection2, Func<T, Res> myfun) where Res : IComparable<Res>
        {
            if (collection2 is null)
            {
                throw new ArgumentNullException(nameof(collection2));
            }
            Res max;
            var iterator = collection2.GetEnumerator();
            if (iterator.MoveNext())
            {
                max = myfun(iterator.Current);
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }

            //Move element by element in the collection with MoveNext() from IEnumerable collection.
            while (iterator.MoveNext())
            {
                var res2 = myfun(iterator.Current);
                if (max is null || max.CompareTo(res2) < 0)
                {
                    max = res2;
                }
            }
            return max;
        }

        //Min operation - with custom logic being passed.
        public static Res1 CustomMin<T, Res1>(this IEnumerable<T> collection3, Func<T, Res1> func) where Res1 : IComparable<Res1>
        {
            if (collection3 is null)
            {
                throw new ArgumentNullException(nameof(collection3));
            }
            Res1 min;
            var iterator1 = collection3.GetEnumerator();
            if (iterator1.MoveNext())
            {
                min = func(iterator1.Current);
            }
            else throw new InvalidOperationException("No elements");

            //Move element by element in the collection with MoveNext() from IEnumerable collection.
            while (iterator1.MoveNext())
            {
                var result = func(iterator1.Current);
                if (min is null || min.CompareTo(result) > 0)
                    min = result;
            }
            return min;
        }

        //Where operation - with custom logic being passed.
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> collection4, Func<T, bool> myfunc)
        {
            if (collection4 is null)
            {
                throw new ArgumentNullException(nameof(collection4));
            }
            //Iterate the collection.
            foreach (var item in collection4)
            {
                if (myfunc(item))
                {
                    yield return item;
                }
            }
        }

        //Select operation - with custom logic being passed.
        public static IEnumerable<Res2> CustomSelect<T, Res2>(this IEnumerable<T> collection5, Func<T, Res2> myfunc)
        {
            if (collection5 is null)
            {
                throw new ArgumentNullException(nameof(collection5));
            }
            foreach (var item in collection5)
            {
                yield return myfunc(item);
            }
        }
    }
}
