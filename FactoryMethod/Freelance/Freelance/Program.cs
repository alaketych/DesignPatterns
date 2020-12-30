using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance {
	class ClientHighRateVacancy : Client {
		public ClientHighRateVacancy() : base("", "", "") { }
		public ClientHighRateVacancy(string Name, string Surname, string County) : base("","","") { }

		public override Vacancy[] AnnounceVacancy() {
			var vacancyQuantity = new List<Vacancy>();

			for (int counter = 0; counter < 5; counter++) {
				var vacancy = new HighRateVacancy("High rate", 45.0);
				vacancyQuantity.Add(vacancy);
			}

			return vacancyQuantity.ToArray();
		}
	}

	class Program {
		static void Main() {
			var vacancies = new List<Client> {
				new ClientHighRateVacancy(),
			};
		}
	}
}
