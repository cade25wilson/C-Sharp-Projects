using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
                DateTime currentTime = DateTime.Now;
                Console.WriteLine(currentTime);
                Console.WriteLine("Please enter a number");
            try { 
                int num1 = Convert.ToInt32(Console.ReadLine());
                TimeSpan futureTime = new TimeSpan(num1, 0, 0);
                DateTime combinedTime = currentTime.Add(futureTime);
                if (num1 <= 1)
                {
                    Console.WriteLine("in " + num1 + " hour, the time will be " + combinedTime);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("in " + num1 + " hours, the time will be " + combinedTime);
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a number");
                return;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
