namespace CurrencyUnit {
	abstract class Banknote {
		string _Abbreviation, _Name, _Symbol;

		public string Abbreviation {
			get { return _Abbreviation; }
			set { _Abbreviation = value; }
		}

		public string Name {
			get { return _Name; }
			set { _Name = value; }
		}

		public string Symbol {
			get { return _Symbol; }
			set { _Symbol = value; }
		}

		public Banknote(string Name, string Symbol, string Abbreviation) {
			this.Abbreviation = Abbreviation;
			this.Name = Name;
			this.Symbol = Symbol;
		}
	}
}
