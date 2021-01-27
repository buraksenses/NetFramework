using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO.FileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = FileExist("d:\\Udemy\\merhaba.txt");
            if (kontrol)
            {
                Console.WriteLine("Klasör daha önceden oluşturulmuş!!");
            }
            else
            {
                FileCreate("d:\\Udemy\\merhaba.txt");
            }

            FileDelete("d:\\Udemy\\merhaba.txt");

            //FileMove("d:\\Udemy\\merhaba.txt", "d:\\Udemy1\\merhaba.txt");

            string metin =  fileRead("d:\\Udemy1\\merhaba.txt");
            Console.WriteLine(metin);

            fileAppend("d:\\Udemy1\\merhaba.txt", "NE AMCASI KARDEŞ?");
        }

        static void FileCreate(string path)
        {
            FileStream fs =  File.Create(path);
            fs.Close();
        }

        static bool FileExist(string path)
        {
            return File.Exists(path);
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }

        static void FileMove(string source,string dest)
        {
            File.Move(source, dest);
        }

        static void fileCopy(string source,string dest)
        {
            File.Copy(source, dest);
        }

        static void fileAppend(string path,string content)
        {
            File.AppendAllText(path,content);
        }

        static string fileRead(string path)
        {
            string metin = File.ReadAllText(path);
            return metin;
        }
    }
}
