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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.vendorGrid = new System.Windows.Forms.DataGridView();
			this.updatesGrid = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updatesGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.vendorGrid, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.updatesGrid, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 701);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// vendorGrid
			// 
			this.vendorGrid.AllowUserToAddRows = false;
			this.vendorGrid.AllowUserToDeleteRows = false;
			this.vendorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vendorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vendorGrid.Location = new System.Drawing.Point(3, 3);
			this.vendorGrid.Name = "vendorGrid";
			this.vendorGrid.ReadOnly = true;
			this.vendorGrid.Size = new System.Drawing.Size(345, 695);
			this.vendorGrid.TabIndex = 0;
			// 
			// updatesGrid
			// 
			this.updatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.updatesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.updatesGrid.Location = new System.Drawing.Point(354, 3);
			this.updatesGrid.Name = "dataGridView1";
			this.updatesGrid.Size = new System.Drawing.Size(816, 695);
			this.updatesGrid.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 701);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vendorGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updatesGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView vendorGrid;
		private System.Windows.Forms.DataGridView updatesGrid;

	}
}