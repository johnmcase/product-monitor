using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Domain
{
	public class ProductUpdate
	{
		public String VendorCode { get; set; }
		public Guid ProductId { get; set; }
	}
}
