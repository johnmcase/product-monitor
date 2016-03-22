using Microsoft.WindowsAzure.Storage.Table;
using ProductManager.Domain;
using System;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public async Task<Product> GetProductAsync(String vendorCode, Guid productId)
		{
			TableOperation op = TableOperation.Retrieve<ProductEntity>(vendorCode, generateRowKey(productId));

			TableResult result = await GetVendorTable().ExecuteAsync(op);
			return ((ProductEntity)result.Result).AsProduct();
		}

		private static String generateRowKey(Guid productId)
		{
			return String.Format("Product__{0}", productId);
		}

		private static Guid parseProductId(String rowKey)
		{
			if(rowKey.StartsWith("Product__"))
			{
				rowKey = rowKey.Remove(0, 9);
			}

			Guid ret = default(Guid);
			Guid.TryParse(rowKey, out ret);
			return ret;
		}

		private class ProductEntity : TableEntity
		{
			public ProductEntity(String PartitionKey, Guid RowKey)
			{
				this.PartitionKey = PartitionKey;
				this.RowKey = generateRowKey(RowKey);
			}

			public ProductEntity() { }

			public Guid ProductId
			{
				get
				{
					return parseProductId(this.RowKey);
				}
				set
				{
					this.RowKey = generateRowKey(value);
				}
			}

			public String VendorCode
			{
				get
				{
					return this.PartitionKey;
				}
				set
				{
					this.PartitionKey = value;
				}
			}

			public String Name { get; set; }
			public String Description { get; set; }
			public Double Price { get; set; }

			public Product AsProduct()
			{
				return new Product()
				{
					ProductId = this.ProductId,
					VendorCode = this.VendorCode,
					Name = this.Name,
					Description = this.Description,
					Price = this.Price
				};
			}
		}
	}
}
