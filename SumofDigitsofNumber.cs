using static System.Console;

namespace SamplePrograms
{
    class Program
    {
        /// <summary>
        /// Find the sum of digits in a given number
        /// if entered value is not a valid number then display message
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter a number to find sum of digits");
            if (int.TryParse(ReadLine(), out int i))
            {
                int sum = 0;

                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                WriteLine("the sum of digits " + sum);
            }
            else
            {
                WriteLine("enter a valid number");
            }
            ReadKey();
        }
    }
}

/*learning 
 *1. In C# 6 and earlier, you must declare a variable in a separate statement before you pass it as an out argument.
 *   Starting with C# 7.0, you can declare the out variable in the argument list of the method call, rather than in a separate variable declaration.
 * 2. From C# 6 we can import only static members of a name sapce with the help of "using Static "
 */


