using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProductMonitor.Domain;
using ProductMonitor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Service
{
	[TestClass]
	public class ProductMonitorServiceTest
	{
		private ProductMonitorService target;
		private Mock<IVendorRepository> mockVendorRepository;
		private Mock<IProductUpdateRepository> mockUpdateReposotry;
		private Mock<IProductRepository> mockProductRepository;

		[TestInitialize]
		public void SetUp()
		{
			this.mockVendorRepository = new Mock<IVendorRepository>();
			this.mockUpdateReposotry = new Mock<IProductUpdateRepository>();
			this.mockProductRepository = new Mock<IProductRepository>();

			this.target = new ProductMonitorService(this.mockUpdateReposotry.Object, this.mockProductRepository.Object, this.mockVendorRepository.Object);
		}

		[TestMethod]
		public async Task GetVendorsDelegatesToRepository()
		{
			List<Vendor> expectedVendors = new List<Vendor>();
			this.mockVendorRepository.Setup(repo => repo.GetVendorsAsync()).ReturnsAsync(expectedVendors).Verifiable();

			var result = await this.target.GetVendorsAsync();

			Assert.AreSame(expectedVendors, result);
			mockVendorRepository.Verify();
		}

		[TestMethod]
		public async Task AddUpdatedProductsWorks()
		{
			Guid id1 = Guid.NewGuid();
			Guid id2 = Guid.NewGuid();

			List<ProductUpdate> updates = new List<ProductUpdate>()
			{
				new ProductUpdate(){VendorCode = "1", ProductId = id1},
				new ProductUpdate(){VendorCode = "2", ProductId = id2}
			};
			this.mockUpdateReposotry.Setup(repo => repo.GetPendingProductUpdatesAsync()).ReturnsAsync(updates).Verifiable();
			this.mockProductRepository.Setup(repo => repo.GetProductAsync("1", id1)).ReturnsAsync(new Product() { ProductId = id1 }).Verifiable();
			this.mockProductRepository.Setup(repo => repo.GetProductAsync("2", id2)).ReturnsAsync(new Product() { ProductId = id2 }).Verifiable();

			List<Vendor> vendorList = new List<Vendor>()
			{
				new Vendor(){Code = "1"},
				new Vendor(){Code = "2"},
				new Vendor(){Code = "3"}
			};

			await this.target.AddUpdatedProductsAsync(vendorList, 5);

			Assert.AreEqual(1, vendorList[0].Updates.Count);
			Assert.AreEqual(id1, vendorList[0].Updates[0].ProductId);

			Assert.AreEqual(1, vendorList[1].Updates.Count);
			Assert.AreEqual(id2, vendorList[1].Updates[0].ProductId);

			Assert.AreEqual(0, vendorList[2].Updates.Count);

			mockUpdateReposotry.Verify();
			mockProductRepository.Verify();
		}
	}
}
