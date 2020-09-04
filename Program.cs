using System;
using System.IO;

namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\File1.txt";
            StreamReader rs = null;
            try
            {

                rs = File.OpenText(path);
                while(!rs.EndOfStream)
                {
                    string line = rs.ReadLine();
                    Console.WriteLine(line);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (rs != null)
                    rs.Close();
                
            }
        }
    }
}
