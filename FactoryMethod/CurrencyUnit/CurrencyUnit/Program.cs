using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyUnit {
	class Bank {
		static void Main() {
			var createBanknote = new List<Machine>{
				new CreateEUR(),
				new CreateUSD(),
			};

			var storage = new List<Banknote>();

			foreach (var item in createBanknote) {
				var newCoupure = item.PrintBanknote(5);
				storage.AddRange(newCoupure);
			}

			foreach (var item in storage) {
				Console.WriteLine(item);
			}
		}
	}
}
