using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeEval_Penultimate_Word_20160121
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //**Code Eval Directions: Write a program which finds the next-to-last word in a string.
            //**Solved

            string line = "Betty June Sally Jesus Mary Joseph Carlos";

            string[] input = line.Split(' ');
            Console.WriteLine(input[input.Length - 2]);

            






            Console.ReadKey();
        }
    }
}
