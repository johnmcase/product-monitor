using ProductManager.Domain;
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
		public MainForm()
		{
			InitializeComponent();

			vendorGrid.AutoGenerateColumns = true;
			updatesGrid.AutoGenerateColumns = true;

			LoadFakeVendors();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// setup grid data binding
			vendorGrid.DataSource = vendorBindingSource;
			updatesGrid.DataSource = updatesBindingSource;

			// bind vendors pane to data
			vendorBindingSource.DataSource = vo.Vendors;
			//vendorGrid.Columns["Updates"].Visible = false;

			// setup relationship between panes
			updatesBindingSource.DataSource = vendorBindingSource;
			updatesBindingSource.DataMember = "Updates";

			taskTimer.Interval = 1000; // Run the task every 1 second
			taskTimer.Start();
		}

		private void TimerEventProcessor(object myObject, EventArgs e)
		{
			Console.Out.WriteLine("TIMER TASK RUNNING");
			vo.Vendors.First().Updates.Add(new Product()
			{
				ProductId = Guid.NewGuid(),
				VendorCode = "ADDED"
			});
		}

		private void vendorBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void updatesBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}


		private MainFormViewObject vo = new MainFormViewObject();
		private void LoadFakeVendors()
		{
			vo.Vendors.Add(new VendorViewObject()
			{
				Code = "A",
				Description = "Desc A",
				Name = "Vendor A",
				Updates = new BindingList<Product>()
			});

			vo.Vendors.Add(new VendorViewObject()
			{
				Code = "B",
				Description = "Desc B",
				Name = "Vendor B",
				Updates = new BindingList<Product>()
			});

			vo.Vendors.Add(new VendorViewObject()
			{
				Code = "C",
				Description = "Desc C",
				Name = "Vendor C",
				Updates = new BindingList<Product>()
			});

			vo.Vendors.Add(new VendorViewObject()
			{
				Code = "D",
				Description = "Desc D",
				Name = "Vendor D",
				Updates = new BindingList<Product>()
			});
		}
	}
}
