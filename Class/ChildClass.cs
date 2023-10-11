using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    //A class may inherit directly from one parent class, and it may implement any number of interfaces
    internal class ChildClass : ParentClass, IntefaceA , IntefaceB
    {
        public int CalcuLate()
        {
            return 3;
        }
        public string CalcuLateA()
        {
            return "CalcuLateA";
        }

        public string CalcuLateB()
        {
            return "CalcuLateB";

        }
    
    }
}




