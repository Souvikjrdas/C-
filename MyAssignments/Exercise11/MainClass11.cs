using System;

namespace Exercise11
{
    public class MainClass11
    {
        public static void MainFun11()
        {
            int ch, ch1;
    label1: Console.WriteLine("             Enter a number: ");
            var s = Console.ReadLine();
            Console.WriteLine("             Enter a number to divide :");
            var s1 = Console.ReadLine();
            var b = int.TryParse(s, out ch);
            var b1 = int.TryParse(s1, out ch1);
            if (b & b1)
            {
                var ob = new Int_Class(ch);
                Console.WriteLine(ob.IsEven());
                Console.WriteLine(ob.IsOdd());
                Console.WriteLine(ob.IsPrime());
                Console.WriteLine(ob.IsDivisible(ch1));
            }
            else
            {
                Console.WriteLine("             Enter a valid number");
                goto label1;
            }
            Console.WriteLine("             Do you want to continue ? If yes the type Y else any key to exit.");
            var method = Console.ReadLine();
            if (method == "y" || method == "Y")
            {
                goto label1;
            }
        }
    }
}
