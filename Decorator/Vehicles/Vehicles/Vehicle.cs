namespace Vehicles {
	abstract class Vehicle {
		public string Mark { get; set; }
		public string Class { get; set; }
		public string Model { get; set; }
		public string Case { get; set; }

		public string Engine { get; set; }
		public string Transmision { get; set; }
		public string BoardPanel { get; set; }
		public string Lights { get; set; }

		public Vehicle(string Mark, string Class, string Model, string Case, string Engine, string Transmission, string BoardPanel, string Lights) {
			this.Mark = Mark;
			this.Class = Class;
			this.Model = Model;
			this.Case = Case;
			this.Engine = Engine;
			this.Transmision = Transmission;
			this.BoardPanel = BoardPanel;
			this.Lights = Lights;
		}

		public abstract int DisplayCost();
	}
}
