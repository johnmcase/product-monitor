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
		protected String queueName = "productupdates";

		protected CloudTable GetVendorTable()
		{
			return this.GetStorageAccount().CreateCloudTableClient().GetTableReference(tableName);
		}

		protected CloudQueue GetProductUpdateQueue()
		{
			return this.GetStorageAccount().CreateCloudQueueClient().GetQueueReference(queueName);
		}

		private CloudStorageAccount GetStorageAccount()
		{
			return CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
		}
	}
}
