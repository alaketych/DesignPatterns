namespace Developer {
	class Building {
		public Walls Walls { get; set; }
		public Warming Warming { get; set; }
		public Heating Heating { get; set; }

		public short FlorsQuantity { get; set; }
		public short FlatsQuantity { get; set; }
		public short EntrancesQuantity { get; set; }
	}
}
