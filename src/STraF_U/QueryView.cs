using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace STraF_U {
	/// <summary>
	/// Summary description for Query.
	/// </summary>
	public class QueryView : Form {
		private string filename;
		private bool saved;
		private OpenFileDialog openDlg;
		private SaveFileDialog saveDlg;
		private MainMenu menuMain;
		private MenuItem menuQuery;
		private MenuItem cmdCheck;
		private OleDbConnection con;
		private OleDbDataAdapter da;
		private DataGrid gridResult;
		private Label label1;
		private Label label2;
		private ListBox listTable;
		private ListBox listColumn;
		private Button buttonAddTable;
		private Button buttonAddColumn;
		private TextBox textSQL;
		private ToolTip toolTip;
		private Panel panelSQL;
		private Splitter splitterWizard;
		private Panel panelSQLWizard;
		private Splitter splitterSQL;
		private System.Data.OleDb.OleDbCommand sqlSelect;
		private System.ComponentModel.IContainer components;

		public QueryView() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			NewQuery();
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(QueryView));
			this.openDlg = new System.Windows.Forms.OpenFileDialog();
			this.saveDlg = new System.Windows.Forms.SaveFileDialog();
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.menuQuery = new System.Windows.Forms.MenuItem();
			this.cmdCheck = new System.Windows.Forms.MenuItem();
			this.con = new System.Data.OleDb.OleDbConnection();
			this.da = new System.Data.OleDb.OleDbDataAdapter();
			this.sqlSelect = new System.Data.OleDb.OleDbCommand();
			this.gridResult = new System.Windows.Forms.DataGrid();
			this.panelSQL = new System.Windows.Forms.Panel();
			this.textSQL = new System.Windows.Forms.TextBox();
			this.splitterWizard = new System.Windows.Forms.Splitter();
			this.panelSQLWizard = new System.Windows.Forms.Panel();
			this.buttonAddColumn = new System.Windows.Forms.Button();
			this.buttonAddTable = new System.Windows.Forms.Button();
			this.listColumn = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listTable = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.splitterSQL = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
			this.panelSQL.SuspendLayout();
			this.panelSQLWizard.SuspendLayout();
			this.SuspendLayout();
			// 
			// openDlg
			// 
			this.openDlg.DefaultExt = "sql";
			this.openDlg.Filter = "Асуулга файлууд (*.sql)|*.sql";
			this.openDlg.Title = "Файл нээх";
			// 
			// saveDlg
			// 
			this.saveDlg.DefaultExt = "sql";
			this.saveDlg.Filter = "Асуулга файлууд (*.sql)|*.sql";
			this.saveDlg.Title = "Файл хадгалах";
			// 
			// menuMain
			// 
			this.menuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuQuery});
			// 
			// menuQuery
			// 
			this.menuQuery.Index = 0;
			this.menuQuery.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.cmdCheck});
			this.menuQuery.MergeOrder = 3;
			this.menuQuery.Text = "&Асуулга";
			// 
			// cmdCheck
			// 
			this.cmdCheck.Index = 0;
			this.cmdCheck.Text = "&Шалгах";
			this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
			// 
			// con
			// 
			this.con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Projects\STraF_U\data\data.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// da
			// 
			this.da.SelectCommand = this.sqlSelect;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "dataTable", new System.Data.Common.DataColumnMapping[] {
																																																	  new System.Data.Common.DataColumnMapping("name", "name")})});
			// 
			// sqlSelect
			// 
			this.sqlSelect.Connection = this.con;
			// 
			// gridResult
			// 
			this.gridResult.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.gridResult.CaptionText = "Асуулгын үр дүн";
			this.gridResult.DataMember = "";
			this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridResult.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridResult.Location = new System.Drawing.Point(0, 227);
			this.gridResult.Name = "gridResult";
			this.gridResult.Size = new System.Drawing.Size(528, 190);
			this.gridResult.TabIndex = 0;
			this.toolTip.SetToolTip(this.gridResult, "Асуулгын үр дүнг харах хүснэгт");
			this.gridResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridResult_KeyDown);
			this.gridResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridResult_MouseDown);
			// 
			// panelSQL
			// 
			this.panelSQL.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.textSQL,
																				   this.splitterWizard,
																				   this.panelSQLWizard});
			this.panelSQL.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSQL.Name = "panelSQL";
			this.panelSQL.Size = new System.Drawing.Size(528, 224);
			this.panelSQL.TabIndex = 5;
			// 
			// textSQL
			// 
			this.textSQL.AcceptsReturn = true;
			this.textSQL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSQL.Location = new System.Drawing.Point(187, 0);
			this.textSQL.Multiline = true;
			this.textSQL.Name = "textSQL";
			this.textSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textSQL.Size = new System.Drawing.Size(341, 224);
			this.textSQL.TabIndex = 0;
			this.textSQL.Text = "";
			this.toolTip.SetToolTip(this.textSQL, "Асуулга бичих муж. Асуулгыг ажиллуулахын тулд F5 товч дар.");
			this.textSQL.TextChanged += new System.EventHandler(this.textSQL_TextChanged);
			// 
			// splitterWizard
			// 
			this.splitterWizard.Location = new System.Drawing.Point(184, 0);
			this.splitterWizard.Name = "splitterWizard";
			this.splitterWizard.Size = new System.Drawing.Size(3, 224);
			this.splitterWizard.TabIndex = 1;
			this.splitterWizard.TabStop = false;
			// 
			// panelSQLWizard
			// 
			this.panelSQLWizard.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelSQLWizard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelSQLWizard.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.buttonAddColumn,
																						 this.buttonAddTable,
																						 this.listColumn,
																						 this.label2,
																						 this.listTable,
																						 this.label1});
			this.panelSQLWizard.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSQLWizard.Name = "panelSQLWizard";
			this.panelSQLWizard.Size = new System.Drawing.Size(184, 224);
			this.panelSQLWizard.TabIndex = 0;
			// 
			// buttonAddColumn
			// 
			this.buttonAddColumn.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddColumn.Location = new System.Drawing.Point(104, 112);
			this.buttonAddColumn.Name = "buttonAddColumn";
			this.buttonAddColumn.Size = new System.Drawing.Size(64, 16);
			this.buttonAddColumn.TabIndex = 5;
			this.buttonAddColumn.Text = ">>";
			this.toolTip.SetToolTip(this.buttonAddColumn, "Баганыг асуулга руу нэмэх");
			this.buttonAddColumn.Click += new System.EventHandler(this.buttonAddColumn_Click);
			// 
			// buttonAddTable
			// 
			this.buttonAddTable.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTable.Location = new System.Drawing.Point(104, 8);
			this.buttonAddTable.Name = "buttonAddTable";
			this.buttonAddTable.Size = new System.Drawing.Size(64, 16);
			this.buttonAddTable.TabIndex = 2;
			this.buttonAddTable.Text = ">>";
			this.toolTip.SetToolTip(this.buttonAddTable, "Хүснэгтийг асуулга руу нэмэх");
			this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
			// 
			// listColumn
			// 
			this.listColumn.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.listColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listColumn.Location = new System.Drawing.Point(8, 136);
			this.listColumn.Name = "listColumn";
			this.listColumn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listColumn.Size = new System.Drawing.Size(160, 67);
			this.listColumn.TabIndex = 4;
			this.toolTip.SetToolTip(this.listColumn, "Сонгосон хүснэгтийн багануудын нэрс");
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label2.Location = new System.Drawing.Point(8, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Багана:";
			// 
			// listTable
			// 
			this.listTable.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.listTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listTable.Items.AddRange(new object[] {
														   "Advance",
														   "Herder",
														   "Loan",
														   "Poor",
														   "Prof",
														   "Region",
														   "Tax",
														   "Third",
														   "Tuition"});
			this.listTable.Location = new System.Drawing.Point(8, 28);
			this.listTable.Name = "listTable";
			this.listTable.Size = new System.Drawing.Size(164, 80);
			this.listTable.TabIndex = 1;
			this.toolTip.SetToolTip(this.listTable, "Бааз дахь хүснэгтүүдийн нэрс");
			this.listTable.SelectedIndexChanged += new System.EventHandler(this.listTable_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Хүснэгт:";
			// 
			// splitterSQL
			// 
			this.splitterSQL.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitterSQL.Location = new System.Drawing.Point(0, 224);
			this.splitterSQL.Name = "splitterSQL";
			this.splitterSQL.Size = new System.Drawing.Size(528, 3);
			this.splitterSQL.TabIndex = 6;
			this.splitterSQL.TabStop = false;
			// 
			// QueryView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 417);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gridResult,
																		  this.splitterSQL,
																		  this.panelSQL});
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuMain;
			this.Name = "QueryView";
			this.ShowInTaskbar = false;
			this.Text = "Асуулга";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Query_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Query_Closing);
			((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
			this.panelSQL.ResumeLayout(false);
			this.panelSQLWizard.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void  NewQuery() {
			filename = null;
			textSQL.Text = "";
			saved = true;
		}
		public void Open() {
			if (openDlg.ShowDialog() == DialogResult.OK) {
				try {
					filename = openDlg.FileName;
					StreamReader reader = new StreamReader(filename);
					StringWriter writer = new StringWriter();
				
					string nextLine = reader.ReadLine();
					while (nextLine != null) {
						writer.WriteLine(nextLine);
						nextLine = reader.ReadLine();
					}
					textSQL.Text = writer.ToString();
					Text = "Асуулга - " + filename;
					saved = true;
				}
				catch (Exception) {
					Straf.ShowError(openDlg.FileName + " файлыг нээж чадахгvй");
				}
			}
		}
		private void  Save() {
			if (saved) return ;
		
			if (filename == null) {
				if (saveDlg.ShowDialog() == DialogResult.OK)
					filename = saveDlg.FileName;
			}

			if (filename != null) {
				try {
					StreamWriter writer = new StreamWriter(filename);
					writer.Write(textSQL.Text);
					writer.Close();
					saved = true;
					Text = "Асуулга - " + filename;
				}
				catch (Exception) {
					Straf.ShowError("Хадгалахад алдаа гарлаа");		
				}
			}
		}
		
		private void SelectAll() {
			if (textSQL.Focused)
				textSQL.SelectAll();
			else if (gridResult.Focused) {
			}
		}
		private void textSQL_TextChanged(object sender, System.EventArgs e) {
			if (saved) {
				saved = false;
				Text += "*";
			}
		}
		private void cmdCheck_Click(object sender, System.EventArgs e) {
			try {
				con.ConnectionString = Straf.strCon;
				con.Open();
				da.SelectCommand.CommandText = textSQL.Text;
				da.SelectCommand.ExecuteNonQuery();
				MessageBox.Show("Асуулга зөв", Straf.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex) {
				Straf.ShowError("Асуулга буруу\n" + ex.Message);
			}
			finally {
				con.Close();
			}
		}
		private void Run() {
			this.Cursor = Cursors.WaitCursor;
			try {
				con.ConnectionString = Straf.strCon;
				con.Open();
				DataTable table = new DataTable("result");
				da.SelectCommand.CommandText = textSQL.Text;
				da.Fill(table);
				gridResult.SetDataBinding(table, "");
			}
			catch (Exception ex) {
				Straf.ShowError("Асуулга алдаатай :\n" + ex.Message);
			}
			finally {
				this.Cursor = Cursors.Default;
				con.Close();
			}
		}
		private void Query_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			if (saved) return;
		
			DialogResult reply = MessageBox.Show("Асуулгыг хадгалах уу ?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
		
			switch (reply) {
				case DialogResult.Yes: 
					Save();
					break;
			
				case DialogResult.No: 
					break;
			
				case DialogResult.Cancel: 
					e.Cancel = true;
					break;
			}
		}

		private void Query_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case  Keys.Control | Keys.N: 
					NewQuery(); 
					break;
			
				case  Keys.Control | Keys.O: 
					Open();
					break;
			
				case  Keys.Control | Keys.S: 
					Save(); 
					break;
			
				case  Keys.Control | Keys.A: 
					SelectAll();
					break;
			
				case  Keys.F5: 
					Run(); 
					break;

				default :
					if (ActiveControl != null)
						Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, (int)e.KeyData, 1);
					break;
			}
		}

		private void listTable_SelectedIndexChanged(object sender, System.EventArgs e) {
			int i = listTable.SelectedIndex;
			if (i != -1) {
				da.SelectCommand.CommandText = "select * from " + listTable.Items[i];
				listColumn.Items.Clear();
				try {
					con.ConnectionString = Straf.strCon;
					con.Open();
					OleDbDataReader reader = da.SelectCommand.ExecuteReader();
					for (int j=0; j < reader.FieldCount; j++) {
						listColumn.Items.Add(reader.GetName(j));
					}
				}
				catch (Exception) {
				}
				finally {
					con.Close();
				}
			}
		}

		private void buttonAddTable_Click(object sender, System.EventArgs e) {
			string sql = "";
			sql = textSQL.Text;
			if (sql.IndexOf("FROM") == -1) {
				sql += " FROM " + listTable.SelectedItem;
			}
			else {
				sql += ", " + listTable.SelectedItem;
			}
			textSQL.Text = sql;
		}

		private void buttonAddColumn_Click(object sender, System.EventArgs e) {
			string sql = "";
			sql = textSQL.Text;
			if (sql.IndexOf("SELECT") == -1) {
				sql = " SELECT " + sql;
			}
			else {
				sql += ", ";
			}
			foreach (string item in listColumn.SelectedItems) {
				sql += item + ", ";
			}
			sql = sql.Remove(sql.Length - 2, 2);
			textSQL.Text = sql;
		}

		private void gridResult_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case  Keys.Control | Keys.C: 
					GridCopy(); 
					break;
			}
		}
		private void gridResult_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				DataGrid.HitTestInfo hit;
				hit = gridResult.HitTest(e.X, e.Y);
				int hitRow = hit.Row;
				if (hitRow != -1 && gridResult.IsSelected(hitRow)) {
					DataTable table = gridResult.DataSource as DataTable;
					if (table != null) {
						string dragText = "";
						for (int i=0; i < table.Rows.Count; i++) {
							if (gridResult.IsSelected(i)) {
								for (int j=0; j < table.Columns.Count; j++) {
									dragText += table.Rows[i][j] + "\t";
								}
								dragText += "\r\n";
							}
						}
						gridResult.DoDragDrop(dragText, DragDropEffects.Copy | DragDropEffects.Move);
					}
				}
			}
		}
		private void GridCopy() {
			DataTable table = gridResult.DataSource as DataTable;
			if (table != null) {
				string strData = "";
				for (int i=0; i < table.Rows.Count; i++) {
					if (gridResult.IsSelected(i)) {
						for (int j = 0; j < table.Columns.Count; j++) {
							strData += table.Rows[i][j] + "\t";
						}
						strData += "\r\n";
					}
				}
				Clipboard.SetDataObject(strData);
			}
		}
	}
}

