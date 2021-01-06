using System.Collections.Generic;

namespace Pizzaria {
	class Pizza {
		public string Label { get; set; }
		public string Dough { get; set; }
		public string Salt { get; set; }
		public string Flavor { get; set; }
		public List<string> Sauce { get; set; }
		public List<string> Cheese { get; set; }
		public List<string> Vegetables { get; set; }
	}
}
