﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace ProductManager.Domain
{
	public class Vendor
	{
		public String Code { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }

		//BindingList<Product> _updates = new BindingList<Product>();
		//public BindingList<Product> Updates
		//{
			//get
			//{
			//	var ret = new BindingList<Product>();
			//	ret.RaiseListChangedEvents = true;
			//	ret.Add(new Product()
			//	{
			//		VendorCode = "FAKE 1 - " + this.Code,
			//		ProductId = Guid.NewGuid(),
			//		Description = "Desc 1 - " + this.Code,
			//		Price = 1.11,
			//		Name = "Name 1"
			//	});
			//	ret.Add(new Product()
			//	{
			//		VendorCode = "FAKE 2 - " + this.Code,
			//		ProductId = Guid.NewGuid(),
			//		Description = "Desc 2 - " + this.Code,
			//		Price = 2.22,
			//		Name = "Name 2"
			//	});
			//	ret.Add(new Product()
			//	{
			//		VendorCode = "FAKE 3 - " + this.Code,
			//		ProductId = Guid.NewGuid(),
			//		Description = "Desc 3 - " + this.Code,
			//		Price = 3.33,
			//		Name = "Name 3"
			//	});
			//	return ret;
			//}
			//private set {

			//}
		//	get;
		//	private set;
		//}
		
		BindingList<Product> _updates = new BindingList<Product>();
		public BindingList<Product> Updates
		{
			get
			{
				return _updates;
			}
			set
			{
				_updates = value;
			}
		}

		public void Blah(object o)
		{
			Console.Out.WriteLine("Running Timer task!");

			this.Updates.Add(new Product()
			{
				VendorCode = "ADDED",
				ProductId = Guid.NewGuid()

			});
			Console.Out.WriteLine(String.Format("Size of list = {0}", this.Updates.Count));

			var x = this.Updates;
			x.Add(new Product()
			{
				VendorCode = "ADDED",
				ProductId = Guid.NewGuid()
			});
			Console.Out.WriteLine(String.Format("Size of list X = {0}", x.Count));
		}

		Timer timer;
		public Vendor()
		{
			// kick off updating job...

			timer = new Timer(Blah);
			timer.Change(1000, 1000);
		}
	}
}
