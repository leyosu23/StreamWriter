using System;
using System.IO;        //Step I - inluding the necessary namespace

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile("Test.txt");
            ReadFile("Test.txt");
        }
        static void WriteFile(string filename)
        {
            TextWriter writer = new StreamWriter(filename); //Step II - create the object to write to
            writer.Write("Hello ");
            writer.WriteLine("Yoonseop Lee");
            writer.WriteLine("I am a genius!!");
            for (int i = 1; i <= 12; i++)
            {
                writer.WriteLine($"{i} x 3 = {i *3}");
            }

            writer.Close();                                 //Step IV - close the writer object
        }

        static void ReadFile(string filename)
        {
            TextReader reader = new StreamReader(filename); //create an object to read from
            string input = reader.ReadLine();
            int line = 1;
            while (input != null)   //continue while we can still read input
            {
                Console.WriteLine($"{line++} {input}");
                input = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
