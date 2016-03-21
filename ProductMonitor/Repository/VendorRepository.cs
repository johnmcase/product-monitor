using Microsoft.WindowsAzure.Storage.Table;
using ProductManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	public class VendorRepository : BaseRepository, IVendorRepository
	{
		private String vendorPartition = "Vendor";

		public async Task<IEnumerable<ProductManager.Domain.Vendor>> GetVendorsAsync()
		{
			TableQuery<Vendor> query = new TableQuery<Vendor>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, vendorPartition));

			return await GetVendorTable().ExecuteQueryAsync(query);
		}
	}
}
