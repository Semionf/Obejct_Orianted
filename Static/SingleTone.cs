using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class SingleTone
    {
		// static instance of a class, in this case we can only make 1 instance of this class and use all functions or properties with it.
		private static SingleTone _Instance;

		public SingleTone Instance
		{
			get { if (_Instance == null) _Instance = new SingleTone(); return _Instance; }
			set { _Instance = value; }
		}

	}
}
