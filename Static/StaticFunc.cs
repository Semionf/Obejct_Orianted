using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class StaticFunc
    {
        //static functions can be used only with the ClassName and not with an instance
        //Static Data members:
        static int counter;
        static int sum;

        //Static Method:
        public static double Average()
        {
            return (double)sum / counter;
        }
    }
}
