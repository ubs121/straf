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
	public class PoorView : Form, IStudentChild {
		private string source;
		private int school;
		private int region;
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
		private DateTimePicker dateRegDate;
		private TabPage pageDoc;
		private Splitter splitter1;
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
		private DataGrid gridStudent;
		private Label label2;
		private ComboBox comboRegion;
		private System.Data.SqlClient.SqlDataAdapter daRegion;
		private Label label12;
		private ComboBox comboDegree;
		private TextBox textTuition;
		private TextBox textDuration;
		private System.Data.SqlClient.SqlCommand sqlSelectRegion;
		private DataGridTextBoxColumn dataGridTextBoxColumnGender;
		private TextBox textPoorPerIncome;
		private Label label17;
		private Label label8;
		private TextBox textPoorIncome;
		private TextBox textPoorFamily;
		private Label label7;
		private TabPage pageAdd;
		private System.Data.SqlClient.SqlDataAdapter daPoor;
		private System.Data.SqlClient.SqlCommand sqlDeletePoor;
		private System.Data.SqlClient.SqlCommand sqlInsertPoor;
		private System.Data.SqlClient.SqlCommand sqlSelectPoor;
		private System.Data.SqlClient.SqlCommand sqlUpdatePoor;
		private STraF.DataSetPoor dataSet;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PoorView(bool isPoor) {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			school = -1;
			region = -1;
			try {
				if (Straf.logged) {
					con.ConnectionString = Straf.strCon;
					if (isPoor) {
						source = "poor";
						Text = "Ядуу өрхийн суралцагч";
					}
					else {
						source = "loan";
						Text = "Зээл";
					}
					daPoor.SelectCommand.CommandText = "select * from " + source;
					daPoor.InsertCommand.CommandText = "insert_" + source;
					daPoor.UpdateCommand.CommandText = "update_" + source;
					daPoor.DeleteCommand.CommandText = "delete_" + source;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PoorView));
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
			this.daPoor = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeletePoor = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertPoor = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectPoor = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdatePoor = new System.Data.SqlClient.SqlCommand();
			this.tabDetail = new System.Windows.Forms.TabControl();
			this.pageDoc = new System.Windows.Forms.TabPage();
			this.textPoorPerIncome = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textPoorIncome = new System.Windows.Forms.TextBox();
			this.textPoorFamily = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pageAdd = new System.Windows.Forms.TabPage();
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
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.daRegion = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectRegion = new System.Data.SqlClient.SqlCommand();
			this.dataSet = new STraF.DataSetPoor();
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
			this.tabDetail.SuspendLayout();
			this.pageDoc.SuspendLayout();
			this.pageAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
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
			this.gridStudent.DataMember = "Poor";
			this.gridStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.gridStudent.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridStudent.Name = "gridStudent";
			this.gridStudent.Size = new System.Drawing.Size(576, 258);
			this.gridStudent.TabIndex = 3;
			this.gridStudent.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyle});
			this.gridStudent.CurrentCellChanged += new System.EventHandler(this.gridStudent_CurrentCellChanged);
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
			this.dataGridTableStyle.MappingName = "Poor";
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
			// daPoor
			// 
			this.daPoor.DeleteCommand = this.sqlDeletePoor;
			this.daPoor.InsertCommand = this.sqlInsertPoor;
			this.daPoor.SelectCommand = this.sqlSelectPoor;
			this.daPoor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							 new System.Data.Common.DataTableMapping("Table", "Poor", new System.Data.Common.DataColumnMapping[] {
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
																																																	 new System.Data.Common.DataColumnMapping("family", "family"),
																																																	 new System.Data.Common.DataColumnMapping("income", "income")})});
			this.daPoor.UpdateCommand = this.sqlUpdatePoor;
			// 
			// sqlDeletePoor
			// 
			this.sqlDeletePoor.CommandText = "[delete_poor]";
			this.sqlDeletePoor.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeletePoor.Connection = this.con;
			this.sqlDeletePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeletePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertPoor
			// 
			this.sqlInsertPoor.CommandText = "[insert_poor]";
			this.sqlInsertPoor.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlInsertPoor.Connection = this.con;
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.NVarChar, 20, "lname"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.NVarChar, 20, "fname"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.NChar, 2, "gender"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pasno", System.Data.SqlDbType.NChar, 10, "pasno"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno", System.Data.SqlDbType.NChar, 10, "regno"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@school", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "school", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@degree", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "degree", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@prof", System.Data.SqlDbType.NVarChar, 20, "prof"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@grade", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gpa", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@admisno", System.Data.SqlDbType.NChar, 10, "admisno"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regdate", System.Data.SqlDbType.DateTime, 8, "regdate"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "duration", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tuition", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tuition", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.NVarChar, 50, "note"));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@family", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "family", System.Data.DataRowVersion.Current, null));
			this.sqlInsertPoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@income", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "income", System.Data.DataRowVersion.Current, null));
			// 
			// sqlSelectPoor
			// 
			this.sqlSelectPoor.CommandText = "select * from poor";
			this.sqlSelectPoor.Connection = this.con;
			// 
			// sqlUpdatePoor
			// 
			this.sqlUpdatePoor.CommandText = "[update_poor]";
			this.sqlUpdatePoor.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdatePoor.Connection = this.con;
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.NVarChar, 20, "lname"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.NVarChar, 20, "fname"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.NChar, 2, "gender"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pasno", System.Data.SqlDbType.NChar, 10, "pasno"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regno", System.Data.SqlDbType.NChar, 10, "regno"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@school", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "school", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@degree", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "degree", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@prof", System.Data.SqlDbType.NVarChar, 20, "prof"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@grade", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gpa", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@admisno", System.Data.SqlDbType.NChar, 10, "admisno"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@regdate", System.Data.SqlDbType.DateTime, 8, "regdate"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "duration", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tuition", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tuition", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.NVarChar, 50, "note"));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@family", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "family", System.Data.DataRowVersion.Current, null));
			this.sqlUpdatePoor.Parameters.Add(new System.Data.SqlClient.SqlParameter("@income", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "income", System.Data.DataRowVersion.Current, null));
			// 
			// tabDetail
			// 
			this.tabDetail.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.pageDoc,
																					this.pageAdd});
			this.tabDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabDetail.Location = new System.Drawing.Point(0, 261);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.SelectedIndex = 0;
			this.tabDetail.Size = new System.Drawing.Size(576, 104);
			this.tabDetail.TabIndex = 6;
			this.tabDetail.Text = "tabControl1";
			// 
			// pageDoc
			// 
			this.pageDoc.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.textPoorPerIncome,
																				  this.label17,
																				  this.label8,
																				  this.textPoorIncome,
																				  this.textPoorFamily,
																				  this.label7});
			this.pageDoc.Location = new System.Drawing.Point(4, 22);
			this.pageDoc.Name = "pageDoc";
			this.pageDoc.Size = new System.Drawing.Size(568, 78);
			this.pageDoc.TabIndex = 1;
			this.pageDoc.Text = "Баримт";
			this.pageDoc.Visible = false;
			// 
			// textPoorPerIncome
			// 
			this.textPoorPerIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPoorPerIncome.Location = new System.Drawing.Point(312, 32);
			this.textPoorPerIncome.Name = "textPoorPerIncome";
			this.textPoorPerIncome.ReadOnly = true;
			this.textPoorPerIncome.TabIndex = 6;
			this.textPoorPerIncome.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(248, 32);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(52, 23);
			this.label17.TabIndex = 7;
			this.label17.Text = "нэг хvнд:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Өрхийн орлого:";
			// 
			// textPoorIncome
			// 
			this.textPoorIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPoorIncome.Location = new System.Drawing.Point(128, 32);
			this.textPoorIncome.Name = "textPoorIncome";
			this.textPoorIncome.TabIndex = 9;
			this.textPoorIncome.Text = "40000";
			this.textPoorIncome.TextChanged += new System.EventHandler(this.textPoorFamily_TextChanged);
			// 
			// textPoorFamily
			// 
			this.textPoorFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPoorFamily.Location = new System.Drawing.Point(128, 8);
			this.textPoorFamily.Name = "textPoorFamily";
			this.textPoorFamily.TabIndex = 10;
			this.textPoorFamily.Text = "6";
			this.textPoorFamily.TextChanged += new System.EventHandler(this.textPoorFamily_TextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Ам бvл:";
			// 
			// pageAdd
			// 
			this.pageAdd.Controls.AddRange(new System.Windows.Forms.Control[] {
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
			this.pageAdd.Location = new System.Drawing.Point(4, 22);
			this.pageAdd.Name = "pageAdd";
			this.pageAdd.Size = new System.Drawing.Size(568, 78);
			this.pageAdd.TabIndex = 0;
			this.pageAdd.Text = "Нэмэлт";
			// 
			// comboDegree
			// 
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
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 258);
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
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSetPoor";
			this.dataSet.Locale = new System.Globalization.CultureInfo("mn-MN");
			this.dataSet.Namespace = "http://www.tempuri.org/DataSetPoor.xsd";
			// 
			// PoorView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gridStudent,
																		  this.splitter1,
																		  this.tabDetail});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuMain;
			this.Name = "PoorView";
			this.ShowInTaskbar = false;
			this.Text = "Ядуу өрхийн суралцагч";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
			this.tabDetail.ResumeLayout(false);
			this.pageDoc.ResumeLayout(false);
			this.pageAdd.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public void ChangeSchool(int school_id) {
			school = school_id;
			RefreshData();
		}
		public void ChangeRegion(int region_id) {
			region = region_id;
			RefreshData();
		}
		public void ChangeOrg(int org_id) {
		}
		public void FillDataSet(DataSetPoor dataSet) {
			dataSet.EnforceConstraints = false;
			try {
				con.Open();
				if (school != -1) {
					daPoor.SelectCommand.CommandText = "select * from " + source + " where school=" + Convert.ToString(school);
					//dataSet.Tables["Poor"].Columns["school"].DefaultValue = school;
				}
				else 
					daPoor.SelectCommand.CommandText = "select * from " + source;
				daPoor.Fill(dataSet);
			}
			catch (Exception fillException) {
				throw fillException;
			}
			finally {
				dataSet.EnforceConstraints = true;
				con.Close();
			}
		}

		public void UpdateDataSource(DataSetPoor ChangedRows) {
			try {
				if ((ChangedRows != null)) {
					con.Open();
					daPoor.Update(ChangedRows);
				}
			}
			catch (Exception updateException) {
				throw updateException;
			}
			finally {
				con.Close();
			}
		}

		public void LoadDataSet() {
			DataSetPoor tempDataSet;
			tempDataSet = new DataSetPoor();
			try {
				FillDataSet(tempDataSet);
			}
			catch (Exception eFillDataSet) {
				throw eFillDataSet;
			}
			try {
				dataSet.Clear();
				dataSet.Merge(tempDataSet);
			}
			catch (Exception eLoadMerge) {
				throw eLoadMerge;
			}
		}

		public void UpdateDataSet() {
			DataSetPoor changedDataSet = new DataSetPoor();
			BindingContext[dataSet, "Poor"].EndCurrentEdit();
			changedDataSet = (DataSetPoor)dataSet.GetChanges();
			if (changedDataSet != null) {
				try {
					UpdateDataSource(changedDataSet);
					//dataSet.Merge(changedDataSet);
					dataSet.AcceptChanges();
				}
				catch (Exception eUpdate) {
					throw eUpdate;
				}
			}
		}

		private void Undo() {
			dataSet.RejectChanges();
		}

		private void RefreshData() {
			try {
				LoadDataSet();
			}
			catch (Exception eLoad) {
				MessageBox.Show(eLoad.ToString());
			}
		}

		private void Save() {
			try {
				UpdateDataSet();
			}
			catch (Exception eUpdate) {
				MessageBox.Show(eUpdate.Message);
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
			while (row < dataSet.Tables["Poor"].Rows.Count && row >=0) {
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
			if (row < dataSet.Tables["Poor"].Rows.Count && row >= 0) {
				gridStudent.CurrentRowIndex = row;
				gridStudent.Select(row);
			}
		}
		public void Replace(object search, object replace, bool regular, bool back) {
		}
		public ReportDocument GetReportDocument() {
			ReportPoor doc = new ReportPoor();
			doc.SetDataSource(dataSet);
			return doc;
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
					/*

				case Keys.Alt | Keys.Left:
					gridStudent.CurrentRowIndex = 0;
					break;

				case Keys.Alt | Keys.Up:
					if (gridStudent.CurrentRowIndex > 0)
                        gridStudent.CurrentRowIndex -= 1;
					break;

				case Keys.Alt | Keys.Down:
					if (gridStudent.CurrentRowIndex < dataSet.Tables["Poor"].Rows.Count)
						gridStudent.CurrentRowIndex += 1;
					break;

				case Keys.Alt | Keys.Right:
					gridStudent.CurrentRowIndex = dataSet.Tables["Poor"].Rows.Count - 1;
					break;
			*/
				default :
					if (ActiveControl != null)
						Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, (int)e.KeyData, 1);
					break;
			}
		}
		private void Copy() {
			string strData = "";
			for (int i=0;i<dataSet.Tables["Poor"].Rows.Count;i++) {
				if (gridStudent.IsSelected(i)) {
					for (int j = 0; j < dataSet.Tables["Poor"].Columns.Count; j++) {
						strData += dataSet.Tables["Poor"].Rows[i].ItemArray.GetValue(j).ToString() + "\t";
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
							DataRow row = dataSet.Tables["Poor"].NewRow();
							string[] words = line.Split(new Char[] {'\t'});
							int j = 0;
							while (j < dataSet.Tables["Poor"].Columns.Count - 1 && j < words.Length) {
								row[j + 1] = words[j];
								j++;
							}
							rows.Add(row);
						}
					}
					System.Collections.IEnumerator enumerator = rows.GetEnumerator();
					while ( enumerator.MoveNext() )
						dataSet.Tables["Poor"].Rows.Add((DataRow)enumerator.Current);
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
		private void gridStudent_CurrentCellChanged(object sender, System.EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				parent.statusRecord.Text = string.Format("{0}/{1}", gridStudent.CurrentRowIndex + 1, dataSet.Tables["Poor"].Rows.Count);
			}
		}

		private void textPoorFamily_TextChanged(object sender, System.EventArgs e) {
			int family;
			float income;
			try {
				family = Convert.ToInt32(textPoorFamily.Text);
				income = Convert.ToSingle(textPoorIncome.Text);
				float per_one = income / family;
				textPoorPerIncome.Text = per_one.ToString();
			}
			catch (Exception) {
				textPoorPerIncome.Text = "";
			}
		}
	}
}

