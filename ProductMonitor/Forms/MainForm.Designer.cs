namespace ProductMonitor.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.vendorGrid = new System.Windows.Forms.DataGridView();
			this.updatesGrid = new System.Windows.Forms.DataGridView();
			this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.updatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updatesGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updatesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.vendorGrid);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.updatesGrid);
			this.splitContainer1.Size = new System.Drawing.Size(1173, 701);
			this.splitContainer1.SplitterDistance = 391;
			this.splitContainer1.TabIndex = 0;
			// 
			// vendorGrid
			// 
			this.vendorGrid.AllowUserToAddRows = false;
			this.vendorGrid.AllowUserToDeleteRows = false;
			this.vendorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vendorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vendorGrid.Location = new System.Drawing.Point(0, 0);
			this.vendorGrid.Name = "vendorGrid";
			this.vendorGrid.ReadOnly = true;
			this.vendorGrid.Size = new System.Drawing.Size(391, 701);
			this.vendorGrid.TabIndex = 0;
			// 
			// updatesGrid
			// 
			this.updatesGrid.AllowUserToAddRows = false;
			this.updatesGrid.AllowUserToDeleteRows = false;
			this.updatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.updatesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.updatesGrid.Location = new System.Drawing.Point(0, 0);
			this.updatesGrid.Name = "updatesGrid";
			this.updatesGrid.ReadOnly = true;
			this.updatesGrid.Size = new System.Drawing.Size(778, 701);
			this.updatesGrid.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 701);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updatesGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updatesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView vendorGrid;
		private System.Windows.Forms.DataGridView updatesGrid;
		private System.Windows.Forms.BindingSource vendorBindingSource;
		private System.Windows.Forms.BindingSource updatesBindingSource;


	}
}