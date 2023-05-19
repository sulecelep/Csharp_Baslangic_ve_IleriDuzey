using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_236_SystemIO_FileIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool kontrol = FileExists("c:\\Users\\CELEP\\Desktop\\merhaba.txt");
            //if(kontrol)
            //{
            //    Console.WriteLine("Belirtmiş olduğunuz dosya sistem içerisinde bulunmaktadır");
            //}
            //else
            //{
            //    FileCreate("c:\\Users\\CELEP\\Desktop\\merhaba.txt");
            //}
            //FileAppendText("c:\\Users\\CELEP\\Desktop\\merhaba.txt", "Merhaba ben bir text dosyasıyım.");
            //string metin=FileReadAllText("c:\\Users\\CELEP\\Desktop\\merhaba.txt");
            //Console.WriteLine(metin);
            //FileDelete("c:\\Users\\CELEP\\Desktop\\merhaba.txt");
            //FileCopy("c:\\Users\\CELEP\\Udemy\\merhaba.txt", "c:\\Users\\CELEP\\Desktop");
            //FileMove("c:\\Users\\CELEP\\Desktop\\merhaba.txt", "c:\\Users\\CELEP\\Udemy\\merhaba.txt");

        }
        static void FileCreate(string path)
        {
            FileStream Fs =  File.Create(path); //FileStreami açık şekilde dosya oluşturuyor bunu kapatmazsak hata alırız
            Fs.Close();
        }
        static bool FileExists(string path) 
        {
            return File.Exists(path);
        }
        static void FileDelete(string path) 
        { 
            File.Delete(path);
        }
        static void FileMove(string path, string target)
        {
            File.Move(path, target);
        }
        static void FileCopy(string path, string target)
        {
            File.Copy(path, target);
        }
        static void FileAppendText(string path, string text)
        {
            File.AppendAllText(path, text); 
        }
        static string FileReadAllText(string path)
        {
            return File.ReadAllText(path);  
        }
    }
}
