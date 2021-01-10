using System;

namespace Bakery {
	abstract class Bread {
		public abstract void ApplyIngedients();
		public abstract void Bake();
		public virtual void Slice() {
			Console.WriteLine("{0} bread is sliced", GetType().Name);
		}

		public void Make() {
			ApplyIngedients();
			Bake();
		}
	}
}
