using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
	class Program {
		static void Main() {
			var Mafia = new Pizzeria();
			var caesar = new Caesar();

			Mafia.Preparable = caesar;
			Mafia.MakeDough();
			Mafia.Apply();
		}
	}
}
