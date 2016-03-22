using ProductManager.Domain;
using ProductMonitor.Repository;
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
		private IVendorRepository vendorRepository = new VendorRepository();

		public MainForm()
		{
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
			//vendorGrid.Columns["Updates"].Visible = false;

			// setup relationship between panes
			updatesBindingSource.DataSource = vendorBindingSource;
			updatesBindingSource.DataMember = "Updates";

			taskTimer.Interval = 1000; // Run the task every 1 second
			taskTimer.Start();
		}

		private void TimerEventProcessor(object myObject, EventArgs e)
		{
			viewObject.Vendors.First().Updates.Insert(0, new Product()
			{
				ProductId = Guid.NewGuid(),
				VendorCode = "ADDED"
			});
			while (viewObject.Vendors.First().Updates.Count > 3)
			{
				viewObject.Vendors.First().Updates.RemoveAt(3);
			}
		}

		private void vendorBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void updatesBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}


		private async Task LoadVendorsAsync()
		{
			var vendors = await this.vendorRepository.GetVendorsAsync();
			viewObject.Vendors = new BindingList<Vendor>(vendors.ToList());
		}
	}
}
