﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProductManager.Domain
{
	public class Vendor
	{
		public Vendor()
		{
			this.Updates = new BindingList<Product>();
		}

		public String Code { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public IList<Product> Updates { get; private set; }
	}
}
