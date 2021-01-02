using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyUnit {
	class CreateEUR : Machine {
		int _Denomination;
		int[] currencyDenomination = { 5, 10, 20, 50, 100, 200 };

		public int Denomination {
			get { return _Denomination; }
			set { _Denomination = value; }
		}

		public CreateEUR(int Denomination = 50) : base("Euro banking machine") {
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
				var coupure = new Euro(this.Denomination);

				storage.Add(coupure);
			}

			return storage.ToArray();
		}
	}
}
