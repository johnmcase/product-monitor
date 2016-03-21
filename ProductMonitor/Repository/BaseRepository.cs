using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Queue;

namespace ProductMonitor.Repository
{
	public abstract class BaseRepository
	{
		protected String tableName = "VendorData";

		protected CloudTable GetVendorTable() {
			return GetCloudTableClient().GetTableReference(tableName);
		}

		private CloudTableClient GetCloudTableClient()
		{
			return this.GetStorageAccount().CreateCloudTableClient();
		}

		private CloudStorageAccount GetStorageAccount()
		{
			return CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
		}
	}
}
