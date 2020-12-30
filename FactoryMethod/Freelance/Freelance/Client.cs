namespace Freelance {
	abstract class Client {
		public string Name { get; protected set; }
		public string Surname { get; protected set; }
		public string Country { get; protected set; }

		public Client(string Name, string Surname, string Country) {
			this.Name = Name;
			this.Surname = Surname;
			this.Country = Country;
		}

		public abstract Vacancy[] AnnounceVacancy();
	}
}
