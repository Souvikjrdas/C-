using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Exercise16
{
    public class FileClass
    {
        //Total number of text files in the directory.
        public static void TextFiles(string text)
        {
            DirectoryInfo dinfo = new DirectoryInfo(text);
            var method1 = dinfo.GetFiles().ToList();
            int n = method1.Where(item => item.FullName.Contains(".txt")).Count();
            Console.WriteLine(@"             The number of text files in the directory (*.txt): {0}", n);
            Console.Write("\n");
        }
        //No of file per extension type
        public static void PerExtension(string text)
        {
            DirectoryInfo dinfo = new DirectoryInfo(text);
            Console.WriteLine("             Total files per extension type:");
            var ex_type = dinfo.EnumerateFiles("*.*", SearchOption.TopDirectoryOnly).GroupBy(item => item.Extension).Select(bb => new { Extension = bb.Key, Count = bb.Count() }).ToList();
            foreach (var item in ex_type)
            {
                Console.WriteLine("             Files prsent with extension \"{0}\" is: {1}", item.Extension, item.Count);
            }
            Console.Write("\n");
        }
        //Total 5 files with maximum size
        public static void MaxFiles(string text)
        {
            DirectoryInfo dinfo = new DirectoryInfo(text);
            Console.WriteLine("             The top 5 largest files, along with their file size:");
            var maxfiles = dinfo.GetFiles().OrderByDescending(item => item.Length).Take(5);
            var maxfiles1 = maxfiles.ToList();
            if (maxfiles1.Count() != 0)
            {
                foreach (var item in maxfiles1)
                {
                    Console.WriteLine("             The file \"{0}\" has size {1} MB", item.Name, item.Length / 1024f / 1024f);
                }
            }
            Console.WriteLine("\n");
        }
        //File with maximum size.
        public static void MaxLength(string text)
        {
            DirectoryInfo dinfo = new DirectoryInfo(text);
            var maxfiles = dinfo.GetFiles().OrderByDescending(item => item.Length).Take(5);
            var maxfiles1 = maxfiles.ToList();
            if (maxfiles1.Count() != 0)
            {
                Console.WriteLine("             The file \"{0}\" has maximum length in the directory {1} MB", ((FileInfo)maxfiles1[0]).Name, ((FileInfo)maxfiles1[0]).Length / 1024f / 1024f);
            }
        }
    }
}
