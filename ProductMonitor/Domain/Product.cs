using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain
{
	public class Product
	{
		public Guid Id { get; set; }
		public String VendorCode { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public String Price { get; set; }
	}
}
