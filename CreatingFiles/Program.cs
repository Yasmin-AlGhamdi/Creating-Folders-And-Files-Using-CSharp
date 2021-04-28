using System;
using System.IO;

namespace CreatingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Yasmin/Desktop";
            string folderName = "/Hussain";
            string fileName = "/Norah.txt";

            /*
             * To make sure the file doesn't exist
            if (!Directory.Exists(path + folderName))
            {
                Directory.CreateDirectory(path + folderName);
                Console.WriteLine("Folder " + folderName + " created!");
            }
            else
            {
                Console.WriteLine("Folder " + folderName + " already exists!");
                Directory.Delete(path + folderName);
            }
            */


            // Create a directory and a file:
            // Directory.CreateDirectory(path + folderName);
            // File.Create(path + folderName + fileName);


            /*
             * To write int the text file
            File.WriteAllText(path + folderName + fileName , "Hello Team");

            string content = File.ReadAllText(path + folderName + fileName);
            Console.WriteLine(content);
            */

            //To check if the file exists and then deleting the file
            if (File.Exists(path + folderName + fileName))
            {
                File.Delete(path + folderName + fileName);
            }
            else
            {
                Console.WriteLine("file " + fileName + " has already been deleted!");
            }


            Console.ReadKey();
        }
    }
}
