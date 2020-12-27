namespace LiquidFactory {
	class SpriteFactory : ILiquidFactory {
		public ILiquid GetLiquidName() {
			return new Sprite("Sprite", 0.5, 0.7);
		}

		public ICompany GetCompanyName() {
			return new CocaColaCompany("The Coca-Cola Company");
		}
	}

	class FantaFactory : ILiquidFactory {
		public ILiquid GetLiquidName() {
			return new Fanta("Fanta", 0.5, 0.7);
		}

		public ICompany GetCompanyName() {
			return new CocaColaCompany("The Coca-Cola Company");
		}
	}

	class CocaColaFactory : ILiquidFactory {
		public ILiquid GetLiquidName() {
			return new Fanta("Coca Cola", 0.5, 0.7);
		}

		public ICompany GetCompanyName() {
			return new CocaColaCompany("The Coca-Cola Company");
		}
	}

	class PepsiFactory : ILiquidFactory {
		public ILiquid GetLiquidName() {
			return new Fanta("Pepsi", 0.5, 0.7);
		}

		public ICompany GetCompanyName() {
			return new CocaColaCompany("The Coca-Cola Company");
		}
	}
}
