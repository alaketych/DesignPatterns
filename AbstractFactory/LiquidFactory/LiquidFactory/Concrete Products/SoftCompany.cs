namespace LiquidFactory {
	class CocaColaCompany : ICompany {
		public string Name { get; set; }

		public CocaColaCompany(string Name) {
			this.Name = Name;
		}
	}

	class PepsiCompany : ICompany {
		public string Name { get; set; }

		public CocaColaCompany(string Name) {
			this.Name = Name;
		}
	}
}
