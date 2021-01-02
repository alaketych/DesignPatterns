namespace CurrencyUnit {
	class Euro : Banknote {
		int _Denomination;

		public int Denomination {
			get { return _Denomination; }
			set { _Denomination = value; }
		}

		public Euro(int Denomination) : base("Euro", "€", "EUR") {
			this.Denomination = Denomination;
		}

		public override string ToString() {
			return $"{Name} - {Abbreviation} - {Denomination}{Symbol}";
		}
	}
}
