using System;

namespace ProductMonitor.Domain
{
	public class ProductUpdate
	{
		public String VendorCode { get; set; }
		public Guid ProductId { get; set; }
	}
}
