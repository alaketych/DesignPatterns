using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory {
	class Program {
		static void Main() {
			Customer customerAdidas, customerNike;

			customerNike = new Customer(new NikeFactory());
			customerAdidas = new Customer(new AdidasFactory());

			Console.WriteLine($"{customerNike.DisplaySlippersModel()}");
		}
	}
}
