namespace Developer {
	class Econom : IDesignable {
		Building EconomClassBuilding = new Building();

		public void DesignWalls(Walls type) {
			EconomClassBuilding.Walls = Walls.Frame;
		}

		public void DesignHeating(Heating type) {
			EconomClassBuilding.Heating = Heating.Centralized;
		}

		public void DesignWarming(Warming type) {
			EconomClassBuilding.Warming = Warming.Styrofoam;
		}

		public void DesignFlors() {
			EconomClassBuilding.FlorsQuantity = 24;
		}

		public void DesignFlats() {
			EconomClassBuilding.FlatsQuantity = 1560;
		}

		public void DesignEntrances() {
			EconomClassBuilding.EntrancesQuantity = 3;
		}

		public Building Display() {
			return EconomClassBuilding;
		}
	}

	class Business : IDesignable {
		Building BusinessClassBuilding = new Building();

		public void DesignWalls(Walls type) {
			BusinessClassBuilding.Walls = Walls.Brick;
		}

		public void DesignHeating(Heating type) {
			BusinessClassBuilding.Heating = Heating.Autonomously;
		}

		public void DesignWarming(Warming type) {
			BusinessClassBuilding.Warming = Warming.MineralWool;
		}

		public void DesignFlors() {
			BusinessClassBuilding.FlorsQuantity = 12;
		}

		public void DesignFlats() {
			BusinessClassBuilding.FlatsQuantity = 120;
		}

		public void DesignEntrances() {
			BusinessClassBuilding.EntrancesQuantity = 5;
		}

		public Building Display() {
			return BusinessClassBuilding;
		}
	}
}
