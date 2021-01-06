namespace Pizzaria {
	class Pizzeria {
		IPreparable _Preparable;
		public IPreparable Preparable {
			get { return _Preparable; }
			set { _Preparable = value; }
		}

		public void MakeDough() {
			this.Preparable.PrepareDough();
		}

		public void Apply() {
			this.Preparable.AddSauce();
			this.Preparable.AddFlavor();
			this.Preparable.ApplyCheese();
			this.Preparable.ApplyIngredients();
		}
	}
}
