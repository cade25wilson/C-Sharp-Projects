using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(123);
            intList.Add(234);
            intList.Add(354);
            intList.Add(434);
            intList.Add(534);
            intList.Add(634);

            Console.WriteLine("Pick a number to divide the list by");
            try
            { 
            int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int i in intList)
                {
                    int total = (i / userInput);
                    Console.WriteLine("Dividing " + i + " by " + userInput + " is " + total);
                }
            }
            catch(FormatException )
            {
                Console.WriteLine("Please type a number.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Please pick a number other than 0");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of program.");
                Console.ReadLine();
            }
        }
    }
}
