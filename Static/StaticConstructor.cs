using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class StaticConstructor
    {
        // static constructor - static constructor is called when using any static method without an instance
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public StaticConstructor()
        {
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }
    }
}
