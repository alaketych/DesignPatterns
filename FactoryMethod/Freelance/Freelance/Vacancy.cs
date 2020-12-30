namespace Freelance {
	abstract class Vacancy {
		public string Label { get; protected set; }
		public double HourlyRate { get; protected set; }

		public Vacancy(string Label, double HourlyRate) {
			this.Label = Label;
			this.HourlyRate = HourlyRate;
		}
	}
}
