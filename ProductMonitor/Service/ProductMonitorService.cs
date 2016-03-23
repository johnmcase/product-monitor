using ProductMonitor.Domain;
using ProductMonitor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Service
{
	public class ProductMonitorService : IProductMonitorService
	{
		private IProductUpdateRepository updateRepository;
		private IProductRepository productReposiitory;
		private IVendorRepository vendorRepository;

		public ProductMonitorService(IProductUpdateRepository updateRepository, IProductRepository productReposiitory, IVendorRepository vendorRepository)
		{
			this.updateRepository = updateRepository;
			this.productReposiitory = productReposiitory;
			this.vendorRepository = vendorRepository;
		}

		public async Task<IEnumerable<Vendor>> GetVendorsAsync()
		{
			return await this.vendorRepository.GetVendorsAsync();
		}

		public async Task AddUpdatedProductsAsync(IList<Vendor> vendors, int maxUpdateCount)
		{
			var updates = await this.updateRepository.GetPendingProductUpdatesAsync();
			foreach (var update in updates)
			{
				var product = await this.productReposiitory.GetProductAsync(update.VendorCode, update.ProductId);
				var vendor = vendors.Where(v => v.Code.Equals(update.VendorCode)).FirstOrDefault();
				if (vendor != null)
				{
					vendor.Updates.Insert(0, product);

					while (vendor.Updates.Count > maxUpdateCount)
					{
						vendor.Updates.RemoveAt(maxUpdateCount);
					}
				}
			}
		}
	}
}
