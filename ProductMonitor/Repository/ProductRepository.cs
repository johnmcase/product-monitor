using Microsoft.WindowsAzure.Storage.Table;
using ProductManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	class ProductRepository : BaseRepository, IProductRepository
	{
		public async Task<Product> GetProductAsync(String vendorCode, String productId)
		{
			TableOperation op = TableOperation.Retrieve<Product>(vendorCode, String.Format("Product_{}", productId));

			TableResult result = await GetVendorTable().ExecuteAsync(op);
			return (Product)result.Result;
		}
	}
}
