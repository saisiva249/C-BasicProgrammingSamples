using System;
using static System.Console;

namespace SamplePrograms
{
    class Program
    {
        /// <summary>
        /// Ask the user to enter a sentence and the word that has to be find how many times it occured.
        /// when the input is given then finding the word occurance in sentence
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter the sentence where to search term");
            string input = ReadLine();
            WriteLine("enter word to search");
            string str = ReadLine();
            int i =0,  count=0;
            while ((i=input.IndexOf(str,i))!=-1)
            {
                count++;
                i += str.Length;
            }
            WriteLine($"Number of times \"{str}\"  occured is =" + count);
        }
    }
}



