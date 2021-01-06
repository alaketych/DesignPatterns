namespace Developer {
	interface IDesignable {
		void DesignWalls(Walls type);

		void DesignHeating(Heating type);
		void DesignWarming(Warming type);

		void DesignFlors();
		void DesignFlats();
		void DesignEntrances();

		Building Display();
	}
}
