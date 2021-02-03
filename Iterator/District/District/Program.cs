using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace District {
	interface IDistrict {
		LCDIterator CreateIterator();
	}

	interface ILCDIterator {
		LCD First();
		LCD Next();
		LCD CurrentLCD();
	}

	class LCD {
		public string Name { get; set; }
		public int BuildingQnty { get; set; }

		public LCD(string Name, int BuildingQnty) {
			this.Name = Name;
			this.BuildingQnty = BuildingQnty;
		}
	}

	class LCDIterator : ILCDIterator {
		int current = 0, step = 1;
		District District { get; set; }
		public int Step { 
			get { return step; }
			set { step = value; }
		}

		public LCDIterator(District District) {
			this.District = District;
		}

		public LCD First() {
			return District[current] as LCD;
		}

		public LCD Next() {
			current += step;
			return District[current] as LCD;
		}

		public LCD CurrentLCD() {

			current = 0;
			return District[current] as LCD;
		}
	}

	class District : IDistrict {
		List<LCD> buildings = new List<LCD>(); 

		public LCDIterator CreateIterator() {
			return new LCDIterator(this);
		}	

		public int Count { get { return buildings.Count; } }
		public LCD this[int index] {
			get { return buildings[index]; }
			set { buildings.Add(value); }
		}
	}

	class Program {
		static void Main() {
			District vinogradar = new District();

			vinogradar[0] = new LCD("varshavsky plus", 10);
			vinogradar[0] = new LCD("varshavsky 1", 20);
			vinogradar[0] = new LCD("varshavsky 2", 15);

			LCDIterator iterator = vinogradar.CreateIterator();

			iterator.Step = 3;

			for (LCD item = iterator.First(); ; iterator.Next()) {
				Console.WriteLine(item.Name);
			}
		}
	}
}
