using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrianted
{
    public class Son : Father
    {
        public string Class { get; set; }
        
        public Son(string Class ,int Age, int Height, int Id, string Name) : base(Age, Height, Id, Name)
        {
            this.Class = Class;
        }
    }
}
