namespace Vehicles {
	class BMW5series : Vehicle {
		public BMW5series(string Case, string Engine, string Transmission, string BoardPanel, string Mark = "BMW", string Model = "5 Series", string Class = "E", string Lights = "LED")
			: base(Mark, Class, Model, Case, Engine, Transmission, BoardPanel, Lights) { }

		public override int DisplayCost() {
			return 1566843;
		}
	}

	class Ford : Vehicle {
		public Ford(string Case, string Engine, string Transmission, string BoardPanel, string Mark, string Model, string Class, string Lights)
			: base(Mark, Class, Model, Case, Engine, Transmission, BoardPanel, Lights) { }

		public override int DisplayCost() {
			return 790345;
		}
	}
}
