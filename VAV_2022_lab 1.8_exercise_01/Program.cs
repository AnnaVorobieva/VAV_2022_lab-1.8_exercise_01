using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VAV_2022_lab_1._8_exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "F:/Упражнение 8";
            Print(path,0);
            Console.ReadKey();
        }
            
        static void Print(string path, int level)
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            if (dirs.Count() > 0 || files.Count() > 0)
            {
                string offset = new string('\t', level);
                foreach (string s in files)
                {
                    
                    Console.WriteLine(offset+s);
                }
                foreach (string s in dirs)
                {
                    Console.WriteLine(offset+s);
                    Print(s,level + 1);
                }
                
            }
        }
    }
    
}
