using System;
using static System.Console;

namespace SamplePrograms
{
    class Program
    {
        /// <summary>
        /// Ask the user to enter how many inputs he is going to give
        /// when all the inputs are given then displays the number of 1's in that group
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter the input limit");
            int limit = Convert.ToInt32(ReadLine());
            int count=0;
            for(int i = 0; i<limit; i++)
            {
                if (Convert.ToInt32(ReadLine())==1)
                {
                    count++;
                }
            }
            WriteLine("Number of 1's in the entered numbers is " + count);
        }
    }
}



