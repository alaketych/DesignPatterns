using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites {
	interface IWebsite {
		IWebsite Clone();
		void Render();
	}

	abstract class WebsitePrototype : IWebsite {
		public abstract IWebsite Clone();
		public abstract void Render();
	}

	class Website : WebsitePrototype {
		public string URL { get; set; }
		public string WebAPI { get; set; }

		public Website(string URL, string WebAPI) : base() {
			this.URL = URL;
			this.WebAPI = WebAPI;
		}

		public override IWebsite Clone() {
			return new Website(URL, WebAPI);
		}

		public override void Render() {
			Console.WriteLine("{0} has {1} api", URL, WebAPI);
		}
	}

	class WWW {
		Dictionary<string, Website> searchSystem = new Dictionary<string, Website>();

		public Website this[string name] {
			get { return searchSystem[name]; }
			set { searchSystem.Add(name, value); }
		}
	}

	class Program {
		static void Main() {
			WWW searchSystem = new WWW();

			searchSystem["msdn"] = new Website("docs.microsoft.com", "REST");

			Website mdn = searchSystem["msdn"].Clone() as Website;

			Console.WriteLine(mdn);
		}
	}
}
