using ProductManager.Domain;
using System;
using System.ComponentModel;

namespace ProductMonitor.Forms
{
	public class VendorViewObject
	{
		public String Code { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }

		public BindingList<Product> Updates { get; set; }
	}
}
