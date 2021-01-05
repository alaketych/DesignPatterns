using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance {
	class Program {
		static void Main() {
			var vacancies = new List<Client> {
				new ClientHighRateVacancy(),
			};
		}
	}
}
