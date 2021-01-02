namespace CurrencyUnit {
	class Dollar : Banknote {
		int _Denomination;

		public int Denomination {
			get { return _Denomination; }
			set { _Denomination = value; }
		}

		public Dollar(int Denomination) : base("American dollar", "$", "USD") {
			this.Denomination = Denomination;
		}

		public override string ToString() {
			return $"{Name} - {Abbreviation} - {Denomination}{Symbol}";
		}
	}
}
