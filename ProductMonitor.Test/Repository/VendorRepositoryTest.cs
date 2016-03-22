using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	[TestClass]
	public class VendorRepositoryTest
	{
		[TestMethod]
		[TestCategory("Integration")]
		public async Task GetVendors_WhenCalled_ReturnsData()
		{
			var repository = new VendorRepository();

			var result = await repository.GetVendorsAsync();

			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count() > 0);

			var first = result.First();
			Assert.IsNotNull(first.Code);
			Assert.IsNotNull(first.Name);
			Assert.IsNotNull(first.Description);
		}
	}
}
