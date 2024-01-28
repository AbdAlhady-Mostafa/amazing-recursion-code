using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world";
            Console.WriteLine(s.ReplaceWhiteSpacesWithSlashes().ReverseString());
            Console.WriteLine(fact(5));
            PrintSubFolders(@"H:\Adobe Photoshop 2023 v24.3.0.376 x64",0);
            Console.WriteLine(PrintFolderSize(@"H:\Adobe Photoshop 2023 v24.3.0.376 x64"));
        }
        public static int fact(int x)
        {
            if(x <= 1)
            {
                return x;
            }
            return x * fact(x - 1);
        }
        public static void PrintSubFolders(string path ,int level)
        {
            foreach (var item in Directory.GetFiles(path))
            {
                Console.WriteLine($"{level} --> {new FileInfo(item).Name}");
            }
            foreach (var item in Directory.GetDirectories(path))
            {
                Console.WriteLine(new DirectoryInfo(item).Name);
                PrintSubFolders(item,level+1);
            }
        }
        public static long size = 0;
        public static long PrintFolderSize(string path)
        {
           
            foreach (var item in Directory.GetFiles(path))
            {
                size += new FileInfo(item).Length;
            }
            foreach (var item in Directory.GetDirectories(path))
            {
               PrintFolderSize(item);
            }
            return size;
        }
      
    }
}
