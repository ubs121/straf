using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF_U {
	/// <summary>
	/// Summary description for ProfView.
	/// </summary>
	public class ProfView : Form, IStrafChild {
		private ReportProf doc;
		private string tableName;
		private OleDbConnection con;
		private BindingManagerBase bindingProf;
		private DataGridTableStyle dataGridTableStyle;
		private OleDbDataAdapter daProf;
		private DataGrid gridProf;
		private Panel panel1;
		private TextBox textT1;
		private Label label2;
		private Label label3;
		private TextBox textT4;
		private Label label4;
		private TextBox textT2;
		private Label label5;
		private TextBox textT5;
		private Label label6;
		private TextBox textT3;
		private Label label7;
		private TextBox textT6;
		private DataGridTextBoxColumn dataGridTextBoxColumnDuration;
		private GroupBox groupTuition;
		private DataGridTextBoxColumn dataGridTextBoxColumnName;
		private DataGridTextBoxColumn dataGridTextBoxColumnShort;
		private DataGridTextBoxColumn dataGridTextBoxColumnDegree;
		private ComboBox comboDegree;
		private System.Data.OleDb.OleDbDataAdapter daRegion;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ProfView() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			tableName = "Prof";
			SetBindings();
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
			this.daProf = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.gridProf = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnShort = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDegree = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDuration = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupTuition = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textT6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textT3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textT5 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textT2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textT4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textT1 = new System.Windows.Forms.TextBox();
			this.comboDegree = new System.Windows.Forms.ComboBox();
			this.daRegion = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.gridProf)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupTuition.SuspendLayout();
			this.SuspendLayout();
			// 
			// con
			// 
			this.con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Projects\STraF_U\data\data.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// daProf
			// 
			this.daProf.DeleteCommand = this.oleDbDeleteCommand1;
			this.daProf.InsertCommand = this.oleDbInsertCommand1;
			this.daProf.SelectCommand = this.oleDbSelectCommand1;
			this.daProf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							 new System.Data.Common.DataTableMapping("Table", "Prof", new System.Data.Common.DataColumnMapping[] {
																																																	 new System.Data.Common.DataColumnMapping("degree", "degree"),
																																																	 new System.Data.Common.DataColumnMapping("duration", "duration"),
																																																	 new System.Data.Common.DataColumnMapping("name", "name"),
																																																	 new System.Data.Common.DataColumnMapping("shortname", "shortname"),
																																																	 new System.Data.Common.DataColumnMapping("t1", "t1"),
																																																	 new System.Data.Common.DataColumnMapping("t2", "t2"),
																																																	 new System.Data.Common.DataColumnMapping("t3", "t3"),
																																																	 new System.Data.Common.DataColumnMapping("t4", "t4"),
																																																	 new System.Data.Common.DataColumnMapping("t5", "t5"),
																																																	 new System.Data.Common.DataColumnMapping("t6", "t6")})});
			this.daProf.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Prof WHERE (shortname = ?)";
			this.oleDbDeleteCommand1.Connection = this.con;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_shortname", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "shortname", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Prof(degree, duration, name, shortname, t1, t2, t3, t4, t5, t6) VALUE" +
				"S (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.con;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("degree", System.Data.OleDb.OleDbType.VarWChar, 20, "degree"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("duration", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "duration", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 30, "name"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("shortname", System.Data.OleDb.OleDbType.VarWChar, 10, "shortname"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t1", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t2", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t2", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t3", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t3", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t4", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t4", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t5", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t5", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t6", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t6", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT degree, duration, name, shortname, t1, t2, t3, t4, t5, t6 FROM Prof";
			this.oleDbSelectCommand1.Connection = this.con;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Prof SET degree = ?, duration = ?, name = ?, shortname = ?, t1 = ?, t2 = ?" +
				", t3 = ?, t4 = ?, t5 = ?, t6 = ? WHERE (shortname = ?)";
			this.oleDbUpdateCommand1.Connection = this.con;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("degree", System.Data.OleDb.OleDbType.VarWChar, 20, "degree"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("duration", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "duration", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 30, "name"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("shortname", System.Data.OleDb.OleDbType.VarWChar, 10, "shortname"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t1", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t2", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t2", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t3", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t3", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t4", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t4", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t5", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t5", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("t6", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "t6", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_shortname", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "shortname", System.Data.DataRowVersion.Original, null));
			// 
			// gridProf
			// 
			this.gridProf.BackgroundColor = System.Drawing.Color.DarkGray;
			this.gridProf.CaptionVisible = false;
			this.gridProf.DataMember = "";
			this.gridProf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridProf.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridProf.Name = "gridProf";
			this.gridProf.Size = new System.Drawing.Size(560, 413);
			this.gridProf.TabIndex = 0;
			this.gridProf.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								 this.dataGridTableStyle});
			this.gridProf.Resize += new System.EventHandler(this.gridProf_Resize);
			this.gridProf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridProf_MouseDown);
			this.gridProf.CurrentCellChanged += new System.EventHandler(this.gridProf_CurrentCellChanged);
			this.gridProf.Scroll += new System.EventHandler(this.gridProf_Scroll);
			this.gridProf.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridProf_DragEnter);
			// 
			// dataGridTableStyle
			// 
			this.dataGridTableStyle.DataGrid = this.gridProf;
			this.dataGridTableStyle.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												 this.dataGridTextBoxColumnShort,
																												 this.dataGridTextBoxColumnName,
																												 this.dataGridTextBoxColumnDegree,
																												 this.dataGridTextBoxColumnDuration});
			this.dataGridTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle.MappingName = "Prof";
			// 
			// dataGridTextBoxColumnShort
			// 
			this.dataGridTextBoxColumnShort.Format = "";
			this.dataGridTextBoxColumnShort.FormatInfo = null;
			this.dataGridTextBoxColumnShort.HeaderText = "Товч нэр";
			this.dataGridTextBoxColumnShort.MappingName = "shortname";
			this.dataGridTextBoxColumnShort.Width = 75;
			// 
			// dataGridTextBoxColumnName
			// 
			this.dataGridTextBoxColumnName.Format = "";
			this.dataGridTextBoxColumnName.FormatInfo = null;
			this.dataGridTextBoxColumnName.HeaderText = "Мэргэжил";
			this.dataGridTextBoxColumnName.MappingName = "name";
			this.dataGridTextBoxColumnName.Width = 300;
			// 
			// dataGridTextBoxColumnDegree
			// 
			this.dataGridTextBoxColumnDegree.Format = "";
			this.dataGridTextBoxColumnDegree.FormatInfo = null;
			this.dataGridTextBoxColumnDegree.HeaderText = "Сургалтын түвшин";
			this.dataGridTextBoxColumnDegree.MappingName = "degree";
			this.dataGridTextBoxColumnDegree.Width = 120;
			// 
			// dataGridTextBoxColumnDuration
			// 
			this.dataGridTextBoxColumnDuration.Format = "";
			this.dataGridTextBoxColumnDuration.FormatInfo = null;
			this.dataGridTextBoxColumnDuration.HeaderText = "Суралцах хугацаа";
			this.dataGridTextBoxColumnDuration.MappingName = "duration";
			this.dataGridTextBoxColumnDuration.Width = 75;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.groupTuition});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 325);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 88);
			this.panel1.TabIndex = 1;
			// 
			// groupTuition
			// 
			this.groupTuition.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.label7,
																					   this.textT6,
																					   this.label6,
																					   this.textT3,
																					   this.label5,
																					   this.textT5,
																					   this.label4,
																					   this.textT2,
																					   this.label3,
																					   this.textT4,
																					   this.label2,
																					   this.textT1});
			this.groupTuition.Location = new System.Drawing.Point(8, 8);
			this.groupTuition.Name = "groupTuition";
			this.groupTuition.Size = new System.Drawing.Size(528, 72);
			this.groupTuition.TabIndex = 0;
			this.groupTuition.TabStop = false;
			this.groupTuition.Text = " Төлбөр ";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(368, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "6 курс:";
			// 
			// textT6
			// 
			this.textT6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textT6.Location = new System.Drawing.Point(416, 40);
			this.textT6.Name = "textT6";
			this.textT6.TabIndex = 11;
			this.textT6.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(176, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "3 курс:";
			// 
			// textT3
			// 
			this.textT3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textT3.Location = new System.Drawing.Point(224, 16);
			this.textT3.Name = "textT3";
			this.textT3.TabIndex = 5;
			this.textT3.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(368, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "5 курс:";
			// 
			// textT5
			// 
			this.textT5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textT5.Location = new System.Drawing.Point(416, 16);
			this.textT5.Name = "textT5";
			this.textT5.TabIndex = 9;
			this.textT5.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "2 курс:";
			// 
			// textT2
			// 
			this.textT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textT2.Location = new System.Drawing.Point(56, 40);
			this.textT2.Name = "textT2";
			this.textT2.TabIndex = 3;
			this.textT2.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(176, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "4 курс:";
			// 
			// textT4
			// 
			this.textT4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textT4.Location = new System.Drawing.Point(224, 40);
			this.textT4.Name = "textT4";
			this.textT4.TabIndex = 7;
			this.textT4.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "1 курс:";
			// 
			// textT1
			// 
			this.textT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textT1.Location = new System.Drawing.Point(56, 16);
			this.textT1.Name = "textT1";
			this.textT1.TabIndex = 1;
			this.textT1.Text = "";
			// 
			// comboDegree
			// 
			this.comboDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDegree.Items.AddRange(new object[] {
															 "дипломын",
															 "бакалаврын",
															 "магистрын",
															 "аспирантын",
															 "докторын"});
			this.comboDegree.Location = new System.Drawing.Point(192, 96);
			this.comboDegree.Name = "comboDegree";
			this.comboDegree.Size = new System.Drawing.Size(121, 21);
			this.comboDegree.TabIndex = 2;
			this.comboDegree.Visible = false;
			// 
			// daRegion
			// 
			this.daRegion.SelectCommand = this.oleDbSelectCommand2;
			this.daRegion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							   new System.Data.Common.DataTableMapping("Table", "Region", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("id", "id"),
																																																		 new System.Data.Common.DataColumnMapping("name", "name")})});
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT id, name FROM Region";
			this.oleDbSelectCommand2.Connection = this.con;
			// 
			// ProfView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 413);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboDegree,
																		  this.panel1,
																		  this.gridProf});
			this.Name = "ProfView";
			this.Text = "Мэргэжлvvд";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfView_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gridProf)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupTuition.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		public ReportDocument GetDocument() {
			if (doc == null) {
				doc = new ReportProf();
				doc.SetDataSource(Straf.datasetGlobal);
			}
			return doc;
		}
		
		private void ProfView_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.S: 
					UpdateData(); 
					break;
				
				case Keys.Control | Keys.C: 
					Copy(sender, e); 
					break;
			
				case Keys.Control | Keys.X: 
					Cut(sender, e); 
					break;
					
				case Keys.Control | Keys.V: 
					Paste(sender, e); 
					break;
				
				case Keys.Control | Keys.Z: 
					Undo(); 
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
						Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, (int)e.KeyData, 1);
					break;
			}
		}
		private void MoveFirst() {
			bindingProf.Position = 0;
		}
		private void MovePrev() {
			bindingProf.Position -= 1;
		}
		private void MoveNext() {
			bindingProf.Position += 1;
		}
		private void MoveLast() {
			bindingProf.Position = bindingProf.Count - 1;
		}
		private void GoTo() {
			GotoDlg dlg = new GotoDlg();
			dlg.labelTitle.Text = "Байрлал: (1 - " + bindingProf.Count + ")";
			if (dlg.ShowDialog() == DialogResult.OK) {
				try {
					int no;
					no = Convert.ToInt32(dlg.textPos.Text);
					bindingProf.Position = no - 1;
				}
				catch (Exception) {}
			}
		}
		private void gridProf_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				DataGrid.HitTestInfo hit;
				hit = gridProf.HitTest(e.X, e.Y);
				int hitRow = hit.Row;
				if (hitRow != -1 && gridProf.IsSelected(hitRow)) {
					string dragText = "";
					int i = 0;
					foreach (DataRow row in Straf.datasetGlobal.Prof.Rows) {
						if (gridProf.IsSelected(i))
							dragText += row["shortname"] + "\r\n";
						i++;
					}
					gridProf.DoDragDrop(dragText, DragDropEffects.Copy | DragDropEffects.Move);
				}
			}
		}

		private void gridProf_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(typeof(DataRow))) 
				e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
			else if (e.Data.GetDataPresent(DataFormats.Text)) 
				e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}
		private void bindingProf_PositionChanged(object sender, EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				parent.statusRecord.Text = string.Format("{0}/{1}", bindingProf.Position + 1, bindingProf.Count);
			}
		}
		private void gridProf_CurrentCellChanged(object sender, System.EventArgs e) {
			DataGridCell cell = gridProf.CurrentCell;
			if (cell.ColumnNumber == 2) {
				Rectangle rect = gridProf.GetCurrentCellBounds();
				comboDegree.SetBounds(rect.X, rect.Y, rect.Width, rect.Height);
				comboDegree.SelectedItem = gridProf[cell];
				comboDegree.Show();
			}
			else {
				comboDegree.Hide();
			}
		}
		private void gridProf_Resize(object sender, System.EventArgs e) {
			comboDegree.Hide();
		}

		private void gridProf_Scroll(object sender, System.EventArgs e) {
			comboDegree.Hide();
		}

		#region Өгөгдөлтэй ажиллах
		private void SetBindings() {
			bindingProf = this.BindingContext[Straf.datasetGlobal, tableName];
			bindingProf.PositionChanged += new EventHandler(bindingProf_PositionChanged);
			comboDegree.DataBindings.Add("SelectedItem", Straf.datasetGlobal, tableName + ".degree");
			textT1.DataBindings.Add("Text", Straf.datasetGlobal, tableName + ".t1");
			textT2.DataBindings.Add("Text", Straf.datasetGlobal, tableName + ".t2");
			textT3.DataBindings.Add("Text", Straf.datasetGlobal, tableName + ".t3");
			textT4.DataBindings.Add("Text", Straf.datasetGlobal, tableName + ".t4");
			textT5.DataBindings.Add("Text", Straf.datasetGlobal, tableName + ".t5");
			textT6.DataBindings.Add("Text", Straf.datasetGlobal, tableName + ".t6");
		}
		public void FillDataSet(DatasetGlobal dataset) {
			dataset.EnforceConstraints = false;
			try {
				con.ConnectionString = Straf.strCon;
				con.Open();
				daProf.Fill(dataset);
				daRegion.Fill(dataset);
			}
			catch (Exception fillException) {
				// Add your error handling code here.
				throw fillException;
			}
			finally {
				dataset.EnforceConstraints = true;
				con.Close();
			}

		}
		private void LoadDataSet() {
			DatasetGlobal tempSet;
			tempSet = new DatasetGlobal();
			try {
				FillDataSet(tempSet);
			}
			catch (Exception eFillDataSet) {
				// Add your error handling code here.
				throw eFillDataSet;
			}
			try {
				Straf.datasetGlobal.Clear();
				Straf.datasetGlobal.Merge(tempSet);
			}
			catch (Exception eLoadMerge) {
				// Add your error handling code here.
				throw eLoadMerge;
			}
		}
		public void UpdateDataSource(DatasetGlobal ChangedRows) {
			try {
				if (ChangedRows != null) {
					con.ConnectionString = Straf.strCon;
					con.Open();
					daProf.Update(ChangedRows);
				}
			}
			catch (Exception updateException) {
				// Add your error handling code here.
				throw updateException;
			}
			finally {
				con.Close();
			}

		}
		public void UpdateDataSet() {
			DatasetGlobal changedSet = new DatasetGlobal();
			this.BindingContext[Straf.datasetGlobal, tableName].EndCurrentEdit();
			
			changedSet = ((DatasetGlobal)(Straf.datasetGlobal.GetChanges()));
			
			if (changedSet != null) {
				try {
					UpdateDataSource(changedSet);
					Straf.datasetGlobal.Merge(changedSet);
					Straf.datasetGlobal.AcceptChanges();
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
			Cursor.Current = Cursors.WaitCursor;
			try {
				LoadDataSet();
				gridProf.SetDataBinding(Straf.datasetGlobal, "Prof");
			}
			catch (Exception eLoad) {
				// Add your error handling code here.
				
				Straf.ShowError(eLoad.Message);
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}
		public void UpdateData() {
			Cursor.Current = Cursors.WaitCursor;
			try {
				UpdateDataSet();
				gridProf.SetDataBinding(Straf.datasetGlobal, "Prof");
			}
			catch (Exception eUpdate) {
				// Add your error handling code here.
				
				Straf.ShowError(eUpdate.Message);
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}
		#endregion

		#region Засах цэс
		private void Undo() {
			Straf.datasetGlobal.RejectChanges();
		}
		private void Copy(object sender, System.EventArgs e) {
			string strData = "";
			for (int i=0; i < Straf.datasetGlobal.Prof.Rows.Count; i++) {
				if (gridProf.IsSelected(i)) {
					for (int j = 1; j < Straf.datasetGlobal.Prof.Columns.Count; j++) {
						strData += Straf.datasetGlobal.Prof.DefaultView[i].Row[j] + "\t";
					}
					strData += "\r\n";
				}
			}
			Clipboard.SetDataObject(strData);
		}
		private void Cut(object sender, System.EventArgs e) {
			Copy(sender, e);
			Win32.SendMessage(gridProf.Handle, 0x0100 /*WM_KEYDOWN*/, (int) Keys.Delete, 1);
		}
		private void Paste(object sender, System.EventArgs e) {
			IDataObject iData = Clipboard.GetDataObject();

			if (iData.GetDataPresent(typeof(string))) {
				Cursor.Current = Cursors.WaitCursor;
				Straf.datasetGlobal.EnforceConstraints = false;
				string strData = (string) iData.GetData(typeof(string));
				try {
					string[] lines = strData.Split(new Char[] {'\n'});
					ArrayList rows = new ArrayList();
					for (int i=0; i<lines.Length;i++) {
						string line = lines[i].Trim(new Char[]{'\r'});
						if (line != "") {
							DataRow row = Straf.datasetGlobal.Prof.NewRow();
							string[] words = line.Split(new Char[] {'\t'}, Straf.datasetGlobal.Prof.Columns.Count);
							int j = 0;
							while (j < 3 && j < words.Length) {
								try {
									row[j + 1] = words[j];
								}
								catch (Exception) {}
								j++;
							}
							rows.Add(row);
						}
					}
					IEnumerator irow = rows.GetEnumerator();
					while ( irow.MoveNext() )
						Straf.datasetGlobal.Prof.Rows.Add((DataRow) irow.Current);
				}
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
				finally {
					Cursor.Current = Cursors.Default;
					Straf.datasetGlobal.EnforceConstraints = true;
				}
			}
			else {
				MessageBox.Show("Clipboard-с өгөгдлийг авч чадахгүй", Straf.appName);
			}
		}
		public int Find(object search, bool regular, bool back) {
			int step = 1;
			if (back) step = -1;
			
			int row = gridProf.CurrentRowIndex;
			int col = gridProf.CurrentCell.ColumnNumber;
			string source, data;
			source = Convert.ToString(search);
			source = source.ToUpper();
			
			row += step;
			if (regular) {
				while (0 <= row && row < Straf.datasetGlobal.Prof.Count) {
					data = Convert.ToString(gridProf[row, col]);
					data = data.ToUpper();
					if (data.StartsWith(source))
						break;
					row += step;
				}
			}
			else {
				while (0<=row && row < Straf.datasetGlobal.Prof.Count) {
					data = Convert.ToString(gridProf[row, col]);
					data = data.ToUpper();
					if (data == source)
						break;
					row += step;
				}
			}
			if (0 <= row && row < Straf.datasetGlobal.Prof.Count) {
				gridProf.CurrentRowIndex = row;
				gridProf.Select(row);
			}
			else
				row = -1;

			return row;
		}
		public int Replace(object search, object replace, bool regular, bool back) {
			int row = Find(search, regular, back);

			if (0 <= row && row < Straf.datasetGlobal.Prof.Count) {
				gridProf.UnSelect(row);
				try {
					gridProf.CurrentRowIndex = row;
					int col;
					col = gridProf.CurrentCell.ColumnNumber;	
					string data = gridProf[row, col].ToString();
					string colName = gridProf.TableStyles[0].GridColumnStyles[col].MappingName;
					string strReplace = Convert.ToString(replace);
					data = data.Replace(data, strReplace);
					Straf.datasetGlobal.Prof[row].BeginEdit();
					Straf.datasetGlobal.Prof[row][colName] = data;
					Straf.datasetGlobal.Prof[row].EndEdit();
				}
				catch (Exception) {
					MessageBox.Show("Солиход алдаа гарлаа.", Straf.appName);
				}
			}
			else
				row = -1;

			return row;
		}
		#endregion
	}
}

