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
		public Product(String VendorCode, Guid ProductId)
		{
			this.VendorCode = VendorCode;
			this.ProductId = ProductId;
		}

		public Product() { }

		public Guid ProductId
		{
			get
			{
				return Guid.Parse(this.RowKey.Remove(0, 9));
			}
			set
			{
				this.RowKey = "Product__" + value.ToString();
			}
		}

		public String VendorCode
		{
			get
			{
				return this.PartitionKey;
			}
			set
			{
				this.PartitionKey = value;
			}
		}
			
		public String Name { get; set; }
		public String Description { get; set; }
		public Double Price { get; set; }
	}
}
