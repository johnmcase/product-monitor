using System;

namespace ProductMonitor.Domain
{
	public class Product
	{
		public Guid ProductId { get; set; }
		public String VendorCode { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public Double Price { get; set; }
	}
}
