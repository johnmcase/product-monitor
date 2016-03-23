using ProductMonitor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Service
{
	public interface IProductMonitorService
	{
		Task<IEnumerable<Vendor>> GetVendorsAsync();

		Task AddUpdatedProductsAsync(IList<Vendor> vendors, int maxUpdateCount);
	}
}
