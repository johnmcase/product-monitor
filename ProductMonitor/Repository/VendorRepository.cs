using Microsoft.WindowsAzure.Storage.Table;
using ProductManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	public class VendorRepository : BaseRepository, IVendorRepository
	{
		private const String vendorPartition = "Vendor";

		public async Task<IEnumerable<ProductManager.Domain.Vendor>> GetVendorsAsync()
		{
			TableQuery<VendorEntity> query = new TableQuery<VendorEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, vendorPartition));

			var results = await GetVendorTable().ExecuteQueryAsync(query);
			return results.Select(x => x.AsVendor());
		}

		private class VendorEntity : TableEntity
		{
			public VendorEntity(String Code)
			{
				this.PartitionKey = vendorPartition;
				this.RowKey = Code;

				this.Code = Code;
			}

			public VendorEntity()
			{
				this.PartitionKey = vendorPartition;
			}

			public String Code { get; set; }
			public String Name { get; set; }
			public String Description { get; set; }

			public Vendor AsVendor()
			{
				return new Vendor()
				{
					Code = this.Code,
					Name = this.Name,
					Description = this.Description
				};
			}
		}
	}
}
