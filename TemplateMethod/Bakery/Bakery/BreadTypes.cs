using System;

namespace Bakery {
	class Borodino : Bread {
		public override void ApplyIngedients() {
			Console.WriteLine("Gathering ingredients for Borodino bread.");
		}

		public override void Bake() {
			Console.WriteLine("Baking Borodino bread.");
		}
	}

	class Sourdough : Bread {
		public override void ApplyIngedients() {
			Console.WriteLine("Gathering ingredients for Sourdough bread.");
		}

		public override void Bake() {
			Console.WriteLine("Baking the Sourdough bread.");
		}
	}
}
