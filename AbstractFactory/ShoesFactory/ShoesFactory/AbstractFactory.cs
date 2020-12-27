namespace ShoesFactory {
	interface IShoesFactory {
		ISports ManufactureSports();
		IBoots ManufactureBoots();
		ISlippers ManufactureSlippers();
		ISneakers ManufactureSneakers();
	}
}