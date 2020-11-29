using System;


namespace ClassesLab114
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            /*call the first method, passing in an integer, such as 12. Then display the result to the screen.*/
            Console.WriteLine(myClass.myMethod(12));

            /*call the second method, passing in a decimal. Display the result to the screen.*/
            Console.WriteLine(myClass.myMethod(1.5m));

            /*call the third method, passing in a string that equates to an integer. 
             * Display the result to the screen.*/
            Console.WriteLine(myClass.myMethod("24"));

            Console.ReadLine();
        }
    }
}