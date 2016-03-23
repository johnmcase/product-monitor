using ProductManager.Domain;
using ProductMonitor.Repository;
using ProductMonitor.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMonitor.Forms
{
	public partial class MainForm : Form
	{
		private MainFormViewObject viewObject = new MainFormViewObject();

		private IProductMonitorService productMonitorService;
		private const int maxUpdateCount = 50;

		public MainForm()
		{
			// Poor mans IoC
			this.productMonitorService = new ProductMonitorService(
				new ProductUpdateRepository(),
				new ProductRepository(),
				new VendorRepository()
			);

			InitializeComponent();

			vendorGrid.AutoGenerateColumns = true;
			updatesGrid.AutoGenerateColumns = true;
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			await this.LoadVendorsAsync();

			// setup grid data binding
			vendorGrid.DataSource = vendorBindingSource;
			updatesGrid.DataSource = updatesBindingSource;

			// bind vendors pane to data
			vendorBindingSource.DataSource = viewObject.Vendors;

			// setup relationship between panes
			updatesBindingSource.DataSource = vendorBindingSource;
			updatesBindingSource.DataMember = "Updates";

			taskTimer.Interval = 1000; // Run the task every 1 second
			taskTimer.Start();
		}

		private async void TimerEventProcessor(object myObject, EventArgs e)
		{
			await this.productMonitorService.AddUpdatedProductsAsync(this.viewObject.Vendors, maxUpdateCount);
		}

		private void vendorBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void updatesBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private async Task LoadVendorsAsync()
		{
			var vendors = await this.productMonitorService.GetVendorsAsync();
			viewObject.Vendors = new BindingList<Vendor>(vendors.ToList());
		}
	}
}
