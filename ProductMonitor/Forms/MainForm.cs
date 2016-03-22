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

			// setup grid data binding
			vendorGrid.DataSource = vendorBindingSource;
			updatesGrid.DataSource = updatesBindingSource;

			// bind vendors pane to data
			vendorBindingSource.DataSource = GetFakeVendors();
			vendorGrid.Columns["Updates"].Visible = false;

			// setup relationship between panes
			updatesBindingSource.DataSource = vendorBindingSource;
			updatesBindingSource.DataMember = "Updates";
		}

		private void vendorBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void updatesBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}


		private IEnumerable<Vendor> GetFakeVendors()
		{
			var ret = new List<Vendor>();

			ret.Add(new Vendor()
			{
				Code = "A",
				Description = "Desc A",
				Name = "Vendor A"
			});

			ret.Add(new Vendor()
			{
				Code = "B",
				Description = "Desc B",
				Name = "Vendor B"
			});

			ret.Add(new Vendor()
			{
				Code = "C",
				Description = "Desc C",
				Name = "Vendor C"
			});

			ret.Add(new Vendor()
			{
				Code = "D",
				Description = "Desc D",
				Name = "Vendor D"
			});

			return ret;
		}
	}
}
