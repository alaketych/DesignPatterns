using System;

namespace Game {
	class Easy : ILevel {
		public void SetLevel() {
			Console.WriteLine("Easy level.");
		}
	}

	class Medium : ILevel {
		public void SetLevel() {
			Console.WriteLine("Medium level.");
		}
	}

	class Hard : ILevel {
		public void SetLevel() {
			Console.WriteLine("Hard level.");
		}
	}
}
