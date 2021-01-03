using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles {
	class Program {
		Vehicle i530 = new BMW5series("G30", "V8", "Mechanic", "Electronic", "LED");
		i530 = new MSport(i530);
	}
}
