namespace Freelance {
	class LowRateVacancy : Vacancy {
		public LowRateVacancy(string Label, double HourlyRate) : base(Label, HourlyRate) {
			this.Label = Label;
			this.HourlyRate = HourlyRate;
		}
	}

	class HighRateVacancy : Vacancy {
		public HighRateVacancy(string Label, double HourlyRate) : base(Label, HourlyRate) {
			this.Label = Label;
			this.HourlyRate = HourlyRate;
		}
	}
}
