using static System.Console;

namespace SamplePrograms
{
    class Program
    {
        /// <summary>
        /// Print a binary triangle up to number of rowws given by user
        /// triangle is built using the numbers 0 and 1 alternatively
        /// if entered value is not a valid number then display message
        /// example if user gives 3 rows 
        /// 1
        /// 01
        /// 010  => here we can see the 0 and 1 are alternating
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Enter number of rows in a triangle");
            if (int.TryParse(ReadLine(), out int Number_rows))
            {
                WriteLine("Triangle is ");
                int previous_Value=0;
                for (int i =1; i <= Number_rows; i++)
                {
                    for (int q = 1; q <= i; q++)
                    {
                        if (previous_Value == 0)
                        {
                            Write("1");
                            previous_Value = 1;
                        }
                        else if (previous_Value == 1)
                        {
                            Write("0");
                            previous_Value = 0;
                        }
                    }
                    WriteLine();
                }
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
 */


