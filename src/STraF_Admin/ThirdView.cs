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
	public class ThirdView : Form, IStudentChild {
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
		private DataGridTableStyle dataGridTableStyle;
		private DataGridTextBoxColumn dataGridTextBoxColumnLName;
		private DataGridTextBoxColumn dataGridTextBoxColumnFName;
		private DataGridTextBoxColumn dataGridTextBoxColumnPasNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnRegNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnProf;
		private DataGridTextBoxColumn dataGridTextBoxColumnGrade;
		private DataGridTextBoxColumn dataGridTextBoxColumnGPA;
		private DataGridTextBoxColumn dataGridTextBoxColumnAdmisNo;
		private System.Data.DataColumn dataColumnNote;
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
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnGender;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textThirdAbout2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textThirdReg2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textThirdAbout1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textThirdReg1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textThirdMaReg;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.TextBox textThirdPaReg;
		private System.Windows.Forms.Label label40;
		private System.Data.DataColumn dataColumnPaReg;
		private System.Data.DataColumn dataColumnMaReg;
		private System.Data.DataColumn dataColumnRegNo1;
		private System.Data.DataColumn dataColumnAbout1;
		private System.Data.DataColumn dataColumnRegNo2;
		private System.Data.DataColumn dataColumnAbout2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ThirdView() {
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
					RefreshData();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ThirdView));
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
			this.dataColumnRegNo1 = new System.Data.DataColumn();
			this.dataColumnAbout1 = new System.Data.DataColumn();
			this.dataColumnRegNo2 = new System.Data.DataColumn();
			this.dataColumnAbout2 = new System.Data.DataColumn();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textThirdAbout2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textThirdReg2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textThirdAbout1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textThirdReg1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textThirdMaReg = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.textThirdPaReg = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
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
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.gridStudent.BackColor = System.Drawing.Color.White;
			this.gridStudent.CaptionVisible = false;
			this.gridStudent.DataMember = "Student";
			this.gridStudent.DataSource = this.dataSet;
			this.gridStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
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
			this.dataSet.Relations.AddRange(new System.Data.DataRelation[] {
																			   new System.Data.DataRelation("DegreeToStudent", "Degree", "Student", new string[] {
																																									 "id"}, new string[] {
																																															 "degree"}, false),
																			   new System.Data.DataRelation("RegionToStudent", "Region", "Student", new string[] {
																																									 "id"}, new string[] {
																																															 "region"}, false)});
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
																				this.dataColumnRegNo1,
																				this.dataColumnAbout1,
																				this.dataColumnRegNo2,
																				this.dataColumnAbout2});
			this.tableStudent.Constraints.AddRange(new System.Data.Constraint[] {
																					new System.Data.UniqueConstraint("Constraint1", new string[] {
																																					 "id"}, true),
																					new System.Data.UniqueConstraint("Constraint2", new string[] {
																																					 "regno"}, false),
																					new System.Data.UniqueConstraint("Constraint3", new string[] {
																																					 "pasno"}, false),
																					new System.Data.UniqueConstraint("Constraint4", new string[] {
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
			// dataColumnRegNo1
			// 
			this.dataColumnRegNo1.ColumnName = "regno1";
			this.dataColumnRegNo1.MaxLength = 10;
			// 
			// dataColumnAbout1
			// 
			this.dataColumnAbout1.ColumnName = "about1";
			this.dataColumnAbout1.MaxLength = 50;
			// 
			// dataColumnRegNo2
			// 
			this.dataColumnRegNo2.ColumnName = "regno2";
			this.dataColumnRegNo2.MaxLength = 10;
			// 
			// dataColumnAbout2
			// 
			this.dataColumnAbout2.ColumnName = "about2";
			this.dataColumnAbout2.MaxLength = 50;
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
			this.con.ConnectionString = "data source=onolt;initial catalog=STraF;password=ub;persist security info=True;us" +
				"er id=sa;workstation id=ONOLT;packet size=4096";
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
																																																		   new System.Data.Common.DataColumnMapping("regno1", "regno1"),
																																																		   new System.Data.Common.DataColumnMapping("about1", "about1"),
																																																		   new System.Data.Common.DataColumnMapping("regno2", "regno2"),
																																																		   new System.Data.Common.DataColumnMapping("about2", "about2")})});
			this.daStudent.UpdateCommand = this.sqlUpdateStudent;
			// 
			// sqlDeleteStudent
			// 
			this.sqlDeleteStudent.CommandText = "[delete_third]";
			this.sqlDeleteStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteStudent.Connection = this.con;
			this.sqlDeleteStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlInsertStudent
			// 
			this.sqlInsertStudent.CommandText = "[insert_third]";
			this.sqlInsertStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlInsertStudent.Connection = this.con;
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.NVarChar, 20, "lname"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.NVarChar, 20, "fname"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.NChar, 2, "gender"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pasno", System.Data.SqlDbType.NVarChar, 10, "pasno"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno", System.Data.SqlDbType.NVarChar, 10, "regno"));
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
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno1", System.Data.SqlDbType.NChar, 10, "regno1"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@about1", System.Data.SqlDbType.NVarChar, 50, "about1"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno2", System.Data.SqlDbType.NChar, 10, "regno2"));
			this.sqlInsertStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@about2", System.Data.SqlDbType.NVarChar, 50, "about2"));
			// 
			// sqlSelectStudent
			// 
			this.sqlSelectStudent.CommandText = "[select_third]";
			this.sqlSelectStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectStudent.Connection = this.con;
			this.sqlSelectStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateStudent
			// 
			this.sqlUpdateStudent.CommandText = "[update_third]";
			this.sqlUpdateStudent.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateStudent.Connection = this.con;
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.NVarChar, 20, "lname"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.NVarChar, 20, "fname"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.NChar, 2, "gender"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pasno", System.Data.SqlDbType.NVarChar, 10, "pasno"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno", System.Data.SqlDbType.NVarChar, 10, "regno"));
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
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno1", System.Data.SqlDbType.NChar, 10, "regno1"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@about1", System.Data.SqlDbType.NVarChar, 50, "about1"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno2", System.Data.SqlDbType.NChar, 10, "regno2"));
			this.sqlUpdateStudent.Parameters.Add(new System.Data.SqlClient.SqlParameter("@about2", System.Data.SqlDbType.NVarChar, 50, "about2"));
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
																				  this.groupBox2,
																				  this.groupBox1,
																				  this.textThirdMaReg,
																				  this.label41,
																				  this.textThirdPaReg,
																				  this.label40});
			this.pageDoc.Location = new System.Drawing.Point(4, 22);
			this.pageDoc.Name = "pageDoc";
			this.pageDoc.Size = new System.Drawing.Size(568, 110);
			this.pageDoc.TabIndex = 1;
			this.pageDoc.Text = "Баримт";
			this.pageDoc.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textThirdAbout2,
																					this.label1,
																					this.textThirdReg2,
																					this.label6});
			this.groupBox2.Location = new System.Drawing.Point(292, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 73);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Хоёр дахь суралцагч";
			// 
			// textThirdAbout2
			// 
			this.textThirdAbout2.AcceptsReturn = true;
			this.textThirdAbout2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThirdAbout2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.about2"));
			this.textThirdAbout2.Location = new System.Drawing.Point(64, 40);
			this.textThirdAbout2.MaxLength = 20;
			this.textThirdAbout2.Multiline = true;
			this.textThirdAbout2.Name = "textThirdAbout2";
			this.textThirdAbout2.Size = new System.Drawing.Size(192, 26);
			this.textThirdAbout2.TabIndex = 14;
			this.textThirdAbout2.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Бусад:";
			// 
			// textThirdReg2
			// 
			this.textThirdReg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThirdReg2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.regno2"));
			this.textThirdReg2.Location = new System.Drawing.Point(64, 16);
			this.textThirdReg2.MaxLength = 20;
			this.textThirdReg2.Name = "textThirdReg2";
			this.textThirdReg2.Size = new System.Drawing.Size(104, 20);
			this.textThirdReg2.TabIndex = 12;
			this.textThirdReg2.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Регистр:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textThirdAbout1,
																					this.label9,
																					this.textThirdReg1,
																					this.label10});
			this.groupBox1.Location = new System.Drawing.Point(12, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 73);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Эхний суралцагч";
			// 
			// textThirdAbout1
			// 
			this.textThirdAbout1.AcceptsReturn = true;
			this.textThirdAbout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThirdAbout1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.about1"));
			this.textThirdAbout1.Location = new System.Drawing.Point(64, 40);
			this.textThirdAbout1.MaxLength = 20;
			this.textThirdAbout1.Multiline = true;
			this.textThirdAbout1.Name = "textThirdAbout1";
			this.textThirdAbout1.Size = new System.Drawing.Size(192, 26);
			this.textThirdAbout1.TabIndex = 14;
			this.textThirdAbout1.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.TabIndex = 15;
			this.label9.Text = "Бусад:";
			// 
			// textThirdReg1
			// 
			this.textThirdReg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThirdReg1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.regno1"));
			this.textThirdReg1.Location = new System.Drawing.Point(64, 16);
			this.textThirdReg1.MaxLength = 20;
			this.textThirdReg1.Name = "textThirdReg1";
			this.textThirdReg1.Size = new System.Drawing.Size(104, 20);
			this.textThirdReg1.TabIndex = 12;
			this.textThirdReg1.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Регистр:";
			// 
			// textThirdMaReg
			// 
			this.textThirdMaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThirdMaReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.ma_regno"));
			this.textThirdMaReg.Location = new System.Drawing.Point(404, 8);
			this.textThirdMaReg.MaxLength = 20;
			this.textThirdMaReg.Name = "textThirdMaReg";
			this.textThirdMaReg.TabIndex = 20;
			this.textThirdMaReg.Text = "";
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(292, 8);
			this.label41.Name = "label41";
			this.label41.TabIndex = 21;
			this.label41.Text = "Эхийн регистр:";
			// 
			// textThirdPaReg
			// 
			this.textThirdPaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThirdPaReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "Student.pa_regno"));
			this.textThirdPaReg.Location = new System.Drawing.Point(124, 8);
			this.textThirdPaReg.MaxLength = 20;
			this.textThirdPaReg.Name = "textThirdPaReg";
			this.textThirdPaReg.TabIndex = 22;
			this.textThirdPaReg.Text = "";
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(12, 8);
			this.label40.Name = "label40";
			this.label40.TabIndex = 23;
			this.label40.Text = "Эцгийн регистр:";
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
			// ThirdView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gridStudent,
																		  this.splitter1,
																		  this.tabDetail});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuMain;
			this.Name = "ThirdView";
			this.ShowInTaskbar = false;
			this.Text = "Гуравдагч";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableDegree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableRegion)).EndInit();
			this.tabDetail.ResumeLayout(false);
			this.pageMain.ResumeLayout(false);
			this.pageDoc.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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
			}
			this.Cursor = Cursors.Default;
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
	}
}

