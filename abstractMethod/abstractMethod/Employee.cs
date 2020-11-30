using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod
{
    public class Employee : Person
    {
        public int id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

    }
}
