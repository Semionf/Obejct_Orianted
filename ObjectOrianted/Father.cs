using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrianted
{
    public class Father: Person
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public Father(int Age, int Height, int Id, string Name) : base(Id,Name) { this.Age = Age; this.Height = Height; }
    }
}
