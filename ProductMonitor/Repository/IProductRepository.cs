using ProductManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	interface IProductRepository
	{
		Task<Product> GetProductAsync(String vendorCode, Guid productId);
	}
}
