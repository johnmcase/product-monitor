using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain
{
	public class Product : TableEntity
	{
		public Product(String VendorCode, String Id)
		{
			this.PartitionKey = VendorCode;
			this.RowKey = Id;

			this.VendorCode = VendorCode;
			this.Id = Id;
		}

		public Product() { }

		public String Id { get; set; }
		public String VendorCode { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public String Price { get; set; }
	}
}
