using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyUnit {
	class CreateUSD : Machine {
		int _Denomination;
		int[] currencyDenomination = { 1, 2, 5, 10, 20, 50, 100 };

		public int Denomination {
			get { return _Denomination; }
			set { _Denomination = value; }
		}

		public CreateUSD(int Denomination = 100) : base("USD banking machine") {
			if (this.currencyDenomination.Contains(Denomination)) {
				this.Denomination = Denomination;
			}
			else {
				throw new ArgumentException("Incorrect currency denomination.", nameof(Denomination));
			}
		}

		public override Banknote[] PrintBanknote(int pages) {
			var storage = new List<Banknote>();

			for (int counter = 0; counter < pages; counter++) {
				var coupure = new Dollar(this.Denomination);

				storage.Add(coupure);
			}

			return storage.ToArray();
		}
	}
}
