namespace ShoesFactory {
	class NikeFactory : IShoesFactory {
		public ISports ManufactureSports() {
			return new NikeKyrie();
		}

		public IBoots ManufactureBoots() {
			return new NikeLunarForce();
		}

		public ISlippers ManufactureSlippers() {
			return new NikeBenassi();
		}

		public ISneakers ManufactureSneakers() {
			return new NikeAirForce();
		}
	}

	class AdidasFactory : IShoesFactory {
		public ISports ManufactureSports() {
			return new NikeKyrie();
		}

		public IBoots ManufactureBoots() {
			return new NikeLunarForce();
		}

		public ISlippers ManufactureSlippers() {
			return new NikeBenassi();
		}

		public ISneakers ManufactureSneakers() {
			return new NikeAirForce();
		}
	}
}
