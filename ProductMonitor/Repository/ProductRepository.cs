﻿using Microsoft.WindowsAzure.Storage.Table;
using ProductManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public async Task<Product> GetProductAsync(String vendorCode, Guid productId)
		{
			TableOperation op = TableOperation.Retrieve<Product>(vendorCode, String.Format("Product__{0}", productId));

			TableResult result = await GetVendorTable().ExecuteAsync(op);
			return (Product)result.Result;
		}
	}
}
