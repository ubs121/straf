using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF_U {
	/// <summary>
	/// Товчоо.
	/// </summary>
	public class SummaryView : Form, IStrafChild {
		private ReportSummary doc;
		private string tableName;
		private DatasetSummary dataSet;
		private OleDbConnection con;
		private OleDbDataAdapter daSummary;
		private TabControl tabControl1;
		private TabPage pageStudentSummary;
		private DataGridTableStyle dataGridTableStyle;
		private DataGridTextBoxColumn dataGridTextBoxColumnProf;
		private DataGridTextBoxColumn dataGridTextBoxColumnLoan;
		private DataGridTextBoxColumn dataGridTextBoxColumnAdvance;
		private DataGridTextBoxColumn dataGridTextBoxColumnHerder;
		private DataGridTextBoxColumn dataGridTextBoxColumPoor;
		private DataGridTextBoxColumn dataGridTextBoxColumnThird;
		private DataGridTextBoxColumn dataGridTextBoxColumnTax;
		private DataGrid gridSummary;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLoanTuition;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAdvanceTuition;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnHerderTuition;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPoorTuition;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnThirdTuition;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnTaxTuition;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SummaryView() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			tableName = "summary";
			this.BindingContext[dataSet, tableName].PositionChanged += new EventHandler(dv_PositionChanged);
			LoadData();
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
		private void InitializeComponent() {
			this.con = new System.Data.OleDb.OleDbConnection();
			this.dataSet = new STraF_U.DatasetSummary();
			this.daSummary = new System.Data.OleDb.OleDbDataAdapter();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.pageStudentSummary = new System.Windows.Forms.TabPage();
			this.gridSummary = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnProf = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLoan = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLoanTuition = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAdvance = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAdvanceTuition = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHerder = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHerderTuition = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumPoor = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPoorTuition = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnThird = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnThirdTuition = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTaxTuition = new System.Windows.Forms.DataGridTextBoxColumn();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.pageStudentSummary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
			this.SuspendLayout();
			// 
			// con
			// 
			this.con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Projects\STraF_U\data\data.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DatasetSummary";
			this.dataSet.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet.Namespace = "http://www.tempuri.org/DatasetSummary.xsd";
			// 
			// daSummary
			// 
			this.daSummary.SelectCommand = this.oleDbSelectCommand1;
			this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								new System.Data.Common.DataTableMapping("Table", "summary", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("Advance", "Advance"),
																																																		   new System.Data.Common.DataColumnMapping("AdvanceTuition", "AdvanceTuition"),
																																																		   new System.Data.Common.DataColumnMapping("degree", "degree"),
																																																		   new System.Data.Common.DataColumnMapping("Herder", "Herder"),
																																																		   new System.Data.Common.DataColumnMapping("HerderTuition", "HerderTuition"),
																																																		   new System.Data.Common.DataColumnMapping("Loan", "Loan"),
																																																		   new System.Data.Common.DataColumnMapping("LoanTuition", "LoanTuition"),
																																																		   new System.Data.Common.DataColumnMapping("Poor", "Poor"),
																																																		   new System.Data.Common.DataColumnMapping("PoorTuition", "PoorTuition"),
																																																		   new System.Data.Common.DataColumnMapping("shortname", "shortname"),
																																																		   new System.Data.Common.DataColumnMapping("Tax", "Tax"),
																																																		   new System.Data.Common.DataColumnMapping("TaxTuition", "TaxTuition"),
																																																		   new System.Data.Common.DataColumnMapping("Third", "Third"),
																																																		   new System.Data.Common.DataColumnMapping("ThirdTuition", "ThirdTuition")})});
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.pageStudentSummary});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(728, 365);
			this.tabControl1.TabIndex = 0;
			// 
			// pageStudentSummary
			// 
			this.pageStudentSummary.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.gridSummary});
			this.pageStudentSummary.Location = new System.Drawing.Point(4, 22);
			this.pageStudentSummary.Name = "pageStudentSummary";
			this.pageStudentSummary.Size = new System.Drawing.Size(720, 339);
			this.pageStudentSummary.TabIndex = 0;
			this.pageStudentSummary.Text = "Суралцагчдын товчоо";
			// 
			// gridSummary
			// 
			this.gridSummary.CaptionVisible = false;
			this.gridSummary.DataMember = "summary";
			this.gridSummary.DataSource = this.dataSet;
			this.gridSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSummary.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridSummary.Name = "gridSummary";
			this.gridSummary.ReadOnly = true;
			this.gridSummary.Size = new System.Drawing.Size(720, 339);
			this.gridSummary.TabIndex = 3;
			this.gridSummary.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyle});
			// 
			// dataGridTableStyle
			// 
			this.dataGridTableStyle.DataGrid = this.gridSummary;
			this.dataGridTableStyle.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												 this.dataGridTextBoxColumnProf,
																												 this.dataGridTextBoxColumnLoan,
																												 this.dataGridTextBoxColumnLoanTuition,
																												 this.dataGridTextBoxColumnAdvance,
																												 this.dataGridTextBoxColumnAdvanceTuition,
																												 this.dataGridTextBoxColumnHerder,
																												 this.dataGridTextBoxColumnHerderTuition,
																												 this.dataGridTextBoxColumPoor,
																												 this.dataGridTextBoxColumnPoorTuition,
																												 this.dataGridTextBoxColumnThird,
																												 this.dataGridTextBoxColumnThirdTuition,
																												 this.dataGridTextBoxColumnTax,
																												 this.dataGridTextBoxColumnTaxTuition});
			this.dataGridTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle.MappingName = "summary";
			// 
			// dataGridTextBoxColumnProf
			// 
			this.dataGridTextBoxColumnProf.Format = "";
			this.dataGridTextBoxColumnProf.FormatInfo = null;
			this.dataGridTextBoxColumnProf.HeaderText = "Мэргэжил";
			this.dataGridTextBoxColumnProf.MappingName = "shortname";
			this.dataGridTextBoxColumnProf.Width = 75;
			// 
			// dataGridTextBoxColumnLoan
			// 
			this.dataGridTextBoxColumnLoan.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnLoan.Format = "";
			this.dataGridTextBoxColumnLoan.FormatInfo = null;
			this.dataGridTextBoxColumnLoan.HeaderText = "Зээл";
			this.dataGridTextBoxColumnLoan.MappingName = "loan";
			this.dataGridTextBoxColumnLoan.Width = 50;
			// 
			// dataGridTextBoxColumnLoanTuition
			// 
			this.dataGridTextBoxColumnLoanTuition.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumnLoanTuition.Format = "";
			this.dataGridTextBoxColumnLoanTuition.FormatInfo = null;
			this.dataGridTextBoxColumnLoanTuition.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnLoanTuition.MappingName = "LoanTuition";
			this.dataGridTextBoxColumnLoanTuition.Width = 75;
			// 
			// dataGridTextBoxColumnAdvance
			// 
			this.dataGridTextBoxColumnAdvance.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnAdvance.Format = "";
			this.dataGridTextBoxColumnAdvance.FormatInfo = null;
			this.dataGridTextBoxColumnAdvance.HeaderText = "Буцалтгүй";
			this.dataGridTextBoxColumnAdvance.MappingName = "advance";
			this.dataGridTextBoxColumnAdvance.Width = 50;
			// 
			// dataGridTextBoxColumnAdvanceTuition
			// 
			this.dataGridTextBoxColumnAdvanceTuition.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumnAdvanceTuition.Format = "";
			this.dataGridTextBoxColumnAdvanceTuition.FormatInfo = null;
			this.dataGridTextBoxColumnAdvanceTuition.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnAdvanceTuition.MappingName = "AdvanceTuition";
			this.dataGridTextBoxColumnAdvanceTuition.Width = 75;
			// 
			// dataGridTextBoxColumnHerder
			// 
			this.dataGridTextBoxColumnHerder.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnHerder.Format = "";
			this.dataGridTextBoxColumnHerder.FormatInfo = null;
			this.dataGridTextBoxColumnHerder.HeaderText = "Малчин өрхийн";
			this.dataGridTextBoxColumnHerder.MappingName = "herder";
			this.dataGridTextBoxColumnHerder.Width = 50;
			// 
			// dataGridTextBoxColumnHerderTuition
			// 
			this.dataGridTextBoxColumnHerderTuition.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumnHerderTuition.Format = "";
			this.dataGridTextBoxColumnHerderTuition.FormatInfo = null;
			this.dataGridTextBoxColumnHerderTuition.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnHerderTuition.MappingName = "HerderTuition";
			this.dataGridTextBoxColumnHerderTuition.Width = 75;
			// 
			// dataGridTextBoxColumPoor
			// 
			this.dataGridTextBoxColumPoor.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumPoor.Format = "";
			this.dataGridTextBoxColumPoor.FormatInfo = null;
			this.dataGridTextBoxColumPoor.HeaderText = "Ядуу өрхийн";
			this.dataGridTextBoxColumPoor.MappingName = "poor";
			this.dataGridTextBoxColumPoor.Width = 50;
			// 
			// dataGridTextBoxColumnPoorTuition
			// 
			this.dataGridTextBoxColumnPoorTuition.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumnPoorTuition.Format = "";
			this.dataGridTextBoxColumnPoorTuition.FormatInfo = null;
			this.dataGridTextBoxColumnPoorTuition.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnPoorTuition.MappingName = "PoorTuition";
			this.dataGridTextBoxColumnPoorTuition.Width = 75;
			// 
			// dataGridTextBoxColumnThird
			// 
			this.dataGridTextBoxColumnThird.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnThird.Format = "";
			this.dataGridTextBoxColumnThird.FormatInfo = null;
			this.dataGridTextBoxColumnThird.HeaderText = "Гуравдагч суралцагч";
			this.dataGridTextBoxColumnThird.MappingName = "third";
			this.dataGridTextBoxColumnThird.Width = 50;
			// 
			// dataGridTextBoxColumnThirdTuition
			// 
			this.dataGridTextBoxColumnThirdTuition.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumnThirdTuition.Format = "";
			this.dataGridTextBoxColumnThirdTuition.FormatInfo = null;
			this.dataGridTextBoxColumnThirdTuition.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnThirdTuition.MappingName = "ThirdTuition";
			this.dataGridTextBoxColumnThirdTuition.Width = 75;
			// 
			// dataGridTextBoxColumnTax
			// 
			this.dataGridTextBoxColumnTax.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnTax.Format = "";
			this.dataGridTextBoxColumnTax.FormatInfo = null;
			this.dataGridTextBoxColumnTax.HeaderText = "ТАХХ";
			this.dataGridTextBoxColumnTax.MappingName = "tax";
			this.dataGridTextBoxColumnTax.Width = 50;
			// 
			// dataGridTextBoxColumnTaxTuition
			// 
			this.dataGridTextBoxColumnTaxTuition.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumnTaxTuition.Format = "";
			this.dataGridTextBoxColumnTaxTuition.FormatInfo = null;
			this.dataGridTextBoxColumnTaxTuition.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnTaxTuition.MappingName = "TaxTuition";
			this.dataGridTextBoxColumnTaxTuition.Width = 75;
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Advance, AdvanceTuition, degree, Herder, HerderTuition, Loan, LoanTuition," +
				" Poor, PoorTuition, shortname, Tax, TaxTuition, Third, ThirdTuition FROM summary" +
				"";
			this.oleDbSelectCommand1.Connection = this.con;
			// 
			// SummaryView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(728, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1});
			this.Name = "SummaryView";
			this.Text = "Товчоо";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SummaryView_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.pageStudentSummary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public ReportDocument GetDocument() {
			if (doc == null) {
				doc = new ReportSummary();
				doc.SetDataSource(dataSet);
			}
			return doc;
		}

		public void FillDataSet(DatasetSummary dataSet) {
			dataSet.EnforceConstraints = false;
			try {
				con.ConnectionString = Straf.strCon;
				con.Open();
				daSummary.Fill(dataSet);
			}
			catch (Exception fillException) {
				// Add your error handling code here.
				throw fillException;
			}
			finally {
				dataSet.EnforceConstraints = true;
				con.Close();
			}

		}

		public void UpdateDataSource(DatasetSummary ChangedRows) {
			try {
				if ((ChangedRows != null)) {
					con.ConnectionString = Straf.strCon;
					con.Open();
					daSummary.Update(ChangedRows);
				}
			}
			catch (Exception updateException) {
				// Add your error handling code here.
				throw updateException;
			}
			finally {
				// Close the connection whether or not the exception was thrown.
				con.Close();
			}

		}

		public void LoadDataSet() {
			DatasetSummary tempSet;
			tempSet = new DatasetSummary();
			try {
				this.FillDataSet(tempSet);
			}
			catch (Exception eFillDataSet) {
				// Add your error handling code here.
				throw eFillDataSet;
			}
			try {
				dataSet.Clear();
				dataSet.Merge(tempSet);
			}
			catch (Exception eLoadMerge) {
				// Add your error handling code here.
				throw eLoadMerge;
			}

		}

		public void UpdateDataSet() {
			DatasetSummary changedSet = new DatasetSummary();
			this.BindingContext[dataSet,tableName].EndCurrentEdit();
			changedSet = ((DatasetSummary)(dataSet.GetChanges()));
			if ((changedSet != null)) {
				try {
					UpdateDataSource(changedSet);
					dataSet.Merge(changedSet);
					dataSet.AcceptChanges();
				}
				catch (Exception eUpdate) {
					// Add your error handling code here.
					throw eUpdate;
				}
				// Add your code to check the returned dataset for any errors that may have been
				// pushed into the row object's error.
			}

		}

		private void LoadData() {
			try {
				this.LoadDataSet();
			}
			catch (Exception eLoad) {
				// Add your error handling code here.
				MessageBox.Show(eLoad.Message);
			}

		}

		private void UpdateData() {
			try {
				// Attempt to update the datasource.
				this.UpdateDataSet();
			}
			catch (Exception eUpdate) {
				// Add your error handling code here.
				
				MessageBox.Show(eUpdate.Message);
			}
		}

		private void SummaryView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.S: 
					//UpdateData(); 
					break;
			
				case Keys.Control | Keys.C: 
					Copy(sender, e); 
					break;
			
				case Keys.Control | Keys.X: 
					//Cut(sender, e); 
					break;
			
				case Keys.Control | Keys.V: 
					//Paste(sender, e); 
					break;
				
				case Keys.Control | Keys.Z: 
					//Undo(); 
					break;

				case Keys.F5: 
					LoadData(); 
					break;

				case Keys.Control | Keys.G: 
					GoTo();
					break;

				case Keys.Alt | Keys.Left:
					MoveFirst();
					break;

				case Keys.Alt | Keys.Up:
					MovePrev();
					break;

				case Keys.Alt | Keys.Down:
					MoveNext();
					break;

				case Keys.Alt | Keys.Right:
					MoveLast();
					break;
			
				default :
					if (ActiveControl != null)
						Win32.SendMessage(ActiveControl.Handle, 0x0100, (int)e.KeyData, 1);
					break;
			}
		}
		private void MoveFirst() {
			this.BindingContext[dataSet, tableName].Position = 0;
		}
		private void MovePrev() {
			this.BindingContext[dataSet, tableName].Position -= 1;
		}
		private void MoveNext() {
			this.BindingContext[dataSet, tableName].Position += 1;
		}
		private void MoveLast() {
			this.BindingContext[dataSet, tableName].Position = this.BindingContext[dataSet, tableName].Count - 1;
		}
		private void GoTo() {
			GotoDlg dlg = new GotoDlg();
			dlg.labelTitle.Text = "Байрлал: (1 - " + this.BindingContext[dataSet, tableName].Count + ")";
			if (dlg.ShowDialog() == DialogResult.OK) {
				try {
					int no;
					no = Convert.ToInt32(dlg.textPos.Text);
					this.BindingContext[dataSet, tableName].Position = no - 1;
				}
				catch (Exception) {}
			}
		}
		private void gridSummary_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				DataGrid.HitTestInfo hit;
				hit = gridSummary.HitTest(e.X, e.Y);
				int hitRow = hit.Row;
				if (hitRow != -1 && gridSummary.IsSelected(hitRow)) {
					string dragText = tableName;
					for (int i=0; i < dataSet.Tables[tableName].Rows.Count; i++) {
						if (gridSummary.IsSelected(i)) {
							for (int j=1; j < dataSet.Tables[tableName].Columns.Count; j++) {
								dragText += dataSet.Tables[tableName].Rows[i][j] + "\t";
							}
							dragText += "\r\n";
						}
					}
					gridSummary.DoDragDrop(dragText, DragDropEffects.Copy | DragDropEffects.Move);
				}
			}
		}
		private void dv_PositionChanged(object sender, System.EventArgs e) {
			try {
				if (this.MdiParent != null) {
					((Straf)this.MdiParent).statusRecord.Text = string.Format("{0}/{1}", this.BindingContext[dataSet, tableName].Position + 1, this.BindingContext[dataSet, tableName].Count);
				}
			}
			catch (Exception) {}
		}
		private void Copy(object sender, System.EventArgs e) {
			string strData = "";
			for (int i=0; i < dataSet.Tables[tableName].Rows.Count; i++) {
				if (gridSummary.IsSelected(i)) {
					for (int j = 1; j < dataSet.Tables[tableName].Columns.Count - 1; j++) {
						strData += dataSet.Tables[tableName].Rows[i][j] + "\t";
					}
					strData += "\r\n";
				}
			}
			Clipboard.SetDataObject(strData);
		}
		public int Find(object search, bool regular, bool back) {
			return -1;
		}
		public int Replace(object search, object replace, bool regular, bool back) {
			return -1;
		}
	}
}
