using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain
{
	public class Vendor : TableEntity
	{
		public Vendor(String Code)
		{
			this.PartitionKey = "Vendor";
			this.RowKey = Code;

			this.Code = Code;
		}

		public Vendor()
		{
			this.PartitionKey = "Vendor";
		}

		public String Code { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
	}
}
