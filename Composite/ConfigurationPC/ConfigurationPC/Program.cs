using System;

namespace ConfigurationPC
{
	class Program
	{
		static void Main(string[] args)
		{
			Component HyperXRAM2144Hz = new RAM("HyperX", "UE3241242144");
			Component AeroCoolCase = new Case("Aero Cool", "Super Light X1");

			AeroCoolCase.Add(HyperXRAM2144Hz);
			AeroCoolCase.DisplayPrice();
		}
	}
}
