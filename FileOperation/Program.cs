using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\HelloWorldFile.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello World, How Are You Today ?");
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            string pathMove = @"D:\HelloWorldFile_renameORmove.txt";

            File.Copy(path, @"D:\HelloWorldFile_copy.txt");
            File.Move(path, pathMove);

            using (StreamWriter sw = File.CreateText(pathMove))
            {
                sw.WriteLine("Hello World, File is moved or renamed");
            }

            using (StreamReader sr = File.OpenText(pathMove))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            File.Delete(pathMove);

            Console.ReadLine();
        }
    }
}
