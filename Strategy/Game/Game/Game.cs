namespace Game {
	class Game {
		public ILevel Level { get; set; }

		public Game() { }
		public Game(ILevel Level) {
			this.Level = Level;
		}

		public void SetLevel(ILevel Level) {
			this.Level = Level;
		}
	}
}
