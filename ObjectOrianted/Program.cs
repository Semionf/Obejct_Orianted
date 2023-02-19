using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrianted
{
    public class Program
    {
        public class number
        {
            public int value;
        }
        static void Main(string[] args)
        {
            number number = new number();
            number.value= 1;
            ChangeOb(number);
            Console.WriteLine(number.value);
        }
        public static void ChangeOb(number x)
        {
            x.value++;
            x = new number();
            x.value = 10;
        }

    }
}
