namespace Vehicles {
	abstract class VehicleDecorator : Vehicle {
		protected Vehicle Vehicle;

		public VehicleDecorator(Vehicle Vehicle, string Mark, string Class, string Model, string Case, string Engine, string Transmission, string BoardPanel, string Lights)
			: base(Mark, Class, Model, Case, Engine, Transmission, BoardPanel, Lights) {
			this.Vehicle = Vehicle;
		}
	}
}
