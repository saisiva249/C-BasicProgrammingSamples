using System;
using static System.Console;

namespace SamplePrograms
{
    class Program
    {
        /// <summary>
        /// printing diamond
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of rows");
            int count = Convert.ToInt32(Console.ReadLine());  
            int space = count - 1;
            int k, i;
            for (k=1;k<=count;k++)
            {
                for (i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space--;
                for (i = 1; i <= 2*k-1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            space = 1;
            for (k = 1; k < count; k++)
            {
                for (i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space++;
                for (i = 1; i <= 2 * (count-k) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}


/*if total we are printing a diamond with rows 3  top 3 rows will be our main rows and the next are just image relflection
  if we consider printing rows = 3 then if we observer the space in the intial row is 2, from the left of star
  if rows =4 no of spaces in the top row is 3  ===> total rows = n, spaces that has to be started with is n-1
  and the spaces in the second row has to be 1 less than actual ==> spaces--
  for printing * if we observe that number of rows in the top column is 1 , then 3, 5 ....
  means sequence is 1,3,5,7 in the respective rows==> 2*rowNumber-1 
  
  Coming to the reflection:
  then we start our row printing but as it is image reflection with out the center row, so number of rows => rows-1 means k<=count-1, or k<count 
  now as we are already printed all the number of starts with above logic, now the spaces should start with 1 and it should increase back 
  So spaces =1, 
  For printing * now *'s count has to reduce and come to 1,measns as k increases * should reduce
  so (count-k) and as sequnce agian is an odd 2*(count-k)-1
  
   *
  ***
 *****
  ***
   * 
  
*/
