namespace Developer {
	class Developer {
		public IDesignable Designable { get; set; }

		public Developer(IDesignable Designable) {
			this.Designable = Designable;
		}

		public void Build() {
			this.Designable.DesignWalls(Walls.Brick);
			this.Designable.DesignHeating(Heating.Centralized);
			this.Designable.DesignWarming(Warming.MineralWool);
			this.Designable.DesignFlors();
			this.Designable.DesignFlats();
			this.Designable.DesignEntrances();
		}

		public Building Display() {
			return this.Designable.Display();
		}
	}
}
