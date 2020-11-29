using System;

namespace methodOverload
{
    class newClass
    {
        public newClass()
        {

        }

        public int myMethod(int num)
        {
            return num * 2;
        }


        public int myMethod(decimal d)
        {
            return Convert.ToInt32(d % 5);
        }

        public int myMethod(string s)
        {
            int final = Convert.ToInt32(s) + 1000;
            return final;
        }
    }


}
 
 
 