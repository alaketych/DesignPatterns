namespace ShoesFactory {
	class Customer {
		IBoots _Boots;
		ISports _SportShoes;
		ISneakers _Sneakers;
		ISlippers _Slippers;

		public IBoots Boots { 
			get { return _Boots; } 
			set { _Boots = value; } 
		}

		public ISports SportShoes {
			get { return _SportShoes; }
			set { _SportShoes = value; }
		}

		public ISneakers Sneakers {
			get { return _Sneakers; }
			set { _Sneakers = value; }
		}

		public ISlippers Slippers {
			get { return _Slippers; }
			set { _Slippers = value; }
		}

		public Customer(IShoesFactory factory) {
			Boots = factory.ManufactureBoots();
			SportShoes = factory.ManufactureSports();
			Sneakers = factory.ManufactureSneakers();
			Slippers = factory.ManufactureSlippers();
		}

		public string DisplayBootsModel() {
			return Boots.Model();
		}

		public string DisplaySportsModel() {
			return SportShoes.Model();
		}

		public string DisplaySneakersModel() {
			return Sneakers.Model();
		}

		public string DisplaySlippersModel() {
			return Slippers.Model();
		}
	}
}
