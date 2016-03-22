﻿using System;
using System.Collections.Generic;

namespace ProductManager.Domain
{
	public class Vendor
	{
		public String Code { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }

		public IEnumerable<Product> Updates
		{
			get
			{
				var ret = new List<Product>();
				ret.Add(new Product()
				{
					VendorCode = "FAKE 1 - " + this.Code,
					ProductId = Guid.NewGuid(),
					Description = "Desc 1 - " + this.Code,
					Price = 1.11,
					Name = "Name 1"
				});
				ret.Add(new Product()
				{
					VendorCode = "FAKE 2 - " + this.Code,
					ProductId = Guid.NewGuid(),
					Description = "Desc 2 - " + this.Code,
					Price = 2.22,
					Name = "Name 2"
				});
				ret.Add(new Product()
				{
					VendorCode = "FAKE 3 - " + this.Code,
					ProductId = Guid.NewGuid(),
					Description = "Desc 3 - " + this.Code,
					Price = 3.33,
					Name = "Name 3"
				});
				return ret;
			}
			private set {
				
			}
		}
	}
}
