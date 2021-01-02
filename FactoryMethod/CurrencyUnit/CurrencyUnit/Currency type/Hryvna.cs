namespace CurrencyUnit {
	class Hryvna : Banknote {
		int _Denomination;

		public int Denomination {
			get { return _Denomination; }
			set { _Denomination = value; }
		}

		public Hryvna(int Denomination) : base("Ukrainian Hryvnia", "₴", "UAH") {
			this.Denomination = Denomination;
		}

		public override string ToString() {
			return $"{Name} - {Abbreviation} - {Denomination}{Symbol}";
		}
	}
}
