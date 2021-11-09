using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationPC
{
	public class Case : Component
	{
		private List<Component> hardwares = new List<Component>();

		public Case(string Firm, string Model) : base(Firm, Model)
		{ 
		
		}

		public override void Add(Component component)
		{
			hardwares.Add(component);
		}

		public override void Delete(Component component)
		{
			hardwares.Remove(component);
		}

		public override void DisplayPrice()
		{
			foreach (var component in hardwares)
			{
				component.DisplayPrice();
			}
		}
	}
}
