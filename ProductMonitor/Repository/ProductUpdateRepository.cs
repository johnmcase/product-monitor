using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using ProductMonitor.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Repository
{
	public class ProductUpdateRepository : BaseRepository, IProductUpdateRepository
	{
		public async Task<IEnumerable<ProductUpdate>> GetPendingProductUpdatesAsync()
		{
			var queue = this.GetProductUpdateQueue();

			var messages = await queue.GetMessagesAsync(32);

			List<ProductUpdate> updates = new List<ProductUpdate>();
			foreach (var msg in messages)
			{
				updates.AddRange(AsProductUpdateList(msg));
				await queue.DeleteMessageAsync(msg);
			}

			return updates;
		}

		private IEnumerable<ProductUpdate> AsProductUpdateList(CloudQueueMessage msg)
		{
			ProductUpdateMessage x = JsonConvert.DeserializeObject<ProductUpdateMessage>(msg.AsString);
			return x.Updates;
		}

		private class ProductUpdateMessage
		{
			public IEnumerable<ProductUpdate> Updates { get; set; }
		}
	}
}
