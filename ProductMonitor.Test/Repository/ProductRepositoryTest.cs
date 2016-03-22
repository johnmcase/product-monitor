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
			var vendorCode = "TRK";
			var productId = Guid.Parse("00002d4b-224c-49d1-8d6a-ef21ad7111e2");

			var repo = new ProductRepository();
			var result = await repo.GetProductAsync(vendorCode, productId);

			Assert.IsNotNull(result);
			Assert.AreEqual(vendorCode, result.VendorCode);
			Assert.AreEqual(productId, result.ProductId);
			Assert.IsNotNull(result.Name);
			Assert.IsNotNull(result.Description);
			Assert.IsNotNull(result.Price);
		}
	}
}
