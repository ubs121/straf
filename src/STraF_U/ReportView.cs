using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF_U {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public class ReportView : Form 	{
		private ReportDocument doc;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
		private OpenFileDialog dlgOpen;
		private ContextMenu contextZoom;
		private MenuItem cmdPopPageWidth;
		private MenuItem cmdPopWholePage;
		private MenuItem cmdPop400;
		private MenuItem cmdPop300;
		private MenuItem cmdPop200;
		private MenuItem cmdPop150;
		private MenuItem cmdPop100;
		private MenuItem cmdPop75;
		private MenuItem cmdPop50;
		private MenuItem cmdPop25;
		private MenuItem cmdPopCustomize;
		private MainMenu mainMenu;
		private MenuItem cmdExport;
		private MenuItem cmdZoom;
		private MenuItem cmdPageWidth;
		private MenuItem cmdWholePage;
		private MenuItem cmd400;
		private MenuItem cmd300;
		private MenuItem cmd200;
		private MenuItem cmd150;
		private MenuItem cmd100;
		private MenuItem cmd75;
		private MenuItem cmd50;
		private MenuItem cmd25;
		private MenuItem cmdCustomize;
		private System.Windows.Forms.MenuItem menuReport;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReportView));
			this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.contextZoom = new System.Windows.Forms.ContextMenu();
			this.cmdPopPageWidth = new System.Windows.Forms.MenuItem();
			this.cmdPopWholePage = new System.Windows.Forms.MenuItem();
			this.cmdPop400 = new System.Windows.Forms.MenuItem();
			this.cmdPop300 = new System.Windows.Forms.MenuItem();
			this.cmdPop200 = new System.Windows.Forms.MenuItem();
			this.cmdPop150 = new System.Windows.Forms.MenuItem();
			this.cmdPop100 = new System.Windows.Forms.MenuItem();
			this.cmdPop75 = new System.Windows.Forms.MenuItem();
			this.cmdPop50 = new System.Windows.Forms.MenuItem();
			this.cmdPop25 = new System.Windows.Forms.MenuItem();
			this.cmdPopCustomize = new System.Windows.Forms.MenuItem();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuReport = new System.Windows.Forms.MenuItem();
			this.cmdExport = new System.Windows.Forms.MenuItem();
			this.cmdZoom = new System.Windows.Forms.MenuItem();
			this.cmdPageWidth = new System.Windows.Forms.MenuItem();
			this.cmdWholePage = new System.Windows.Forms.MenuItem();
			this.cmd400 = new System.Windows.Forms.MenuItem();
			this.cmd300 = new System.Windows.Forms.MenuItem();
			this.cmd200 = new System.Windows.Forms.MenuItem();
			this.cmd150 = new System.Windows.Forms.MenuItem();
			this.cmd100 = new System.Windows.Forms.MenuItem();
			this.cmd75 = new System.Windows.Forms.MenuItem();
			this.cmd50 = new System.Windows.Forms.MenuItem();
			this.cmd25 = new System.Windows.Forms.MenuItem();
			this.cmdCustomize = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// reportViewer
			// 
			this.reportViewer.ActiveViewIndex = -1;
			this.reportViewer.ContextMenu = this.contextZoom;
			this.reportViewer.DisplayBackgroundEdge = false;
			this.reportViewer.DisplayGroupTree = false;
			this.reportViewer.DisplayToolbar = false;
			this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer.Name = "reportViewer";
			this.reportViewer.ReportSource = null;
			this.reportViewer.ShowCloseButton = false;
			this.reportViewer.ShowExportButton = false;
			this.reportViewer.ShowGotoPageButton = false;
			this.reportViewer.ShowGroupTreeButton = false;
			this.reportViewer.ShowPageNavigateButtons = false;
			this.reportViewer.ShowPrintButton = false;
			this.reportViewer.ShowRefreshButton = false;
			this.reportViewer.ShowTextSearchButton = false;
			this.reportViewer.ShowZoomButton = false;
			this.reportViewer.Size = new System.Drawing.Size(520, 397);
			this.reportViewer.TabIndex = 0;
			this.reportViewer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Report_KeyDown);
			// 
			// contextZoom
			// 
			this.contextZoom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmdPopPageWidth,
																						this.cmdPopWholePage,
																						this.cmdPop400,
																						this.cmdPop300,
																						this.cmdPop200,
																						this.cmdPop150,
																						this.cmdPop100,
																						this.cmdPop75,
																						this.cmdPop50,
																						this.cmdPop25,
																						this.cmdPopCustomize});
			// 
			// cmdPopPageWidth
			// 
			this.cmdPopPageWidth.Index = 0;
			this.cmdPopPageWidth.Text = "&Цаасны өргөнөөр";
			this.cmdPopPageWidth.Click += new System.EventHandler(this.cmdPageWidth_Click);
			// 
			// cmdPopWholePage
			// 
			this.cmdPopWholePage.Index = 1;
			this.cmdPopWholePage.Text = "&Бvтэн хуудсаар";
			this.cmdPopWholePage.Click += new System.EventHandler(this.cmdWholePage_Click);
			// 
			// cmdPop400
			// 
			this.cmdPop400.Index = 2;
			this.cmdPop400.Text = "400%";
			this.cmdPop400.Click += new System.EventHandler(this.cmd400_Click);
			// 
			// cmdPop300
			// 
			this.cmdPop300.Index = 3;
			this.cmdPop300.Text = "300%";
			this.cmdPop300.Click += new System.EventHandler(this.cmd300_Click);
			// 
			// cmdPop200
			// 
			this.cmdPop200.Index = 4;
			this.cmdPop200.Text = "200%";
			this.cmdPop200.Click += new System.EventHandler(this.cmd200_Click);
			// 
			// cmdPop150
			// 
			this.cmdPop150.Index = 5;
			this.cmdPop150.Text = "150%";
			this.cmdPop150.Click += new System.EventHandler(this.cmd150_Click);
			// 
			// cmdPop100
			// 
			this.cmdPop100.Index = 6;
			this.cmdPop100.Text = "100%";
			this.cmdPop100.Click += new System.EventHandler(this.cmd100_Click);
			// 
			// cmdPop75
			// 
			this.cmdPop75.Index = 7;
			this.cmdPop75.Text = "75%";
			this.cmdPop75.Click += new System.EventHandler(this.cmd75_Click);
			// 
			// cmdPop50
			// 
			this.cmdPop50.Index = 8;
			this.cmdPop50.Text = "50%";
			this.cmdPop50.Click += new System.EventHandler(this.cmd50_Click);
			// 
			// cmdPop25
			// 
			this.cmdPop25.Index = 9;
			this.cmdPop25.Text = "25%";
			this.cmdPop25.Click += new System.EventHandler(this.cmd25_Click);
			// 
			// cmdPopCustomize
			// 
			this.cmdPopCustomize.Index = 10;
			this.cmdPopCustomize.Text = "Сонгох...";
			this.cmdPopCustomize.Click += new System.EventHandler(this.cmdCustomize_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuReport});
			// 
			// menuReport
			// 
			this.menuReport.Index = 0;
			this.menuReport.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.cmdZoom,
																					   this.cmdExport});
			this.menuReport.MergeOrder = 3;
			this.menuReport.Text = "Тай&лан";
			// 
			// cmdExport
			// 
			this.cmdExport.Index = 1;
			this.cmdExport.Text = "&Экспорт";
			this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
			// 
			// cmdZoom
			// 
			this.cmdZoom.Index = 0;
			this.cmdZoom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.cmdPageWidth,
																					this.cmdWholePage,
																					this.cmd400,
																					this.cmd300,
																					this.cmd200,
																					this.cmd150,
																					this.cmd100,
																					this.cmd75,
																					this.cmd50,
																					this.cmd25,
																					this.cmdCustomize});
			this.cmdZoom.Text = "&Хэмжээг өөрчлөх";
			// 
			// cmdPageWidth
			// 
			this.cmdPageWidth.Index = 0;
			this.cmdPageWidth.Text = "&Цаасны өргөнөөр";
			this.cmdPageWidth.Click += new System.EventHandler(this.cmdPageWidth_Click);
			// 
			// cmdWholePage
			// 
			this.cmdWholePage.Index = 1;
			this.cmdWholePage.Text = "&Бvтэн хуудсаар";
			this.cmdWholePage.Click += new System.EventHandler(this.cmdWholePage_Click);
			// 
			// cmd400
			// 
			this.cmd400.Index = 2;
			this.cmd400.Text = "400%";
			this.cmd400.Click += new System.EventHandler(this.cmd400_Click);
			// 
			// cmd300
			// 
			this.cmd300.Index = 3;
			this.cmd300.Text = "300%";
			this.cmd300.Click += new System.EventHandler(this.cmd300_Click);
			// 
			// cmd200
			// 
			this.cmd200.Index = 4;
			this.cmd200.Text = "200%";
			this.cmd200.Click += new System.EventHandler(this.cmd200_Click);
			// 
			// cmd150
			// 
			this.cmd150.Index = 5;
			this.cmd150.Text = "150%";
			this.cmd150.Click += new System.EventHandler(this.cmd150_Click);
			// 
			// cmd100
			// 
			this.cmd100.Index = 6;
			this.cmd100.Text = "100%";
			this.cmd100.Click += new System.EventHandler(this.cmd100_Click);
			// 
			// cmd75
			// 
			this.cmd75.Index = 7;
			this.cmd75.Text = "75%";
			this.cmd75.Click += new System.EventHandler(this.cmd75_Click);
			// 
			// cmd50
			// 
			this.cmd50.Index = 8;
			this.cmd50.Text = "50%";
			this.cmd50.Click += new System.EventHandler(this.cmd50_Click);
			// 
			// cmd25
			// 
			this.cmd25.Index = 9;
			this.cmd25.Text = "25%";
			this.cmd25.Click += new System.EventHandler(this.cmd25_Click);
			// 
			// cmdCustomize
			// 
			this.cmdCustomize.Index = 10;
			this.cmdCustomize.Text = "Сонгох...";
			this.cmdCustomize.Click += new System.EventHandler(this.cmdCustomize_Click);
			// 
			// ReportView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.reportViewer});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu;
			this.Name = "ReportView";
			this.ShowInTaskbar = false;
			this.Text = "Тайлан";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Report_KeyDown);
			this.ResumeLayout(false);

		}
		#endregion

		private void Report_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.P: 
					reportViewer.PrintReport(); 
					break;

				case Keys.Control | Keys.O: 
					if ( dlgOpen.ShowDialog () == DialogResult.OK) {
						reportViewer.ReportSource = dlgOpen.FileName;
					}
					break;
			
				case Keys.F5: 
					reportViewer.RefreshReport();
					break;

				case Keys.Control | Keys.G:
					GotoDlg dlg = new GotoDlg();
					dlg.labelTitle.Text = "Хуудас:";
					if (dlg.ShowDialog() == DialogResult.OK) {
						try {
							int no;
							no = Convert.ToInt32(dlg.textPos.Text);
							reportViewer.ShowNthPage(no);
						}
						catch (Exception) {}
					}
					break;

				case Keys.Alt | Keys.Left:
					reportViewer.ShowFirstPage();
					break;

				case Keys.Alt | Keys.Up:
					reportViewer.ShowPreviousPage();
					break;

				case Keys.Alt | Keys.Down:
					reportViewer.ShowNextPage();
					break;

				case Keys.Alt | Keys.Right:
					reportViewer.ShowLastPage();
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

		private void cmdPageWidth_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(1);
		}

		private void cmdWholePage_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(2);
		}

		private void cmd400_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(400);
		}

		private void cmd300_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(300);
		}

		private void cmd200_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(200);
		}

		private void cmd150_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(150);
		}

		private void cmd100_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(100);
		}

		private void cmd75_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(75);
		}

		private void cmd50_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(50);
		}

		private void cmd25_Click(object sender, System.EventArgs e) {
			reportViewer.Zoom(25);
		}

		private void cmdCustomize_Click(object sender, System.EventArgs e) {
			GotoDlg dlg = new GotoDlg();
			dlg.Text = "Хэмжээ сонгох";
			dlg.labelTitle.Text = "Хэмжээ:";
			if (dlg.ShowDialog() == DialogResult.OK) {
				try {
					int size;
					size = Convert.ToInt32(dlg.textPos.Text);
					reportViewer.Zoom(size);
				}
				catch (Exception) {}
			}
		}

		private void cmdExport_Click(object sender, System.EventArgs e) {
			reportViewer.ExportReport();
		}
	}
}

