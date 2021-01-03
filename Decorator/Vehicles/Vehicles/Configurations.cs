namespace Vehicles {
	class MSport : VehicleDecorator {
		public MSport(Vehicle Vehicle)
			: base(Vehicle, "BMW", "E", "530i", "G30", "V8", "Mechanic", "Electronic", "LED") { }

		public override int DisplayCost() {
			return 2164274;
		}
	}

	class MSportComfort : VehicleDecorator {
		public MSportComfort(Vehicle Vehicle)
			: base(Vehicle, "BMW", "E", "540i xDrive", "G40", "V8", "Mechanic", "Electronic", "LED") { }

		public override int DisplayCost() {
			return 2401658;
		}
	}

	class SpecialEdition : VehicleDecorator {
		public SpecialEdition(Vehicle Vehicle)
			: base(Vehicle, "BMW", "E", "520i", "G30", "V8", "Mechanic", "Electronic", "LED") { }

		public override int DisplayCost() {
			return 1566843;
		}
	}
}
