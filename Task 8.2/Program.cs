using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Random.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int r = rnd.Next(100);
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.Write(r + " ");
                    sw.Close();
                }
            }
            int Sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string newString = sr.ReadToEnd();
                string[] stringArray = newString.Split();
                for (int i = 0; i < 10; i++)
                {
                    Sum += Convert.ToInt32(stringArray[i]);
                }
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
    }
}
