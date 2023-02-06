using System;
using System.IO;
using System.Linq;


namespace filenameget
{

    public class filenameget
    {
        static void Main()
        {
            string[] file_directory =  Directory.GetFiles(@"H:\趣味\ゲーム",".json");
            int Count = file_directory.Count();

            for(int i = 0; i < Count;i++)
            {
                file_directory[i] = Path.GetFileName(file_directory[i]);
            }

            foreach (string file in file_directory)
            {
                Console.WriteLine(file);
            }
        }
    }
}