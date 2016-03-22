using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	[TestClass]
	public class ProductRepositoryTest
	{
		[TestMethod]
		[TestCategory("Integration")]
		public async Task GetProduct_WhenCalled_ReturnsData()
		{
			var repo = new ProductRepository();
			var result = await repo.GetProductAsync("BTN", "74f347d3-3725-4da5-83b2-7a9d639222cd");

			Assert.IsNotNull(result);
		}
	}
}
