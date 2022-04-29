using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SQL_Customer_Creator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;

            Console.WriteLine("Enter Filename: ");
            String filename = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(filename);

            String path = @"C:\Users\MIT54321\development\" + filename;

            Console.WriteLine();
            Console.WriteLine(path);


            if (!File.Exists(path))
            {
                //Create file to write to
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("init Cust_Create");
                    //sw.WriteLine($"{i}");

                    while (i<5)
                    { 
                        sw.WriteLine(i);
                        i++;
                    }



                }
            }

            String statement;
            statement = $"";

            
            // open the file to read from 
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while (( s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        } // end main method
            
    } // end class
} // end namespace
