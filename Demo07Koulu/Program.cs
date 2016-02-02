using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Koulu
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\T1Lines.txt");
            do
            {
                Console.WriteLine("Give text line(Enter Stops)");
                line = Console.ReadLine();
                outputFile.WriteLine(line);// Kirjoitetaan levylle
            } while (line.Length != 0);
            outputFile.Close();
            try
            {   string text = File.ReadAllText(@"d:\T1Lines.txt");
                Console.WriteLine(text);
            }
          catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            finally
            {
                File.ReadAllLines(@"d:\T1Lines.txt");
            }

        }

        }
    }

