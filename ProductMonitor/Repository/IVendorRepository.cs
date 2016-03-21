using ProductManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	interface IVendorRepository
	{
		Task<IEnumerable<Vendor>> GetVendorsAsync();
	}
}
