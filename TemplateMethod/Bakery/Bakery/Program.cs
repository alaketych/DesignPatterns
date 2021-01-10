using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery {
	class Program {
		static void Main() {
			Borodino borodinoBread = new Borodino();
			borodinoBread.Make();
			borodinoBread.Slice();

			Sourdough sourdoughBread = new Sourdough();
			sourdoughBread.Make();
		}
	}
}
