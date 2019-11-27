using static System.Console;

namespace SamplePrograms
{
    class Program
    {
        /// <summary>
        /// Find the reverse of a given number
        /// if entered value is not a valid number then display message
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter a number to find reverse ");
            if (int.TryParse(ReadLine(), out int i))
            {
                int sum = 0;

                while (i > 0)
                {
                    sum = sum*10 + i % 10;
                    i /= 10;
                }
                WriteLine("the reverse of given number " + sum);
            }
            else
            {
                WriteLine("entered number is not a valid integer");
            }
            ReadKey();
        }
    }
}

/*learning 
 * In C# 6 and earlier, you must declare a variable in a separate statement before you pass it as an out argument.
 * Starting with C# 7.0, you can declare the out variable in the argument list of the method call, rather than in a separate variable declaration.
 * Use try parse to avoid the casting exceptions thrown by Convert.ToInt() and int.parse() methods
 */


