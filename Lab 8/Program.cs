using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = "C:/Users/User/source/repos";
            if (Directory.Exists(path))
            {
                Console.WriteLine(path);
                string[] file = Directory.GetFiles(path);
                foreach (string f in file)
                {
                    Console.WriteLine(f);
                }
                string[] dir = Directory.GetDirectories(path);
                foreach (string subDir in dir)
                {
                    Console.WriteLine(subDir);
                    string[] file2 = Directory.GetFiles(subDir);
                    foreach (string f in file2)
                    {
                        Console.WriteLine(f);
                    }
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("каталог не найден");
            }
            Console.ReadKey();
        }
    }
}
