using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Koulu
{
    class Program
    {
        static void Main(string[] args)
        {
            string nro = null;
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\T2Integers.txt");

            Console.WriteLine("Give a random number");
            do
            {
               
                nro = Console.ReadLine();
                outputFile.WriteLine(nro);// Kirjoitetaan levylle
            } while (nro. != 0);

            outputFile.WriteLine(nro);
                outputFile.Close();
            }

        }
    }
}