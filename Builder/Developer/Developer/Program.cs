using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer {
	class Program {
		static void Main() {
			var StolicaGroup = new Developer(new Business());
				StolicaGroup.Build();
				StolicaGroup.Display();

			var Halzhytlobud = new Developer(new Econom());
				Halzhytlobud.Build();
				Halzhytlobud.Display();
		}
	}
}
