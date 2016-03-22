using System.ComponentModel;

namespace ProductMonitor.Forms
{
	public class MainFormViewObject
	{
		public MainFormViewObject()
		{
			this.Vendors = new BindingList<VendorViewObject>();
		}

		public BindingList<VendorViewObject> Vendors { get; private set; }
	}
}
