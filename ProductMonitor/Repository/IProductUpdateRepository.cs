using ProductMonitor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	public interface IProductUpdateRepository
	{
		Task<IEnumerable<ProductUpdate>> GetPendingProductUpdatesAsync();
	}
}
