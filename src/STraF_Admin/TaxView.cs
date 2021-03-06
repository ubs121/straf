using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF {
	/// <summary>
	/// Summary description for Student.
	/// </summary>
	public class TaxView : Form, IStudentChild {
		private MenuItem cmdPromote;
		private MenuItem cmdCheck;
		private MenuItem cmdGrade;
		private MenuItem menuStudent;
		private MenuItem menuItem1;
		private MenuItem cmdSetState;
		private MenuItem cmdAvl;
		private MenuItem cmdAbsent;
		private MenuItem cmdCancel;
		private DataGridTextBoxColumn colClass;
		private MainMenu menuMain;
		private System.Data.SqlClient.SqlConnection con;
		private TabControl tabDetail;
		private TabPage pageMain;
		private DateTimePicker dateRegDate;
		private TabPage pageDoc;
		private Splitter splitter1;
		private DataSet dataSet;
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
		private DataColumn dataColumnPaReg;
		private DataColumn dataColumnMaReg;
		private DataColumn dataColumnContract;
		private DataColumn dataColumnName;
		private DataColumn dataColumnOrg;
		private DataColumn dataColumnPos;
		private DataGridTableStyle dataGridTableStyle;
		private DataGridTextBoxColumn dataGridTextBoxColumnLName;
		private DataGridTextBoxColumn dataGridTextBoxColumnFName;
		private DataGridTextBoxColumn dataGridTextBoxColumnPasNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnRegNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnProf;
		private DataGridTextBoxColumn dataGridTextBoxColumnGrade;
		private DataGridTextBoxColumn dataGridTextBoxColumnGPA;
		private DataGridTextBoxColumn dataGridTextBoxColumnAdmisNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnNote;
		private Label labelTuition;
		private Label labelDuration;
		private Label labelRegDate;
		private System.Data.DataTable tableDegree;
		private System.Data.DataColumn dataColumnDegreeID;
		private System.Data.DataColumn dataColumnDegreeDesc;
		private DataGrid gridStudent;
		private Label label2;
		private ComboBox comboRegion;
		private System.Data.DataTable tableRegion;
		private System.Data.SqlClient.SqlDataAdapter daRegion;
		private Label label12;
		private ComboBox comboDegree;
		private TextBox textTuition;
		private TextBox textDuration;
		private System.Data.SqlClient.SqlCommand sqlSelectRegion;
		private System.Data.SqlClient.SqlCommand sqlSelectStudent;
		private System.Data.SqlClient.SqlCommand sqlInsertStudent;
		private System.Data.SqlClient.SqlCommand sqlUpdateStudent;
		private System.Data.SqlClient.SqlCommand sqlDeleteStudent;
		private System.Data.SqlClient.SqlDataAdapter daStudent;
		private System.Data.DataColumn dataColumnRegionID;
		private System.Data.DataColumn dataColumnRegionName;
		private DataGridTextBoxColumn dataGridTextBoxColumnGender;
		private GroupBox groupBox3;
		private Label label24;
		private Label label23;
		private TextBox textTaxName;
		private Label label22;
		private TextBox textTaxPos;
		private CheckBox checkTaxContract;
		private Label label25;
		private Label label28;
		private TextBox textTaxPaReg;
		private TextBox textTaxMaReg;
		private TextBox textTaxOrg;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TaxView() {
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
					LoadData();
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TaxView));
			this.cmdPromote = new System.Windows.Forms.MenuItem();
			this.cmdCheck = new System.Windows.Forms.MenuItem();
			this.cmdGrade = new System.Windows.Forms.MenuItem();
			this.menuStudent = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.cmdSetState = new System.Windows.Forms.MenuItem();
			this.cmdAvl = new System.Windows.Forms.MenuItem();
			this.cmdAbsent = new System.Windows.Forms.MenuItem();
			this.cmdCancel = new System.Windows.Forms.MenuItem();
			this.colClass = new System.Windows.Forms.DataGridTextBoxColumn();
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.gridStudent = new System.Windows.Forms.DataGrid();
			this.dataSet = new System.Data.DataSet();
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
			this.dataColumnPaReg = new System.Data.DataColumn();
			this.dataColumnMaReg = new System.Data.DataColumn();
			this.dataColumnContract = new System.Data.DataColumn();
			this.dataColumnName = new System.Data.DataColumn();
			this.dataColumnOrg = new System.Data.DataColumn();
			this.dataColumnPos = new System.Data.DataColumn();
			this.tableDegree = new System.Data.DataTable();
			this.dataColumnDegreeID = new System.Data.DataColumn();
			this.dataColumnDegreeDesc = new System.Data.DataColumn();
			this.tableRegion = new System.Data.DataTable();
			this.dataColumnRegionID = new System.Data.DataColumn();
			this.dataColumnRegionName = new System.Data.DataColumn();
			this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnLName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGender = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPasNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRegNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnProf = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGrade = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGPA = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAdmisNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnNote = new System.Windows.Forms.DataGridTextBoxColumn();
			this.con = new System.Data.SqlClient.SqlConnection();
			this.daStudent = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteStudent = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertStudent = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectStudent = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateStudent = new System.Data.SqlClient.SqlCommand();
			this.tabDetail = new System.Windows.Forms.TabControl();
			this.pageMain = new System.Windows.Forms.TabPage();
			this.comboDegree = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboRegion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textTuition = new System.Windows.Forms.TextBox();
			this.labelTuition = new System.Windows.Forms.Label();
			this.textDuration = new System.Windows.Forms.TextBox();
			this.labelDuration = new System.Windows.Forms.Label();
			this.dateRegDate = new System.Windows.Forms.DateTimePicker();
			this.labelRegDate = new System.Windows.Forms.Label();
			this.pageDoc = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textTaxOrg = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.textTaxName = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.textTaxPos = new System.Windows.Forms.TextBox();
			this.checkTaxContract = new System.Windows.Forms.CheckBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.textTaxPaReg = new System.Windows.Forms.TextBox();
			this.textTaxMaReg = new System.Windows.Forms.TextBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.daRegion = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectRegion = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableStudent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableDegree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableRegion)).BeginInit();
			this.tabDetail.SuspendLayout();
			this.pageMain.SuspendLayout();
			this.pageDoc.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdPromote
			// 
			this.cmdPromote.Index = 2;
			this.cmdPromote.Text = "&Анги дэвшvvлэх";
			// 
			// cmdCheck
			// 
			this.cmdCheck.Enabled = false;
			this.cmdCheck.Index = 0;
			this.cmdCheck.Text = "&Шалгах";
			// 
			// cmdGrade
			// 
			this.cmdGrade.Index = 3;
			this.cmdGrade.Text = "&Төгссөн";
			// 
			// menuStudent
			// 
			this.menuStudent.Index = 0;
			this.menuStudent.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmdCheck,
																						this.menuItem1,
																						this.cmdPromote,
																						this.cmdSetState});
			this.menuStudent.MergeOrder = 3;
			this.menuStudent.Text = "&Оюутан";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// cmdSetState
			// 
			this.cmdSetState.Index = 3;
			this.cmdSetState.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmdAvl,
																						this.cmdAbsent,
																						this.cmdCancel,
																						this.cmdGrade});
			this.cmdSetState.Text = "Төлө&в";
			// 
			// cmdAvl
			// 
			this.cmdAvl.Index = 0;
			this.cmdAvl.Text = "С&урч байгаа";
			// 
			// cmdAbsent
			// 
			this.cmdAbsent.Index = 1;
			this.cmdAbsent.Text = "&Чөлөөтэй";
			// 
			// cmdCancel
			// 
			this.cmdCancel.Index = 2;
			this.cmdCancel.Text = "&Цуцлах";
			// 
			// colClass
			// 
			this.colClass.Format = "";
			this.colClass.FormatInfo = null;
			this.colClass.HeaderText = "Мэргэжил";
			this.colClass.MappingName = "prof";
			this.colClass.Width = 93;
			// 
			// menuMain
			// 
			this.menuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuStudent});
			// 
			// gridStudent
			// 
			this.gridStudent.CaptionVisible = false;
			this.gridStudent.DataMember = "Student";
			this.gridStudent.DataSource = this.dataSet;
			this.gridStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStudent.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridStudent.Name = "gridStudent";
			this.gridStudent.Size = new System.Drawing.Size(576, 226);
			this.gridStudent.TabIndex = 3;
			this.gridStudent.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyle});
			this.gridStudent.CurrentCellChanged += new System.EventHandler(this.gridStudent_CurrentCellChanged);
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "NewDataSet";
			this.dataSet.Locale = new System.Globalization.CultureInfo("mn-MN");
			this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
																		 this.tableStudent,
																		 this.tableDegree,
																		 this.tableRegion});
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
																				this.dataColumnNote,
																				this.dataColumnPaReg,
																				this.dataColumnMaReg,
																				this.dataColumnContract,
																				this.dataColumnName,
																				this.dataColumnOrg,
																				this.dataColumnPos});
			this.tableStudent.Constraints.AddRange(new System.Data.Constraint[] {
																					new System.Data.UniqueConstraint("Constraint1", new string[] {
																																					 "id"}, true),
																					new System.Data.UniqueConstraint("ConstraintRegNo", new string[] {
																																						 "regno"}, false),
																					new System.Data.UniqueConstraint("ConstraintPasNo", new string[] {
																																						 "pasno"}, false),
																					new System.Data.UniqueConstraint("ConstraintAdmisNo", new string[] {
																																						   "admisno"}, false),
																					new System.Data.ForeignKeyConstraint("DegreeToStudent", "Degree", new string[] {
																																									   "id"}, new string[] {
																																															   "degree"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade),
																					new System.Data.ForeignKeyConstraint("RegionToStudent", "Region", new string[] {
																																									   "id"}, new string[] {
																																															   "region"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
			this.tableStudent.PrimaryKey = new System.Data.DataColumn[] {
																			this.dataColumnID};
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
			// dataColumnPaReg
			// 
			this.dataColumnPaReg.ColumnName = "pa_regno";
			this.dataColumnPaReg.MaxLength = 10;
			// 
			// dataColumnMaReg
			// 
			this.dataColumnMaReg.ColumnName = "ma_regno";
			this.dataColumnMaReg.MaxLength = 10;
			// 
			// dataColumnContract
			// 
			this.dataColumnContract.ColumnName = "contract";
			this.dataColumnContract.DataType = typeof(bool);
			this.dataColumnContract.DefaultValue = true;
			// 
			// dataColumnName
			// 
			this.dataColumnName.ColumnName = "name";
			this.dataColumnName.MaxLength = 20;
			// 
			// dataColumnOrg
			// 
			this.dataColumnOrg.ColumnName = "org";
			this.dataColumnOrg.MaxLength = 30;
			// 
			// dataColumnPos
			// 
			this.dataColumnPos.ColumnName = "pos";
			this.dataColumnPos.MaxLength = 20;
			// 
			// tableDegree
			// 
			this.tableDegree.Columns.AddRange(new System.Data.DataColumn[] {
																			   this.dataColumnDegreeID,
																			   this.dataColumnDegreeDesc});
			this.tableDegree.Constraints.AddRange(new System.Data.Constraint[] {
																				   new System.Data.UniqueConstraint("Constraint1", new string[] {
																																					"id"}, false)});
			this.tableDegree.TableName = "Degree";
			// 
			// dataColumnDegreeID
			// 
			this.dataColumnDegreeID.ColumnName = "id";
			this.dataColumnDegreeID.DataType = typeof(System.Byte);
			// 
			// dataColumnDegreeDesc
			// 
			this.dataColumnDegreeDesc.ColumnName = "desc";
			// 
			// tableRegion
			// 
			this.tableRegion.Columns.AddRange(new System.Data.DataColumn[] {
																			   this.dataColumnRegionID,
																			   this.dataColumnRegionName});
			this.tableRegion.Constraints.AddRange(new System.Data.Constraint[] {
																				   new System.Data.UniqueConstraint("Constraint1", new string[] {
																																					"id"}, false)});
			this.tableRegion.TableName = "Region";
			// 
			// dataColumnRegionID
			// 
			this.dataColumnRegionID.ColumnName = "id";
			this.dataColumnRegionID.DataType = typeof(int);
			// 
			// dataColumnRegionName
			// 
			this.dataColumnRegionName.ColumnName = "name";
			this.dataColumnRegionName.MaxLength = 20;
			// 
			// dataGridTableStyle
			// 
			this.dataGridTableStyle.DataGrid = this.gridStudent;
			this.dataGridTableStyle.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												 this.dataGridTextBoxColumnLName,
																												 this.dataGridTextBoxColumnFName,
																												 this.dataGridTextBoxColumnGender,
																												 this.dataGridTextBoxColumnPasNo,
																												 this.dataGridTextBoxColumnRegNo,
																												 this.dataGridTextBoxColumnProf,
																												 this.dataGridTextBoxColumnGrade,
																												 this.dataGridTextBoxColumnGPA,
																												 this.dataGridTextBoxColumnAdmisNo,
																												 this.dataGridTextBoxColumnNote});
			this.dataGridTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle.MappingName = "Student";
			// 
			// dataGridTextBoxColumnLName
			// 
			this.dataGridTextBoxColumnLName.Format = "";
			this.dataGridTextBoxColumnLName.FormatInfo = null;
			this.dataGridTextBoxColumnLName.HeaderText = "Овог";
			this.dataGridTextBoxColumnLName.MappingName = "lname";
			this.dataGridTextBoxColumnLName.Width = 75;
			// 
			// dataGridTextBoxColumnFName
			// 
			this.dataGridTextBoxColumnFName.Format = "";
			this.dataGridTextBoxColumnFName.FormatInfo = null;
			this.dataGridTextBoxColumnFName.HeaderText = "Нэр";
			this.dataGridTextBoxColumnFName.MappingName = "fname";
			this.dataGridTextBoxColumnFName.Width = 75;
			// 
			// dataGridTextBoxColumnGender
			// 
			this.dataGridTextBoxColumnGender.Format = "";
			this.dataGridTextBoxColumnGender.FormatInfo = null;
			this.dataGridTextBoxColumnGender.HeaderText = "Хvйс";
			this.dataGridTextBoxColumnGender.MappingName = "gender";
			this.dataGridTextBoxColumnGender.Width = 40;
			// 
			// dataGridTextBoxColumnPasNo
			// 
			this.dataGridTextBoxColumnPasNo.Format = "";
			this.dataGridTextBoxColumnPasNo.FormatInfo = null;
			this.dataGridTextBoxColumnPasNo.HeaderText = "Vнэмлэх";
			this.dataGridTextBoxColumnPasNo.MappingName = "pasno";
			this.dataGridTextBoxColumnPasNo.Width = 75;
			// 
			// dataGridTextBoxColumnRegNo
			// 
			this.dataGridTextBoxColumnRegNo.Format = "";
			this.dataGridTextBoxColumnRegNo.FormatInfo = null;
			this.dataGridTextBoxColumnRegNo.HeaderText = "Регистр";
			this.dataGridTextBoxColumnRegNo.MappingName = "regno";
			this.dataGridTextBoxColumnRegNo.Width = 75;
			// 
			// dataGridTextBoxColumnProf
			// 
			this.dataGridTextBoxColumnProf.Format = "";
			this.dataGridTextBoxColumnProf.FormatInfo = null;
			this.dataGridTextBoxColumnProf.HeaderText = "Мэргэжил";
			this.dataGridTextBoxColumnProf.MappingName = "prof";
			this.dataGridTextBoxColumnProf.Width = 75;
			// 
			// dataGridTextBoxColumnGrade
			// 
			this.dataGridTextBoxColumnGrade.Format = "";
			this.dataGridTextBoxColumnGrade.FormatInfo = null;
			this.dataGridTextBoxColumnGrade.HeaderText = "Курс";
			this.dataGridTextBoxColumnGrade.MappingName = "grade";
			this.dataGridTextBoxColumnGrade.Width = 40;
			// 
			// dataGridTextBoxColumnGPA
			// 
			this.dataGridTextBoxColumnGPA.Format = "";
			this.dataGridTextBoxColumnGPA.FormatInfo = null;
			this.dataGridTextBoxColumnGPA.HeaderText = "Голч дvн";
			this.dataGridTextBoxColumnGPA.MappingName = "gpa";
			this.dataGridTextBoxColumnGPA.Width = 40;
			// 
			// dataGridTextBoxColumnAdmisNo
			// 
			this.dataGridTextBoxColumnAdmisNo.Format = "";
			this.dataGridTextBoxColumnAdmisNo.FormatInfo = null;
			this.dataGridTextBoxColumnAdmisNo.HeaderText = "Томилолт";
			this.dataGridTextBoxColumnAdmisNo.MappingName = "admisno";
			this.dataGridTextBoxColumnAdmisNo.Width = 75;
			// 
			// dataGridTextBoxColumnNote
			// 
			this.dataGridTextBoxColumnNote.Format = "";
			this.dataGridTextBoxColumnNote.FormatInfo = null;
			this.dataGridTextBoxColumnNote.HeaderText = "Тайлбар";
			this.dataGridTextBoxColumnNote.MappingName = "note";
			this.dataGridTextBoxColumnNote.Width = 75;
			// 
			// con
			// 
			this.con.ConnectionString = "data source=onolt;initial catalog=STraF;password=joker;persist security info=True" +
				";user id=sa;workstation id=ONOLT;packet size=4096";
			// 
			// daStudent
			// 
			this.daStudent.DeleteCommand = this.sqlDeleteStudent;
			this.daStudent.InsertCommand = this.sqlInsertStudent;
			this.daStudent.SelectCommand = this.sqlSelectStudent;
			this.daStudent.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								new System.Data.Common.DataTableMapping("Table", "Student", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("id", "id"),
																																																		   new System.Data.Common.DataColumnMapping("lname", "lname"),
																																																		   new System.Data.Common.DataColumnMapping("fname", "fname"),
																																																		   new System.Data.Common.DataColumnMapping("gender", "gender"),
																																																		   new System.Data.Common.DataColumnMapping("pasno", "pasno"),
																																																		   new System.Data.Common.DataColumnMapping("regno", "regno"),
																																																		   new System.Data.Common.DataColumnMapping("school", "school"),
																																																		   new System.Data.Common.DataColumnMapping("degree", "degree"),
																																																		   new System.Data.Common.DataColumnMapping("prof", "prof"),
																																																		   new System.Data.Common.DataColumnMapping("grade", "grade"),
																																																		   new System.Data.Common.DataColumnMapping("gpa", "gpa"),
																																																		   new System.Data.Common.DataColumnMapping("region", "region"),
																																																		   new System.Data.Common.DataColumnMapping("admisno", "admisno"),
																																																		   new System.Data.Common.DataColumnMapping("regdate", "regdate"),
																																																		   new System.Data.Common.DataColumnMapping("enddate", "enddate"),
																																																		   new System.Data.Common.DataColumnMapping("duration", "duration"),
																																																		   new System.Data.Common.DataColumnMapping("tuition", "tuition"),
																																																		   new System.Data.Common.DataColumnMapping("state", "state"),
																																																		   new System.Data.Common.DataColumnMapping("note", "note"),
																																																		   new System.Data.Common.DataColumnMapping("pa_regno", "pa_regno"),
																																																		   new System.Data.Common.DataColumnMapping("ma_regno", "ma_regno"),
																																																		   new System.Data.Common.DataColumnMapping("contract", "contract"),
																																																		   new System.Data.Common.DataColumnMapping("name", "name"),
																																																		   new System.Data.Common.DataColumnMapping("org", "org"),
																																																		   new System.Data.Common.DataColumnMapping("pos", "pos")})});
			this.daStudent.UpdateCommand = this.sqlUpdateStudent;
			// 
			// sqlDeleteStudent
			// 
			this.sqlDeleteStudent.CommandText = "[delete_tax]";
			this.sqlDeleteStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteStudent.Connection = this.con;
			this.sqlDeleteStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertStudent
			// 
			this.sqlInsertStudent.CommandText = "[insert_tax]";
			this.sqlInsertStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlInsertStudent.Connection = this.con;
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.NVarChar, 20, "lname"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.NVarChar, 20, "fname"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.NChar, 2, "gender"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pasno", System.Data.SqlDbType.NChar, 10, "pasno"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno", System.Data.SqlDbType.NChar, 10, "regno"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@school", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "school", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@degree", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "degree", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@prof", System.Data.SqlDbType.NVarChar, 20, "prof"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@grade", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gpa", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@admisno", System.Data.SqlDbType.NChar, 10, "admisno"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regdate", System.Data.SqlDbType.DateTime, 8, "regdate"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "duration", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tuition", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tuition", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.NVarChar, 50, "note"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pa_regno", System.Data.SqlDbType.NChar, 10, "pa_regno"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ma_regno", System.Data.SqlDbType.NChar, 10, "ma_regno"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@contract", System.Data.SqlDbType.Bit, 1, "contract"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20, "name"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@org", System.Data.SqlDbType.NVarChar, 20, "org"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pos", System.Data.SqlDbType.NVarChar, 20, "pos"));
			// 
			// sqlSelectStudent
			// 
			this.sqlSelectStudent.CommandText = "select * from tax";
			this.sqlSelectStudent.Connection = this.con;
			// 
			// sqlUpdateStudent
			// 
			this.sqlUpdateStudent.CommandText = "[update_tax]";
			this.sqlUpdateStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateStudent.Connection = this.con;
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.NVarChar, 20, "lname"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.NVarChar, 20, "fname"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.NChar, 2, "gender"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pasno", System.Data.SqlDbType.NChar, 10, "pasno"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno", System.Data.SqlDbType.NChar, 10, "regno"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@school", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "school", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@degree", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "degree", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@prof", System.Data.SqlDbType.NVarChar, 20, "prof"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@grade", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gpa", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@admisno", System.Data.SqlDbType.NChar, 10, "admisno"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regdate", System.Data.SqlDbType.DateTime, 8, "regdate"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "duration", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tuition", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tuition", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.NVarChar, 50, "note"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pa_regno", System.Data.SqlDbType.NChar, 10, "pa_regno"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ma_regno", System.Data.SqlDbType.NChar, 10, "ma_regno"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@contract", System.Data.SqlDbType.Bit, 1, "contract"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20, "name"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@org", System.Data.SqlDbType.NVarChar, 20, "org"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pos", System.Data.SqlDbType.NVarChar, 20, "pos"));
			// 
			// tabDetail
			// 
			this.tabDetail.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.pageMain,
																					this.pageDoc});
			this.tabDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabDetail.Location = new System.Drawing.Point(0, 229);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.SelectedIndex = 0;
			this.tabDetail.Size = new System.Drawing.Size(576, 136);
			this.tabDetail.TabIndex = 6;
			this.tabDetail.Text = "tabControl1";
			// 
			// pageMain
			// 
			this.pageMain.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.comboDegree,
																				   this.label12,
																				   this.comboRegion,
																				   this.label2,
																				   this.textTuition,
																				   this.labelTuition,
																				   this.textDuration,
																				   this.labelDuration,
																				   this.dateRegDate,
																				   this.labelRegDate});
			this.pageMain.Location = new System.Drawing.Point(4, 22);
			this.pageMain.Name = "pageMain";
			this.pageMain.Size = new System.Drawing.Size(568, 110);
			this.pageMain.TabIndex = 0;
			this.pageMain.Text = "Vндсэн";
			// 
			// comboDegree
			// 
			this.comboDegree.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet, "Student.degree"));
			this.comboDegree.DataSource = this.tableDegree;
			this.comboDegree.DisplayMember = "desc";
			this.comboDegree.Location = new System.Drawing.Point(384, 8);
			this.comboDegree.Name = "comboDegree";
			this.comboDegree.Size = new System.Drawing.Size(121, 21);
			this.comboDegree.TabIndex = 15;
			this.comboDegree.Tag = "";
			this.comboDegree.ValueMember = "id";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(264, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 23);
			this.label12.TabIndex = 14;
			this.label12.Text = "Сургалтын тvвшин:";
			// 
			// comboRegion
			// 
			this.comboRegion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet, "Student.region"));
			this.comboRegion.DataSource = this.tableRegion;
			this.comboRegion.DisplayMember = "name";
			this.comboRegion.Location = new System.Drawing.Point(384, 32);
			this.comboRegion.Name = "comboRegion";
			this.comboRegion.Size = new System.Drawing.Size(121, 21);
			this.comboRegion.TabIndex = 13;
			this.comboRegion.ValueMember = "id";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(264, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Аймаг, улс:";
			// 
			// textTuition
			// 
			this.textTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTuition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.tuition"));
			this.textTuition.Location = new System.Drawing.Point(128, 56);
			this.textTuition.Name = "textTuition";
			this.textTuition.Size = new System.Drawing.Size(121, 20);
			this.textTuition.TabIndex = 11;
			this.textTuition.Tag = "";
			this.textTuition.Text = "";
			// 
			// labelTuition
			// 
			this.labelTuition.Location = new System.Drawing.Point(8, 56);
			this.labelTuition.Name = "labelTuition";
			this.labelTuition.Size = new System.Drawing.Size(112, 23);
			this.labelTuition.TabIndex = 10;
			this.labelTuition.Text = "Бvгд төлбөр:";
			// 
			// textDuration
			// 
			this.textDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.duration"));
			this.textDuration.Location = new System.Drawing.Point(128, 32);
			this.textDuration.MaxLength = 2;
			this.textDuration.Name = "textDuration";
			this.textDuration.Size = new System.Drawing.Size(121, 20);
			this.textDuration.TabIndex = 9;
			this.textDuration.TabStop = false;
			this.textDuration.Tag = "";
			this.textDuration.Text = "";
			// 
			// labelDuration
			// 
			this.labelDuration.Location = new System.Drawing.Point(8, 32);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(112, 23);
			this.labelDuration.TabIndex = 8;
			this.labelDuration.Text = "Суралцах хугацаа:";
			// 
			// dateRegDate
			// 
			this.dateRegDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.regdate"));
			this.dateRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateRegDate.Location = new System.Drawing.Point(128, 8);
			this.dateRegDate.Name = "dateRegDate";
			this.dateRegDate.ShowUpDown = true;
			this.dateRegDate.Size = new System.Drawing.Size(120, 20);
			this.dateRegDate.TabIndex = 3;
			// 
			// labelRegDate
			// 
			this.labelRegDate.Location = new System.Drawing.Point(8, 8);
			this.labelRegDate.Name = "labelRegDate";
			this.labelRegDate.Size = new System.Drawing.Size(108, 23);
			this.labelRegDate.TabIndex = 2;
			this.labelRegDate.Text = "Бvртгэгдсэн огноо:";
			// 
			// pageDoc
			// 
			this.pageDoc.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.groupBox3,
																				  this.checkTaxContract,
																				  this.label25,
																				  this.label28,
																				  this.textTaxPaReg,
																				  this.textTaxMaReg});
			this.pageDoc.Location = new System.Drawing.Point(4, 22);
			this.pageDoc.Name = "pageDoc";
			this.pageDoc.Size = new System.Drawing.Size(568, 110);
			this.pageDoc.TabIndex = 1;
			this.pageDoc.Text = "Баримт";
			this.pageDoc.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textTaxOrg,
																					this.label24,
																					this.label23,
																					this.textTaxName,
																					this.label22,
																					this.textTaxPos});
			this.groupBox3.Location = new System.Drawing.Point(264, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 96);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "  Гэрээ хийсэн эцэг/эх     ";
			// 
			// textTaxOrg
			// 
			this.textTaxOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTaxOrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.org"));
			this.textTaxOrg.Location = new System.Drawing.Point(112, 42);
			this.textTaxOrg.Name = "textTaxOrg";
			this.textTaxOrg.Size = new System.Drawing.Size(168, 20);
			this.textTaxOrg.TabIndex = 16;
			this.textTaxOrg.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(16, 67);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(88, 23);
			this.label24.TabIndex = 15;
			this.label24.Text = "Албан тушаал:";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 43);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(88, 23);
			this.label23.TabIndex = 14;
			this.label23.Text = "Байгууллага:";
			// 
			// textTaxName
			// 
			this.textTaxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTaxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.name"));
			this.textTaxName.Location = new System.Drawing.Point(112, 19);
			this.textTaxName.MaxLength = 50;
			this.textTaxName.Name = "textTaxName";
			this.textTaxName.Size = new System.Drawing.Size(168, 20);
			this.textTaxName.TabIndex = 13;
			this.textTaxName.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(16, 19);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(88, 23);
			this.label22.TabIndex = 12;
			this.label22.Text = "Нэр:";
			// 
			// textTaxPos
			// 
			this.textTaxPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTaxPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.pos"));
			this.textTaxPos.Location = new System.Drawing.Point(112, 67);
			this.textTaxPos.MaxLength = 50;
			this.textTaxPos.Name = "textTaxPos";
			this.textTaxPos.Size = new System.Drawing.Size(168, 20);
			this.textTaxPos.TabIndex = 10;
			this.textTaxPos.Text = "";
			// 
			// checkTaxContract
			// 
			this.checkTaxContract.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkTaxContract.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet, "Student.contract"));
			this.checkTaxContract.Location = new System.Drawing.Point(8, 64);
			this.checkTaxContract.Name = "checkTaxContract";
			this.checkTaxContract.Size = new System.Drawing.Size(184, 24);
			this.checkTaxContract.TabIndex = 16;
			this.checkTaxContract.Text = "Эцгийн нэр дээр гэрээ хийсэн:";
			this.checkTaxContract.CheckedChanged += new System.EventHandler(this.checkTaxContract_CheckedChanged);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(8, 16);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(96, 23);
			this.label25.TabIndex = 15;
			this.label25.Text = "Эцгийн регистр:";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(8, 40);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(96, 23);
			this.label28.TabIndex = 14;
			this.label28.Text = "Эхийн регистр:";
			// 
			// textTaxPaReg
			// 
			this.textTaxPaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTaxPaReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.pa_regno"));
			this.textTaxPaReg.Location = new System.Drawing.Point(112, 16);
			this.textTaxPaReg.MaxLength = 50;
			this.textTaxPaReg.Name = "textTaxPaReg";
			this.textTaxPaReg.Size = new System.Drawing.Size(120, 20);
			this.textTaxPaReg.TabIndex = 13;
			this.textTaxPaReg.Text = "";
			// 
			// textTaxMaReg
			// 
			this.textTaxMaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTaxMaReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.ma_regno"));
			this.textTaxMaReg.Location = new System.Drawing.Point(112, 40);
			this.textTaxMaReg.MaxLength = 50;
			this.textTaxMaReg.Name = "textTaxMaReg";
			this.textTaxMaReg.Size = new System.Drawing.Size(120, 20);
			this.textTaxMaReg.TabIndex = 12;
			this.textTaxMaReg.Text = "";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 226);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(576, 3);
			this.splitter1.TabIndex = 7;
			this.splitter1.TabStop = false;
			// 
			// daRegion
			// 
			this.daRegion.SelectCommand = this.sqlSelectRegion;
			this.daRegion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							   new System.Data.Common.DataTableMapping("Table", "Region", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("id", "id"),
																																																		 new System.Data.Common.DataColumnMapping("name", "name")})});
			// 
			// sqlSelectRegion
			// 
			this.sqlSelectRegion.CommandText = "SELECT id, name FROM Region";
			this.sqlSelectRegion.Connection = this.con;
			// 
			// TaxView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gridStudent,
																		  this.splitter1,
																		  this.tabDetail});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuMain;
			this.Name = "TaxView";
			this.ShowInTaskbar = false;
			this.Text = "ТАХ";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableDegree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableRegion)).EndInit();
			this.tabDetail.ResumeLayout(false);
			this.pageMain.ResumeLayout(false);
			this.pageDoc.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public void ChangeSchool(int school_id) {
		}
		public void ChangeRegion(int region_id) {
		}
		public void ChangeOrg(int org_id) {
		}
		private void LoadData() {
			dataSet.EnforceConstraints = false;
			try {
				daRegion.Fill(tableRegion);
				for (int i=0;i<Student.descDegree.Length;i++) {
					DataRow newRow = tableDegree.NewRow();
					newRow[0] = i + 1;
					newRow[1] = Student.descDegree[i];
					tableDegree.Rows.Add(newRow);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				dataSet.EnforceConstraints = true;
			}
		}
		public void RefreshData() {
			this.Cursor = Cursors.WaitCursor;
			dataSet.EnforceConstraints = false;
			tableStudent.Clear();
			try {
				daStudent.Fill(tableStudent);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				dataSet.EnforceConstraints = true;
				this.Cursor = Cursors.Default;
			}
		}
		public void Find(object search, bool regular, bool back) {
			int step = 1;
			int row = gridStudent.CurrentRowIndex;
			int col = gridStudent.CurrentCell.ColumnNumber;
			string source, data;
			source = Convert.ToString(search);
			source = source.ToUpper();
			if (back)
				step = -1;
			row += step;
			while (row < tableStudent.Rows.Count && row >=0) {
				data = Convert.ToString(gridStudent[row, col]);
				data = data.ToUpper();
				if (regular) {
					if (data.StartsWith(source))
						break;
				}
				else {
					if (data == source)
						break;
				}
				row += step;
			}
			if (row < tableStudent.Rows.Count && row >= 0) {
				gridStudent.CurrentRowIndex = row;
				gridStudent.Select(row);
			}
		}
		public void Replace(object search, object replace, bool regular, bool back) {
		}
		public ReportDocument GetReportDocument() {
			return null;
		}
		private void Student_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.S: 
					Save(); 
					break;
			
				case Keys.Control | Keys.C: 
					Copy(); 
					break;
			
				case Keys.Control | Keys.X: 
					Cut(); 
					break;
			
				case Keys.Control | Keys.V: 
					Paste(); 
					break;
				
				case Keys.Control | Keys.Z: 
					Undo(); 
					break;

				case Keys.F5: 
					RefreshData(); 
					break;
			
				default :
					if (ActiveControl != null)
						Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, (int)e.KeyData, 1);
					break;
			}
		}
		private void Save() {
			try {
				daStudent.Update(dataSet, "Student");
			}
			catch (Exception ex) {
				if (MessageBox.Show(ex.ToString() + "\nVйлдлийг буцаах уу ?", Straf.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.OK) {
					tableStudent.RejectChanges();
				}
			}
		}
		private void Copy() {
			string strData = "";
			for (int i=0;i<tableStudent.Rows.Count;i++) {
				if (gridStudent.IsSelected(i)) {
					for (int j = 0; j < tableStudent.Columns.Count; j++) {
						strData += tableStudent.Rows[i].ItemArray.GetValue(j).ToString() + "\t";
					}
					strData += "\r\n";
				}
			}
			Clipboard.SetDataObject(strData);
		}
		private void Cut() {
			Copy();
			Win32.SendMessage(gridStudent.Handle, 0x0100 /*WM_KEYDOWN*/, (int) Keys.Delete, 1);
		}
		private void Paste() {
			IDataObject iData = Clipboard.GetDataObject();
			if(iData.GetDataPresent(DataFormats.Text)) {
				this.Cursor = Cursors.WaitCursor;
				dataSet.EnforceConstraints = false;
				string strData = (string) iData.GetData(DataFormats.Text);
				try {
					string[] lines = strData.Split(new Char[] {'\n'});
					ArrayList rows = new ArrayList();
					for (int i=0; i<lines.Length;i++) {
						string line = lines[i].Trim(new Char[]{'\r'});
						if (line != "") {
							DataRow row = tableStudent.NewRow();
							string[] words = line.Split(new Char[] {'\t'});
							int j = 0;
							while (j < tableStudent.Columns.Count - 1 && j < words.Length) {
								row[j + 1] = words[j];
								j++;
							}
							rows.Add(row);
						}
					}
					System.Collections.IEnumerator enumerator = rows.GetEnumerator();
					while ( enumerator.MoveNext() )
						tableStudent.Rows.Add((DataRow)enumerator.Current);
				}
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
				finally {
					this.Cursor = Cursors.Default;
					dataSet.EnforceConstraints = true;
				}
			}
			else {
				MessageBox.Show("Clipboard-с өгөгдлийг авч чадахгvй", Straf.appName);
			}
		}
		private void Undo() {
			tableStudent.RejectChanges();
		}
		private void gridStudent_CurrentCellChanged(object sender, System.EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				parent.statusRecord.Text = string.Format("{0}/{1}", gridStudent.CurrentRowIndex + 1, tableStudent.Rows.Count);
			}
			//gridStudent.NavigateTo();
		}

		private void checkTaxContract_CheckedChanged(object sender, System.EventArgs e) {
			if (checkTaxContract.Checked) {
				textTaxName.ReadOnly = true;
				textTaxName.Text = (string)tableStudent.Rows[gridStudent.CurrentRowIndex]["lname"];
			}
			else {
				textTaxName.ReadOnly = false;
			}
		}
	}
}

