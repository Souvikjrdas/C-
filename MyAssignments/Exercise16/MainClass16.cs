using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
namespace Exercise16
{
    public class MainClass16
    {
        public static void MainFunc16()
        {
            //Get all the files from a given directory and perform the following actions
            string text = string.Empty;
            Console.Write("Enter the directory: ");
            text = Console.ReadLine();
            Console.Write("\n");
            if (Directory.Exists(text))
            {
                FileClass.TextFiles(text);
                FileClass.PerExtension(text);
                FileClass.MaxFiles(text);
                FileClass.MaxLength(text);
            }
            else
            {
                Console.WriteLine("Sorry no such directory exists!");
            }
        }
    }
}
