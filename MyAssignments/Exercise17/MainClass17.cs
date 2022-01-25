using System;
namespace Exercise17
{
    public class MainClass17
    {
        public static void MainFunc17()
        {
            int ch17i = -1;
            int n = 1;
            Console.WriteLine("                                     Hey! Welcome to my game ");
            Console.WriteLine("                     A quick note! you will be able to play this game only for five times");
            Console.WriteLine("                                         Lets begin!");
            Console.Write("\n");
            while (n <= 5)
            {
                Console.WriteLine("                                 Enter any number from 1-5 ");
                Console.Write("\n");
                try
                {
                    if (int.TryParse(Console.ReadLine(), out ch17i))
                    {
                        if (ValidClass.CheckRange(ch17i))
                        {
                            Console.WriteLine("                                 Success!");
                            n++;
                            if (ch17i == 1)
                            {
                                Console.WriteLine("                                 Enter even number :");
                                if (ValidClass.ValidEven(Console.ReadLine()))
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Success! Entered number was even");
                                    Console.Write("\n");
                                }
                                else
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Wrong Answer! Entered number was not even");
                                    Console.Write("\n");
                                }
                            }
                            else if (ch17i == 2)
                            {
                                Console.WriteLine("                                 Enter odd number :");
                                if (ValidClass.ValidOdd(Console.ReadLine()))
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Success! Entered number was odd");
                                    Console.Write("\n");
                                }
                                else
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Wrong Answer! Entered number was not odd");
                                    Console.Write("\n");
                                }
                            }
                            else if (ch17i == 3)
                            {
                                Console.WriteLine("                                 Enter prime number :");
                                if (ValidClass.ValidPrime(Console.ReadLine()))
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Success! Entered number was prime");
                                    Console.Write("\n");
                                }
                                else
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Wrong Answer! Entered number was not prime");
                                    Console.Write("\n");
                                }
                            }
                            else if (ch17i == 4)
                            {
                                Console.WriteLine("                             Enter negative number");
                                if (ValidClass.ValidNegative(Console.ReadLine()))
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Success! Entered number was negative");
                                    Console.Write("\n");
                                }
                                else
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Wrong Answer! Entered number was not negative");
                                    Console.Write("\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("                                 Enter Zero");
                                if (ValidClass.ValidZero(Console.ReadLine()))
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Success! Entered number was zero");
                                    Console.Write("\n");
                                }
                                else
                                {
                                    Console.Write("\n");
                                    Console.WriteLine("                                 Wrong Answer! Entered number was not zero");
                                    Console.Write("\n");
                                }
                            }

                        }
                        else
                        {
                            Console.Write("\n");
                            throw new CheckException("                                  Enter valid options in range ");
                        }
                    }
                    else
                    {
                        Console.Write("\n");
                        throw new CheckException("                                  Invalid input");
                    }
                }
                catch (CheckException exe)
                {
                    Console.WriteLine(exe.Message);
                    Console.Write("\n");
                }
                ch17i = -1;
            }
            Console.Write("\n");
            Console.WriteLine("                                 Sorry! you have played this game for 5 times ");
        }
    }
}
