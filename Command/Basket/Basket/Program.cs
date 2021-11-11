using System;
using System.Collections.Generic;

namespace Basket
{
	class Program
	{
		static void Main(string[] args)
		{
			var basketOptions = new BasketShopping();
			var basket = new Basket();

			Execute(basket, basketOptions, new BasketOptions(basket));
		}

		private static void Execute(Basket basket, BasketShopping basketShopping, ICommand command)
		{
			basketShopping.SetCommand(command);
			basketShopping.Execute();
		}
	}
}
