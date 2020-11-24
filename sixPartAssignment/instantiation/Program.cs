using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
 

            string[] arrayText = new string[4];

            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine("enter a text of your choosing.");

                arrayText[i] = Console.ReadLine();
            }
            Console.WriteLine("here are the texts you entered: ");

            foreach (string i in arrayText)
            {

                Console.WriteLine(i);
            }


            //Console.WriteLine("Part 2 ");
            //Infinite Loop 
            //Comment out to initiate a loop

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("infinite loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 
            //}



            Console.WriteLine("Part 2.5");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Fix loop " + i);
            }

            Console.WriteLine("Part 3");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("The program has reached the < operator this is number " + j + " out of 4");
                j++;
            }

            Console.WriteLine("Part 4");
            int x = 0;
            while (x <= 5)
            {
                Console.WriteLine("The program has reached the <= operator this is numnber " + x + " out of 5");
                x++;
            }


            Console.WriteLine("Part 5");
            List<string> sweets = new List<string>() { "crunch", "skittles", "butterfingers", "oreo", "starburst" };
            Console.WriteLine("Enter a candy to search.");
            string input = Console.ReadLine();
            bool records = false;

            foreach (string i in sweets)
            {

                if (input == i)
                {
                    Console.WriteLine("You got an index of: " + sweets.IndexOf(i));
                    records = true;
                    break; 
                }
            }
            if (!records)
            {
                Console.WriteLine("Your text doesn't exist in the candy list.");
            }
            Console.ReadLine();


            Console.WriteLine("Part 6");

            List<string> sweets1 = new List<string>() { "crunch", "crunch", "skittles", "skittles", "butterfingers", "butterfingers", "oreo", "oreo", "starburst", "starburst", "hello" };
            Console.WriteLine("Enter another candy to search.");
            string input1 = Console.ReadLine();
            bool records1 = false;

            for (int k = 0; k < 10; k++)
            {
                if (sweets1[k] == input1)
                {
                    Console.WriteLine("Your item has an index of: " + k);
                    records1 = true;
                }
            }
            if (!records1) 
            {
                Console.WriteLine("Your text doesn't exist in the list sweets.");
            }
            Console.ReadLine();



            Console.WriteLine("Final Part");
            List<string> storage = new List<string>();
            foreach (string y in sweets1)
            {

                if (storage.Contains(y))
                {
                    Console.WriteLine("This candy already appears in the list: ");
                    Console.WriteLine(y);
                }
                else
                {
                    storage.Add(y);
                }
            }
            Console.ReadLine();
        }
    }
}