using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationPC
{
	public abstract class Component
	{
		protected string Firm { get; set; }
		protected string Model { get; set; }

		public Component(string Firm, string Model)
		{
			this.Firm = Firm;
			this.Model = Model;
		}

		public virtual void Add(Component component)
		{
		}

		public virtual void Delete(Component component)
		{
		}

		public virtual void DisplayPrice()
		{
		}
	}
}
