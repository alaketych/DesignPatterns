using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidFactory {
	class Program {
		static void Main() {
			Customer AlexandrLaketych;
			AlexandrLaketych = new Customer("Alexandr", "Laketych", new SpriteFactory());
			AlexandrLaketych = new Customer("Alexandr", "Laketych", new FantaFactory());
			AlexandrLaketych = new Customer("Alexandr", "Laketych", new PepsiFactory());
		}
	}
}
