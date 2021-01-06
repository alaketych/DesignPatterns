namespace Pizzaria {
	class Caesar : IPreparable {
		Pizza Pizza = new Pizza();

		public void PrepareDough() {
			this.Pizza.Dough = "yeast thin";
		}

		public void ApplyIngredients() {
			this.Pizza.Vegetables = new List<string> { "cherry tomatoes" };
		}

		public void ApplyCheese() {
			this.Pizza.Cheese = new List<string> { "cheddar", "parmesan", "mozzarella" };
		}

		public void AddSauce() {
			this.Pizza.Sauce = new List<string> { "cream", "caesar" };
		}

		public void AddFlavor() {
			this.Pizza.Flavor = "fresh iceberg lettuce leaves";
		}
	}
}
