using System;

namespace method
{
    class MyClass
    {
        public MyClass()
        {

        }


        public void outInt(out int x, int y)
        {
            x = y / 2;    
        }

        
        public void assignValues(out int x, out int y, int addition = 7)
        {
            x = Convert.ToInt32(Console.ReadLine()) + addition;
            y = Convert.ToInt32(Console.ReadLine()) + addition;
        }

        public void assignValues(out double x, out double y, int addition = 0)
        {
            x = Convert.ToDouble(Console.ReadLine()) + addition;
            y = Convert.ToDouble(Console.ReadLine()) + addition;
        }


    }
}
 