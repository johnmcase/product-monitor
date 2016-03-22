using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	[TestClass]
	public class ProductUpdateRepositoryTest
	{
		[TestMethod]
		[TestCategory("Integration")]
		public async Task GetPendingProductUpdates_WhenCalled_ReturnsData()
		{
			var repo = new ProductUpdateRepository();
			var results = await repo.GetPendingProductUpdatesAsync();

			Assert.IsNotNull(results);
			Assert.IsTrue(results.Count() > 0);
		}
	}
}
