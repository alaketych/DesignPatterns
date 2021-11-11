using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
	public class Basket
	{
		public string Id { get; set; }
		public List<string> Products { get; set; }

		public void Display() => Products.ToArray();
		public void Checkout() => Console.WriteLine("Checkout.");
		public void ContinueShopping() => Console.WriteLine("Shopping...");
	}

	public class BasketShopping : ICommand
	{
		ICommand command;
		List<ICommand> commands;

		public BasketShopping()
		{
			commands = new List<ICommand>();
		}

		public void SetCommand(ICommand command) => this.command = command;

		public void Execute()
		{
			commands.Add(command);
			command.Execute();
		}
	}

	public class BasketOptions : ICommand
	{
		Basket basket;

		public BasketOptions(Basket basket)
		{
			this.basket = basket;
		}

		public void Execute()
		{

		}
	}
}
