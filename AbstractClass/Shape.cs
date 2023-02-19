using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public int x, y;
        private int ID = 0;
    }
}
