﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using VendingMachine.Items;
using VendingMachine.VendingMachine;

namespace VendingMachine.UI
{
    public class DisplayItems
    {
		public DisplayItems(Dictionary<string, Stack<Item>> slots, CashCounter currentCounter, Queue<Item> purchases, Vendor machine)
		{
			Console.Clear();

			foreach (var kvp in slots)
			{
				if (kvp.Value.Count > 0)
				{
					Console.WriteLine($"{kvp.Key} {kvp.Value.Peek().Name}".PadRight(25) + $"{kvp.Value.Peek().Cost:c}");
				}
				else
				{
					Console.WriteLine("SOLD OUT!!");
				}
			}

			Console.WriteLine("\nPress Enter to continue.\n");
			Console.ReadLine();
			Console.Clear();
			Menu main = new Menu(slots, currentCounter, purchases, machine);
		}

	}
}
