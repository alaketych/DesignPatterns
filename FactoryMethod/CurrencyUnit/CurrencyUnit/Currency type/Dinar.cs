namespace CurrencyUnit {
	class Dinar : Banknote {
		int _Denomination;

		public int Denomination {
			get { return _Denomination; }
			set { _Denomination = value; }
		}

		public Dinar(int Denomination) : base("Serbian dinar", "₴", "RSD") {
			this.Denomination = Denomination;
		}

		public override string ToString() {
			return $"{Name} - {Abbreviation} - {Denomination}{Symbol}";
		}
	}
}
