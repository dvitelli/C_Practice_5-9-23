using System;
using System.Text;

namespace ExampleProject
{
    class Program
    {
        public static void Main(String[] args)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            if (!File.Exists(path))
            {
                File.Create(path);//check if it exists before creating it
            }

            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");
            fs.Write(info, 0, info.Length);//info array of bytes, second is offset, third is length of text to write to file
            fs.Close();

            StreamReader sr = new StreamReader(path);
            string fileText = sr.ReadToEnd();
            System.Diagnostics.Debug.WriteLine(fileText);

        }
    }
}
