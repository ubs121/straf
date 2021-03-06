using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public class ReportView : Form 	{
		private ReportDocument doc;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ReportView()	{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// reportViewer
			// 
			this.reportViewer.ActiveViewIndex = -1;
			this.reportViewer.DisplayBackgroundEdge = false;
			this.reportViewer.DisplayGroupTree = false;
			this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.ReportSource = null;
			this.reportViewer.ShowCloseButton = false;
			this.reportViewer.ShowExportButton = false;
			this.reportViewer.ShowGroupTreeButton = false;
			this.reportViewer.ShowPrintButton = false;
			this.reportViewer.ShowRefreshButton = false;
			this.reportViewer.ShowTextSearchButton = false;
			this.reportViewer.Size = new System.Drawing.Size(528, 441);
			this.reportViewer.TabIndex = 0;
			// 
			// ReportView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 441);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.reportViewer});
			this.Name = "ReportView";
			this.ShowInTaskbar = false;
			this.Text = "Тайлан";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Report_KeyDown);
			this.ResumeLayout(false);

		}
		#endregion

		private void Report_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.P: 
					reportViewer.PrintReport(); 
					break;

				case Keys.Control | Keys.E: 
					reportViewer.ExportReport(); 
					break;
				
				case Keys.Control | Keys.O: 
					if ( dlgOpen.ShowDialog () == DialogResult.OK) {
						reportViewer.ReportSource = dlgOpen.FileName;
					}
					break;
			
				case Keys.F5: 
					reportViewer.RefreshReport();
					break;
			
				default :
					if (ActiveControl != null)
						Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, (int)e.KeyData, 1);
					break;
			}
		}
		public void SetDocument(ReportDocument doc) {
			this.doc = doc;
			reportViewer.ReportSource = doc;
		}
	}
}

