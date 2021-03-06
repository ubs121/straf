using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace STraF {
	public class ImportDlg : Form {
		internal ComboBox comboSchool;
		internal Label label1;
		internal Button buttonCancel;
		internal Button buttonOk;
		internal Label label2;
		internal Button buttonBrowse;
		internal Label label3;
		internal TextBox textFileName;
		internal ComboBox comboPType;
		private SqlConnection con;
		private DataTable tableSchool;
		private DataColumn dataColumnSchoolID;
		private DataColumn dataColumnSchoolName;
		private SqlDataAdapter daSchool;
		private SqlCommand sqlSelectSchool;
		private SqlCommand sqlInsertCommand1;
		private SqlCommand sqlUpdateCommand1;
		private SqlDataAdapter daStudent;
		private DataTable tableStudent;
		private DataColumn dataColumnID;
		private DataColumn dataColumnFName;
		private DataColumn dataColumnLName;
		private DataColumn dataColumnGender;
		private DataColumn dataColumnPasNo;
		private DataColumn dataColumnRegNo;
		private DataColumn dataColumnPType;
		private DataColumn dataColumnSchool;
		private DataColumn dataColumnDegree;
		private DataColumn dataColumnProf;
		private DataColumn dataColumnGrade;
		private DataColumn dataColumnGPA;
		private DataColumn dataColumnRegion;
		private DataColumn dataColumnAdmisNo;
		private DataColumn dataColumnRegDate;
		private DataColumn dataColumnDuration;
		private DataColumn dataColumnTuition;
		private DataColumn dataColumnEndDate;
		private DataColumn dataColumnDiplomaNo;
		private DataColumn dataColumnTransfered;
		private DataColumn dataColumnState;
		private DataColumn dataColumnNote;
		internal OpenFileDialog openDlg;
		private System.Data.DataSet dataSet;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		internal System.ComponentModel.Container components = null;

		public ImportDlg(int school, int ptype) : base() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			try {
				if (Straf.logged) {
					con.ConnectionString = Straf.strCon;
					con.Open();
					if (school > 0) {
						comboSchool.SelectedValue = school;
						comboSchool.Enabled = false;
					}
					else {
						FillSchool();
					}
					if (ptype > 0) {
						comboPType.SelectedIndex = ptype - 1;
					}
					else {
						comboPType.SelectedIndex = 0;
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected  override void  Dispose(bool disposing) {
			base.Dispose(true);
			if (disposing) {
				if (components != null)
					components.Dispose();
			}
		}
		private void FillSchool() {
			this.Cursor = Cursors.WaitCursor;
			dataSet.EnforceConstraints = false;
			tableSchool.Clear();
			try {
				daSchool.Fill(dataSet, "School");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				dataSet.EnforceConstraints = true;
				this.Cursor = Cursors.Default;
			}
		}
		private void  buttonBrowse_click(object source, System.EventArgs e) {
			if (openDlg.ShowDialog() == DialogResult.OK) {
				textFileName.Text = openDlg.FileName;
			}
		}
		private void  textFileName_textChanged(object source, EventArgs e) {
			if (textFileName.Text != "") {
				buttonOk.Enabled = true;
			}
			else {
				buttonOk.Enabled = false;
			}
		}
	#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
	
		private void  InitializeComponent() {
			this.comboSchool = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textFileName = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.openDlg = new System.Windows.Forms.OpenFileDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.comboPType = new System.Windows.Forms.ComboBox();
			this.con = new System.Data.SqlClient.SqlConnection();
			this.dataSet = new System.Data.DataSet();
			this.tableSchool = new System.Data.DataTable();
			this.dataColumnSchoolID = new System.Data.DataColumn();
			this.dataColumnSchoolName = new System.Data.DataColumn();
			this.tableStudent = new System.Data.DataTable();
			this.dataColumnID = new System.Data.DataColumn();
			this.dataColumnFName = new System.Data.DataColumn();
			this.dataColumnLName = new System.Data.DataColumn();
			this.dataColumnGender = new System.Data.DataColumn();
			this.dataColumnPasNo = new System.Data.DataColumn();
			this.dataColumnRegNo = new System.Data.DataColumn();
			this.dataColumnPType = new System.Data.DataColumn();
			this.dataColumnSchool = new System.Data.DataColumn();
			this.dataColumnDegree = new System.Data.DataColumn();
			this.dataColumnProf = new System.Data.DataColumn();
			this.dataColumnGrade = new System.Data.DataColumn();
			this.dataColumnGPA = new System.Data.DataColumn();
			this.dataColumnRegion = new System.Data.DataColumn();
			this.dataColumnAdmisNo = new System.Data.DataColumn();
			this.dataColumnRegDate = new System.Data.DataColumn();
			this.dataColumnDuration = new System.Data.DataColumn();
			this.dataColumnTuition = new System.Data.DataColumn();
			this.dataColumnEndDate = new System.Data.DataColumn();
			this.dataColumnDiplomaNo = new System.Data.DataColumn();
			this.dataColumnTransfered = new System.Data.DataColumn();
			this.dataColumnState = new System.Data.DataColumn();
			this.dataColumnNote = new System.Data.DataColumn();
			this.daSchool = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectSchool = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.daStudent = new System.Data.SqlClient.SqlDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableSchool)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// comboSchool
			// 
			this.comboSchool.DataSource = this.tableSchool;
			this.comboSchool.DisplayMember = "name";
			this.comboSchool.Location = new System.Drawing.Point(72, 8);
			this.comboSchool.Name = "comboSchool";
			this.comboSchool.Size = new System.Drawing.Size(160, 21);
			this.comboSchool.TabIndex = 3;
			this.comboSchool.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
			this.comboSchool.ValueMember = "id";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Сургууль:";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(248, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Cancel";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Enabled = false;
			this.buttonOk.Location = new System.Drawing.Point(248, 8);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "Ok";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Файл:";
			// 
			// textFileName
			// 
			this.textFileName.Location = new System.Drawing.Point(72, 96);
			this.textFileName.Name = "textFileName";
			this.textFileName.Size = new System.Drawing.Size(160, 20);
			this.textFileName.TabIndex = 1;
			this.textFileName.Text = "";
			this.textFileName.TextChanged += new System.EventHandler(this.textFileName_textChanged);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(248, 96);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.TabIndex = 7;
			this.buttonBrowse.Text = "&Browse...";
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_click);
			// 
			// openDlg
			// 
			this.openDlg.DefaultExt = "xls";
			this.openDlg.Filter = "Excel файлууд (*.xls)|*.xls";
			this.openDlg.Title = "Өгөгдлийн файл";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Хэлбэр:";
			// 
			// comboPType
			// 
			this.comboPType.Items.AddRange(new object[] {
															"зээл",
															"буцалтгvй тусламж",
															"гуравдагч",
															"тах",
															"малчны",
															"ядуу өрхийн",
															"шагнал/олимпиад",
															"гадаад"});
			this.comboPType.Location = new System.Drawing.Point(72, 40);
			this.comboPType.Name = "comboPType";
			this.comboPType.Size = new System.Drawing.Size(160, 21);
			this.comboPType.TabIndex = 11;
			// 
			// con
			// 
			this.con.ConnectionString = "data source=uugan;initial catalog=STraF;password=joker;persist security info=True" +
				";user id=sa;workstation id=UUGAN;packet size=4096";
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "NewDataSet";
			this.dataSet.Locale = new System.Globalization.CultureInfo("mn-MN");
			this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
																		 this.tableSchool,
																		 this.tableStudent});
			// 
			// tableSchool
			// 
			this.tableSchool.Columns.AddRange(new System.Data.DataColumn[] {
																			   this.dataColumnSchoolID,
																			   this.dataColumnSchoolName});
			this.tableSchool.TableName = "School";
			// 
			// dataColumnSchoolID
			// 
			this.dataColumnSchoolID.ColumnName = "id";
			this.dataColumnSchoolID.DataType = typeof(int);
			// 
			// dataColumnSchoolName
			// 
			this.dataColumnSchoolName.ColumnName = "name";
			// 
			// tableStudent
			// 
			this.tableStudent.Columns.AddRange(new System.Data.DataColumn[] {
																				this.dataColumnID,
																				this.dataColumnFName,
																				this.dataColumnLName,
																				this.dataColumnGender,
																				this.dataColumnPasNo,
																				this.dataColumnRegNo,
																				this.dataColumnPType,
																				this.dataColumnSchool,
																				this.dataColumnDegree,
																				this.dataColumnProf,
																				this.dataColumnGrade,
																				this.dataColumnGPA,
																				this.dataColumnRegion,
																				this.dataColumnAdmisNo,
																				this.dataColumnRegDate,
																				this.dataColumnDuration,
																				this.dataColumnTuition,
																				this.dataColumnEndDate,
																				this.dataColumnDiplomaNo,
																				this.dataColumnTransfered,
																				this.dataColumnState,
																				this.dataColumnNote});
			this.tableStudent.TableName = "Student";
			// 
			// dataColumnID
			// 
			this.dataColumnID.AllowDBNull = false;
			this.dataColumnID.AutoIncrement = true;
			this.dataColumnID.ColumnName = "id";
			this.dataColumnID.DataType = typeof(int);
			// 
			// dataColumnFName
			// 
			this.dataColumnFName.ColumnName = "fname";
			this.dataColumnFName.MaxLength = 20;
			// 
			// dataColumnLName
			// 
			this.dataColumnLName.ColumnName = "lname";
			this.dataColumnLName.MaxLength = 20;
			// 
			// dataColumnGender
			// 
			this.dataColumnGender.ColumnName = "gender";
			this.dataColumnGender.DefaultValue = "эр";
			this.dataColumnGender.MaxLength = 2;
			// 
			// dataColumnPasNo
			// 
			this.dataColumnPasNo.ColumnName = "pasno";
			this.dataColumnPasNo.MaxLength = 10;
			// 
			// dataColumnRegNo
			// 
			this.dataColumnRegNo.ColumnName = "regno";
			this.dataColumnRegNo.MaxLength = 10;
			// 
			// dataColumnPType
			// 
			this.dataColumnPType.ColumnName = "ptype";
			this.dataColumnPType.DataType = typeof(System.Byte);
			this.dataColumnPType.DefaultValue = ((System.Byte)(1));
			// 
			// dataColumnSchool
			// 
			this.dataColumnSchool.ColumnName = "school";
			this.dataColumnSchool.DataType = typeof(int);
			// 
			// dataColumnDegree
			// 
			this.dataColumnDegree.ColumnName = "degree";
			this.dataColumnDegree.DataType = typeof(System.Byte);
			this.dataColumnDegree.DefaultValue = ((System.Byte)(1));
			// 
			// dataColumnProf
			// 
			this.dataColumnProf.ColumnName = "prof";
			this.dataColumnProf.MaxLength = 20;
			// 
			// dataColumnGrade
			// 
			this.dataColumnGrade.ColumnName = "grade";
			this.dataColumnGrade.DataType = typeof(System.Byte);
			this.dataColumnGrade.DefaultValue = ((System.Byte)(1));
			// 
			// dataColumnGPA
			// 
			this.dataColumnGPA.ColumnName = "gpa";
			this.dataColumnGPA.DataType = typeof(System.Byte);
			this.dataColumnGPA.DefaultValue = ((System.Byte)(0));
			// 
			// dataColumnRegion
			// 
			this.dataColumnRegion.ColumnName = "region";
			this.dataColumnRegion.DataType = typeof(int);
			this.dataColumnRegion.DefaultValue = 20;
			// 
			// dataColumnAdmisNo
			// 
			this.dataColumnAdmisNo.ColumnName = "admisno";
			this.dataColumnAdmisNo.MaxLength = 10;
			// 
			// dataColumnRegDate
			// 
			this.dataColumnRegDate.ColumnName = "regdate";
			this.dataColumnRegDate.DataType = typeof(System.DateTime);
			// 
			// dataColumnDuration
			// 
			this.dataColumnDuration.ColumnName = "duration";
			this.dataColumnDuration.DataType = typeof(System.Byte);
			this.dataColumnDuration.DefaultValue = ((System.Byte)(4));
			// 
			// dataColumnTuition
			// 
			this.dataColumnTuition.ColumnName = "tuition";
			this.dataColumnTuition.DataType = typeof(System.Single);
			this.dataColumnTuition.DefaultValue = 0F;
			// 
			// dataColumnEndDate
			// 
			this.dataColumnEndDate.ColumnName = "enddate";
			this.dataColumnEndDate.DataType = typeof(System.DateTime);
			// 
			// dataColumnDiplomaNo
			// 
			this.dataColumnDiplomaNo.ColumnName = "diplomano";
			this.dataColumnDiplomaNo.MaxLength = 10;
			// 
			// dataColumnTransfered
			// 
			this.dataColumnTransfered.ColumnName = "transfered";
			this.dataColumnTransfered.DataType = typeof(System.Single);
			this.dataColumnTransfered.DefaultValue = 0F;
			// 
			// dataColumnState
			// 
			this.dataColumnState.ColumnName = "state";
			this.dataColumnState.DataType = typeof(System.Byte);
			this.dataColumnState.DefaultValue = ((System.Byte)(1));
			// 
			// dataColumnNote
			// 
			this.dataColumnNote.ColumnName = "note";
			this.dataColumnNote.MaxLength = 50;
			// 
			// daSchool
			// 
			this.daSchool.SelectCommand = this.sqlSelectSchool;
			// 
			// sqlSelectSchool
			// 
			this.sqlSelectSchool.CommandText = "SELECT id, name FROM School";
			this.sqlSelectSchool.Connection = this.con;
			// 
			// daStudent
			// 
			this.daStudent.InsertCommand = this.sqlInsertCommand1;
			this.daStudent.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// ImportDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(336, 141);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label3,
																		  this.comboPType,
																		  this.buttonBrowse,
																		  this.textFileName,
																		  this.label2,
																		  this.buttonCancel,
																		  this.buttonOk,
																		  this.label1,
																		  this.comboSchool});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImportDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Импорт";
			this.TextChanged += new System.EventHandler(this.textFileName_textChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableSchool)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
			this.ResumeLayout(false);

		}
	#endregion
	}
}

