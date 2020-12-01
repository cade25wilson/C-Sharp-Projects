using System;


namespace methodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            newClass newClass = new newClass();

            Console.WriteLine(newClass.myMethod(12));

            Console.WriteLine(newClass.myMethod(1.5m));

            Console.WriteLine(newClass.myMethod("24"));

            Console.ReadLine();
        }
    }
}