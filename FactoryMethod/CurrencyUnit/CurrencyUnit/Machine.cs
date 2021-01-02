namespace CurrencyUnit {
	abstract class Machine {
		string _Name;

		public string Name {
			get { return _Name; }
			set { _Name = value; }
		}

		public Machine(string Name) {
			this.Name = Name;
		}

		public abstract Banknote[] PrintBanknote(int page);
	}
}
