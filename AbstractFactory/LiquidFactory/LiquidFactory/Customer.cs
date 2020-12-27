namespace LiquidFactory {
	class Customer {
		string _Name, _Surname;

		public ILiquid Liquid { get; set; }
		public ICompany Company { get; set; }

		public string Name {
			get { return _Name; }
			set { _Name = value; }
		}

		public string Surname {
			get { return _Surname; }
			set { _Surname = value; }
		}

		public Customer(string Name, string Surname, ILiquidFactory factory) {
			this.Name = Name;
			this.Surname = Surname;

			Liquid = factory.GetLiquidName();
			Company = factory.GetCompanyName();
		}

		public string Purchase() {
			return $"{Liquid.GetType().Name} - " + $"{Company.GetType().Name}";
		}
	}
}
