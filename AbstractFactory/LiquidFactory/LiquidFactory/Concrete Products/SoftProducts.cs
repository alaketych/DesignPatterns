namespace LiquidFactory {
	class Sprite : ILiquid {
		public string Name { get; set; }
		public double Capacity { get; set; }
		public double Fluidity { get; set; }

		public Sprite(string Name, double Capacity, double Fluidity) {
			this.Name = Name;
			this.Capacity = Capacity;
			this.Fluidity = Fluidity;
		}
	}

	class CocaCola : ILiquid {
		public string Name { get; set; }
		public double Capacity { get; set; }
		public double Fluidity { get; set; }

		public CocaCola(string Name, double Capacity, double Fluidity) {
			this.Name = Name;
			this.Capacity = Capacity;
			this.Fluidity = Fluidity;
		}
	}

	class Fanta : ILiquid {
		public string Name { get; set; }
		public double Capacity { get; set; }
		public double Fluidity { get; set; }

		public Fanta(string Name, double Capacity, double Fluidity) {
			this.Name = Name;
			this.Capacity = Capacity;
			this.Fluidity = Fluidity;
		}
	}

	class Pepsi : ILiquid {
		public string Name { get; set; }
		public double Capacity { get; set; }
		public double Fluidity { get; set; }

		public Pepsi(string Name, double Capacity, double Fluidity) {
			this.Name = Name;
			this.Capacity = Capacity;
			this.Fluidity = Fluidity;
		}
	}
}
