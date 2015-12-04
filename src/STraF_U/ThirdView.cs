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
	/// Гуравдагч суралцагч.
	/// </summary>
	public class ThirdView : Form, IStudentChild {

		#region Хувьсагчид
		private ReportThird doc;
		private string prof;
		private DataRow profInfo;
		private int state;
		private DataView dvMaster;
		private DataView dvChild;
		private string master;
		private string child;
		private string strFilter;
		private MenuItem cmdPromote;
		private MenuItem menuStudent;
		private MenuItem cmdSetState;
		private DataGridTextBoxColumn colClass;
		private MainMenu menuMain;
		private TabControl tabDetail;
		private TabPage pageDoc;
		private Splitter splitter1;
		private DataGridTableStyle dataGridTableStyle;
		private DataGridTextBoxColumn dataGridTextBoxColumnLName;
		private DataGridTextBoxColumn dataGridTextBoxColumnFName;
		private DataGridTextBoxColumn dataGridTextBoxColumnPasNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnRegNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnGrade;
		private DataGridTextBoxColumn dataGridTextBoxColumnGPA;
		private DataGridTextBoxColumn dataGridTextBoxColumnAdmisNo;
		private DataGridTextBoxColumn dataGridTextBoxColumnNote;
		private DataGridTextBoxColumn dataGridTextBoxColumnGender;
		private GroupBox groupBox2;
		private Label label1;
		private Label label6;
		private GroupBox groupBox1;
		private Label label9;
		private Label label10;
		private OleDbConnection con;
		private ComboBox comboRegion;
		private DataGridTextBoxColumn dataGridTextBoxColumnRegion;
		private TextBox textAbout2;
		private TextBox textReg2;
		private TextBox textAbout1;
		private TextBox textReg1;
		private TabPage pageTuition;
		private DataGrid gridTuition;
		private MenuItem cmdTransfer;
		private DataGridTableStyle dataGridTableStyleTuition;
		private DataGridTextBoxColumn dataGridTextBoxColumnDate;
		private DataGridTextBoxColumn dataGridTextBoxColumnSize;
		private DataGridTextBoxColumn dataGridTextBoxColumnDesc;
		private OleDbDataAdapter daTuition;
		private STraF_U.DatasetThird dataSet;
		private MenuItem cmdFilter;
		private DataGridTextBoxColumn dataGridTextBoxColumnState;
		private ContextMenu contextGrid;
		private MenuItem cmdPopCut;
		private MenuItem cmdPopCopy;
		private MenuItem cmdPopCopyWithColumn;
		private MenuItem cmdPopPaste;
		private MenuItem cmdPopDelete;
		private DataGrid gridStudent;
		private OleDbDataAdapter daStudent;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem cmdStateNew;
		private System.Windows.Forms.MenuItem cmdStateAvl;
		private System.Windows.Forms.MenuItem cmdStateAbsent;
		private System.Windows.Forms.MenuItem cmdStateCancel;
		private System.Windows.Forms.MenuItem cmdStateGrade;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		public ThirdView() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			master = "Third";
			child = "ThirdTuition";
			strFilter = "";
			prof = "";
			state = (int)(Student.State.NEW | Student.State.AVL | Student.State.ABSENT);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ThirdView));
			this.cmdPromote = new System.Windows.Forms.MenuItem();
			this.menuStudent = new System.Windows.Forms.MenuItem();
			this.cmdTransfer = new System.Windows.Forms.MenuItem();
			this.cmdSetState = new System.Windows.Forms.MenuItem();
			this.cmdStateNew = new System.Windows.Forms.MenuItem();
			this.cmdStateAvl = new System.Windows.Forms.MenuItem();
			this.cmdStateAbsent = new System.Windows.Forms.MenuItem();
			this.cmdStateCancel = new System.Windows.Forms.MenuItem();
			this.cmdStateGrade = new System.Windows.Forms.MenuItem();
			this.cmdFilter = new System.Windows.Forms.MenuItem();
			this.colClass = new System.Windows.Forms.DataGridTextBoxColumn();
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.gridStudent = new System.Windows.Forms.DataGrid();
			this.contextGrid = new System.Windows.Forms.ContextMenu();
			this.cmdPopCut = new System.Windows.Forms.MenuItem();
			this.cmdPopCopy = new System.Windows.Forms.MenuItem();
			this.cmdPopCopyWithColumn = new System.Windows.Forms.MenuItem();
			this.cmdPopPaste = new System.Windows.Forms.MenuItem();
			this.cmdPopDelete = new System.Windows.Forms.MenuItem();
			this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnLName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGender = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGrade = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGPA = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRegion = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAdmisNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPasNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRegNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnNote = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tabDetail = new System.Windows.Forms.TabControl();
			this.pageDoc = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textAbout2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textReg2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textAbout1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textReg1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pageTuition = new System.Windows.Forms.TabPage();
			this.gridTuition = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleTuition = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSize = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDesc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.con = new System.Data.OleDb.OleDbConnection();
			this.comboRegion = new System.Windows.Forms.ComboBox();
			this.daTuition = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet = new STraF_U.DatasetThird();
			this.daStudent = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
			this.tabDetail.SuspendLayout();
			this.pageDoc.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pageTuition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTuition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdPromote
			// 
			this.cmdPromote.Index = 0;
			this.cmdPromote.Text = "&Анги дэвшvvлэх";
			this.cmdPromote.Click += new System.EventHandler(this.cmdPromote_Click);
			// 
			// menuStudent
			// 
			this.menuStudent.Index = 0;
			this.menuStudent.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmdPromote,
																						this.cmdTransfer,
																						this.cmdSetState,
																						this.cmdFilter});
			this.menuStudent.MergeOrder = 3;
			this.menuStudent.Text = "&Оюутан";
			// 
			// cmdTransfer
			// 
			this.cmdTransfer.Index = 1;
			this.cmdTransfer.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
			this.cmdTransfer.Text = "&Шилжvvлгэ бичих";
			this.cmdTransfer.Click += new System.EventHandler(this.cmdTransfer_Click);
			// 
			// cmdSetState
			// 
			this.cmdSetState.Index = 2;
			this.cmdSetState.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmdStateNew,
																						this.cmdStateAvl,
																						this.cmdStateAbsent,
																						this.cmdStateCancel,
																						this.cmdStateGrade});
			this.cmdSetState.Text = "Төлө&в өөрчлөх";
			// 
			// cmdStateNew
			// 
			this.cmdStateNew.Index = 0;
			this.cmdStateNew.Text = "&Шинэ";
			this.cmdStateNew.Click += new System.EventHandler(this.cmdChangeState_Click);
			// 
			// cmdStateAvl
			// 
			this.cmdStateAvl.Index = 1;
			this.cmdStateAvl.Text = "С&урч байгаа";
			this.cmdStateAvl.Click += new System.EventHandler(this.cmdChangeState_Click);
			// 
			// cmdStateAbsent
			// 
			this.cmdStateAbsent.Index = 2;
			this.cmdStateAbsent.Text = "&Чөлөөтэй";
			this.cmdStateAbsent.Click += new System.EventHandler(this.cmdChangeState_Click);
			// 
			// cmdStateCancel
			// 
			this.cmdStateCancel.Index = 3;
			this.cmdStateCancel.Text = "&Цуцлах";
			this.cmdStateCancel.Click += new System.EventHandler(this.cmdChangeState_Click);
			// 
			// cmdStateGrade
			// 
			this.cmdStateGrade.Index = 4;
			this.cmdStateGrade.Text = "&Төгссөн";
			this.cmdStateGrade.Click += new System.EventHandler(this.cmdChangeState_Click);
			// 
			// cmdFilter
			// 
			this.cmdFilter.Index = 3;
			this.cmdFilter.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
			this.cmdFilter.Text = "&Ялгаж харах";
			this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
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
			this.gridStudent.AllowNavigation = false;
			this.gridStudent.BackColor = System.Drawing.Color.White;
			this.gridStudent.CaptionVisible = false;
			this.gridStudent.ContextMenu = this.contextGrid;
			this.gridStudent.DataMember = "";
			this.gridStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.gridStudent.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridStudent.Name = "gridStudent";
			this.gridStudent.Size = new System.Drawing.Size(648, 246);
			this.gridStudent.TabIndex = 0;
			this.gridStudent.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyle});
			this.gridStudent.Resize += new System.EventHandler(this.gridStudent_Resize);
			this.gridStudent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridStudent_MouseDown);
			this.gridStudent.CurrentCellChanged += new System.EventHandler(this.gridStudent_CurrentCellChanged);
			this.gridStudent.Scroll += new System.EventHandler(this.gridStudent_Scroll);
			// 
			// contextGrid
			// 
			this.contextGrid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmdPopCut,
																						this.cmdPopCopy,
																						this.cmdPopCopyWithColumn,
																						this.cmdPopPaste,
																						this.cmdPopDelete});
			// 
			// cmdPopCut
			// 
			this.cmdPopCut.Index = 0;
			this.cmdPopCut.Text = "&Зөөх";
			this.cmdPopCut.Click += new System.EventHandler(this.Cut);
			// 
			// cmdPopCopy
			// 
			this.cmdPopCopy.Index = 1;
			this.cmdPopCopy.Text = "&Хуулах";
			this.cmdPopCopy.Click += new System.EventHandler(this.Copy);
			// 
			// cmdPopCopyWithColumn
			// 
			this.cmdPopCopyWithColumn.Index = 2;
			this.cmdPopCopyWithColumn.Text = "&Баганы нэртэй хамт хуулах";
			this.cmdPopCopyWithColumn.Click += new System.EventHandler(this.CopyWithColumns);
			// 
			// cmdPopPaste
			// 
			this.cmdPopPaste.Index = 3;
			this.cmdPopPaste.Text = "&Оруулах";
			this.cmdPopPaste.Click += new System.EventHandler(this.Paste);
			// 
			// cmdPopDelete
			// 
			this.cmdPopDelete.Index = 4;
			this.cmdPopDelete.Text = "Ха&сах";
			this.cmdPopDelete.Click += new System.EventHandler(this.cmdPopDelete_Click);
			// 
			// dataGridTableStyle
			// 
			this.dataGridTableStyle.DataGrid = this.gridStudent;
			this.dataGridTableStyle.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												 this.dataGridTextBoxColumnLName,
																												 this.dataGridTextBoxColumnFName,
																												 this.dataGridTextBoxColumnGender,
																												 this.dataGridTextBoxColumnGrade,
																												 this.dataGridTextBoxColumnGPA,
																												 this.dataGridTextBoxColumnRegion,
																												 this.dataGridTextBoxColumnAdmisNo,
																												 this.dataGridTextBoxColumnPasNo,
																												 this.dataGridTextBoxColumnRegNo,
																												 this.dataGridTextBoxColumnState,
																												 this.dataGridTextBoxColumnNote});
			this.dataGridTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle.MappingName = "Third";
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
			this.dataGridTextBoxColumnGender.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnGender.Format = "";
			this.dataGridTextBoxColumnGender.FormatInfo = null;
			this.dataGridTextBoxColumnGender.HeaderText = "Хүйс";
			this.dataGridTextBoxColumnGender.MappingName = "gender";
			this.dataGridTextBoxColumnGender.Width = 35;
			// 
			// dataGridTextBoxColumnGrade
			// 
			this.dataGridTextBoxColumnGrade.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnGrade.Format = "";
			this.dataGridTextBoxColumnGrade.FormatInfo = null;
			this.dataGridTextBoxColumnGrade.HeaderText = "Курс";
			this.dataGridTextBoxColumnGrade.MappingName = "grade";
			this.dataGridTextBoxColumnGrade.Width = 35;
			// 
			// dataGridTextBoxColumnGPA
			// 
			this.dataGridTextBoxColumnGPA.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnGPA.Format = "";
			this.dataGridTextBoxColumnGPA.FormatInfo = null;
			this.dataGridTextBoxColumnGPA.HeaderText = "Голч дүн";
			this.dataGridTextBoxColumnGPA.MappingName = "gpa";
			this.dataGridTextBoxColumnGPA.Width = 35;
			// 
			// dataGridTextBoxColumnRegion
			// 
			this.dataGridTextBoxColumnRegion.Format = "";
			this.dataGridTextBoxColumnRegion.FormatInfo = null;
			this.dataGridTextBoxColumnRegion.HeaderText = "Аймаг";
			this.dataGridTextBoxColumnRegion.MappingName = "region";
			this.dataGridTextBoxColumnRegion.Width = 90;
			// 
			// dataGridTextBoxColumnAdmisNo
			// 
			this.dataGridTextBoxColumnAdmisNo.Format = "";
			this.dataGridTextBoxColumnAdmisNo.FormatInfo = null;
			this.dataGridTextBoxColumnAdmisNo.HeaderText = "Томилолт";
			this.dataGridTextBoxColumnAdmisNo.MappingName = "admisno";
			this.dataGridTextBoxColumnAdmisNo.Width = 75;
			// 
			// dataGridTextBoxColumnPasNo
			// 
			this.dataGridTextBoxColumnPasNo.Format = "";
			this.dataGridTextBoxColumnPasNo.FormatInfo = null;
			this.dataGridTextBoxColumnPasNo.HeaderText = "Иргэний үнэмлэх";
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
			// dataGridTextBoxColumnState
			// 
			this.dataGridTextBoxColumnState.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnState.Format = "";
			this.dataGridTextBoxColumnState.FormatInfo = null;
			this.dataGridTextBoxColumnState.HeaderText = "Төлөв";
			this.dataGridTextBoxColumnState.MappingName = "state";
			this.dataGridTextBoxColumnState.ReadOnly = true;
			this.dataGridTextBoxColumnState.Width = 50;
			// 
			// dataGridTextBoxColumnNote
			// 
			this.dataGridTextBoxColumnNote.Format = "";
			this.dataGridTextBoxColumnNote.FormatInfo = null;
			this.dataGridTextBoxColumnNote.HeaderText = "Тайлбар";
			this.dataGridTextBoxColumnNote.MappingName = "note";
			this.dataGridTextBoxColumnNote.Width = 150;
			// 
			// tabDetail
			// 
			this.tabDetail.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.pageDoc,
																					this.pageTuition});
			this.tabDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabDetail.Location = new System.Drawing.Point(0, 249);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.SelectedIndex = 0;
			this.tabDetail.Size = new System.Drawing.Size(648, 128);
			this.tabDetail.TabIndex = 1;
			this.tabDetail.Text = "tabControl1";
			// 
			// pageDoc
			// 
			this.pageDoc.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.groupBox2,
																				  this.groupBox1});
			this.pageDoc.Location = new System.Drawing.Point(4, 22);
			this.pageDoc.Name = "pageDoc";
			this.pageDoc.Size = new System.Drawing.Size(640, 102);
			this.pageDoc.TabIndex = 1;
			this.pageDoc.Text = "Баримт";
			this.pageDoc.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textAbout2,
																					this.label1,
																					this.textReg2,
																					this.label6});
			this.groupBox2.Location = new System.Drawing.Point(336, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 88);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Хоёр дахь суралцагч";
			// 
			// textAbout2
			// 
			this.textAbout2.AcceptsReturn = true;
			this.textAbout2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAbout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.textAbout2.Location = new System.Drawing.Point(8, 40);
			this.textAbout2.MaxLength = 50;
			this.textAbout2.Multiline = true;
			this.textAbout2.Name = "textAbout2";
			this.textAbout2.Size = new System.Drawing.Size(272, 40);
			this.textAbout2.TabIndex = 3;
			this.textAbout2.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дэлгэрэнгvй:";
			// 
			// textReg2
			// 
			this.textReg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.textReg2.Location = new System.Drawing.Point(176, 16);
			this.textReg2.MaxLength = 20;
			this.textReg2.Name = "textReg2";
			this.textReg2.Size = new System.Drawing.Size(104, 20);
			this.textReg2.TabIndex = 2;
			this.textReg2.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(112, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Регистр:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textAbout1,
																					this.label9,
																					this.textReg1,
																					this.label10});
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 88);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Эхний суралцагч";
			// 
			// textAbout1
			// 
			this.textAbout1.AcceptsReturn = true;
			this.textAbout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAbout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.textAbout1.Location = new System.Drawing.Point(8, 40);
			this.textAbout1.MaxLength = 50;
			this.textAbout1.Multiline = true;
			this.textAbout1.Name = "textAbout1";
			this.textAbout1.Size = new System.Drawing.Size(288, 40);
			this.textAbout1.TabIndex = 3;
			this.textAbout1.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "Дэлгэрэнгүй:";
			// 
			// textReg1
			// 
			this.textReg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.textReg1.Location = new System.Drawing.Point(192, 16);
			this.textReg1.MaxLength = 20;
			this.textReg1.Name = "textReg1";
			this.textReg1.Size = new System.Drawing.Size(104, 20);
			this.textReg1.TabIndex = 2;
			this.textReg1.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(120, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "Регистр:";
			// 
			// pageTuition
			// 
			this.pageTuition.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.gridTuition});
			this.pageTuition.Location = new System.Drawing.Point(4, 22);
			this.pageTuition.Name = "pageTuition";
			this.pageTuition.Size = new System.Drawing.Size(640, 102);
			this.pageTuition.TabIndex = 2;
			this.pageTuition.Text = "Төлбөр";
			// 
			// gridTuition
			// 
			this.gridTuition.CaptionVisible = false;
			this.gridTuition.DataMember = "";
			this.gridTuition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridTuition.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridTuition.Name = "gridTuition";
			this.gridTuition.Size = new System.Drawing.Size(640, 102);
			this.gridTuition.TabIndex = 0;
			this.gridTuition.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyleTuition});
			// 
			// dataGridTableStyleTuition
			// 
			this.dataGridTableStyleTuition.DataGrid = this.gridTuition;
			this.dataGridTableStyleTuition.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														this.dataGridTextBoxColumnDate,
																														this.dataGridTextBoxColumnSize,
																														this.dataGridTextBoxColumnDesc});
			this.dataGridTableStyleTuition.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleTuition.MappingName = "ThirdTuition";
			// 
			// dataGridTextBoxColumnDate
			// 
			this.dataGridTextBoxColumnDate.Format = "";
			this.dataGridTextBoxColumnDate.FormatInfo = null;
			this.dataGridTextBoxColumnDate.HeaderText = "Огноо";
			this.dataGridTextBoxColumnDate.MappingName = "tdate";
			this.dataGridTextBoxColumnDate.ReadOnly = true;
			this.dataGridTextBoxColumnDate.Width = 150;
			// 
			// dataGridTextBoxColumnSize
			// 
			this.dataGridTextBoxColumnSize.Format = "";
			this.dataGridTextBoxColumnSize.FormatInfo = null;
			this.dataGridTextBoxColumnSize.HeaderText = "Хэмжээ";
			this.dataGridTextBoxColumnSize.MappingName = "tsize";
			this.dataGridTextBoxColumnSize.Width = 150;
			// 
			// dataGridTextBoxColumnDesc
			// 
			this.dataGridTextBoxColumnDesc.Format = "";
			this.dataGridTextBoxColumnDesc.FormatInfo = null;
			this.dataGridTextBoxColumnDesc.HeaderText = "Зориулалт";
			this.dataGridTextBoxColumnDesc.MappingName = "tdesc";
			this.dataGridTextBoxColumnDesc.Width = 150;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 246);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(648, 3);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// con
			// 
			this.con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Projects\STraF_U\data\data.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// comboRegion
			// 
			this.comboRegion.DisplayMember = "id";
			this.comboRegion.Items.AddRange(new object[] {
															 "Архангай",
															 "Баян-Өлгий",
															 "Баянхонгор",
															 "Булган",
															 "Говь-Алтай",
															 "Дорноговь",
															 "Дорнод",
															 "Дундговь",
															 "Завхан",
															 "Өвөрхангай",
															 "Өмнөговь",
															 "Сvхбаатар",
															 "Сэлэнгэ",
															 "Төв",
															 "Увс",
															 "Ховд",
															 "Хөвсгөл",
															 "Хэнтий",
															 "Дархан-Уул",
															 "Улаанбаатар",
															 "Орхон-Уул",
															 "Говьсvмбэр"});
			this.comboRegion.Location = new System.Drawing.Point(16, 16);
			this.comboRegion.Name = "comboRegion";
			this.comboRegion.Size = new System.Drawing.Size(121, 21);
			this.comboRegion.TabIndex = 2;
			this.comboRegion.ValueMember = "id";
			this.comboRegion.Visible = false;
			// 
			// daTuition
			// 
			this.daTuition.DeleteCommand = this.oleDbDeleteCommand1;
			this.daTuition.InsertCommand = this.oleDbInsertCommand1;
			this.daTuition.SelectCommand = this.oleDbSelectCommand2;
			this.daTuition.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								new System.Data.Common.DataTableMapping("Table", "ThirdTuition", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("stid", "stid"),
																																																				new System.Data.Common.DataColumnMapping("tdate", "tdate"),
																																																				new System.Data.Common.DataColumnMapping("tsize", "tsize"),
																																																				new System.Data.Common.DataColumnMapping("tdesc", "tdesc")})});
			this.daTuition.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM ThirdTuition WHERE (stid = ?) AND (tdate = ?) AND (tdesc = ? OR ? IS " +
				"NULL AND tdesc IS NULL) AND (tsize = ? OR ? IS NULL AND tsize IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.con;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stid", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "stid", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tdate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "tdate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tdesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "tdesc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tdesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "tdesc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tsize", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tsize", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tsize1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tsize", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO ThirdTuition(stid, tdate, tdesc, tsize) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.con;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("stid", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "stid", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("tdate", System.Data.OleDb.OleDbType.DBDate, 0, "tdate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("tdesc", System.Data.OleDb.OleDbType.VarWChar, 50, "tdesc"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("tsize", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tsize", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT stid, tdate, tdesc, tsize FROM ThirdTuition";
			this.oleDbSelectCommand2.Connection = this.con;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE ThirdTuition SET stid = ?, tdate = ?, tdesc = ?, tsize = ? WHERE (stid = ?" +
				") AND (tdate = ?) AND (tdesc = ? OR ? IS NULL AND tdesc IS NULL) AND (tsize = ? " +
				"OR ? IS NULL AND tsize IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.con;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("stid", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "stid", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("tdate", System.Data.OleDb.OleDbType.DBDate, 0, "tdate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("tdesc", System.Data.OleDb.OleDbType.VarWChar, 50, "tdesc"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("tsize", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tsize", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_stid", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "stid", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tdate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "tdate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tdesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "tdesc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tdesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "tdesc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tsize", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tsize", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_tsize1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "tsize", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DatasetThird";
			this.dataSet.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet.Namespace = "http://tempuri.org/DatasetThird.xsd";
			// 
			// daStudent
			// 
			this.daStudent.DeleteCommand = this.oleDbDeleteCommand2;
			this.daStudent.InsertCommand = this.oleDbInsertCommand2;
			this.daStudent.SelectCommand = this.oleDbSelectCommand1;
			this.daStudent.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								new System.Data.Common.DataTableMapping("Table", "Third", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("about1", "about1"),
																																																		 new System.Data.Common.DataColumnMapping("about2", "about2"),
																																																		 new System.Data.Common.DataColumnMapping("admisno", "admisno"),
																																																		 new System.Data.Common.DataColumnMapping("fname", "fname"),
																																																		 new System.Data.Common.DataColumnMapping("gender", "gender"),
																																																		 new System.Data.Common.DataColumnMapping("gpa", "gpa"),
																																																		 new System.Data.Common.DataColumnMapping("grade", "grade"),
																																																		 new System.Data.Common.DataColumnMapping("id", "id"),
																																																		 new System.Data.Common.DataColumnMapping("lname", "lname"),
																																																		 new System.Data.Common.DataColumnMapping("note", "note"),
																																																		 new System.Data.Common.DataColumnMapping("pasno", "pasno"),
																																																		 new System.Data.Common.DataColumnMapping("prof", "prof"),
																																																		 new System.Data.Common.DataColumnMapping("region", "region"),
																																																		 new System.Data.Common.DataColumnMapping("regno", "regno"),
																																																		 new System.Data.Common.DataColumnMapping("regno1", "regno1"),
																																																		 new System.Data.Common.DataColumnMapping("regno2", "regno2"),
																																																		 new System.Data.Common.DataColumnMapping("state", "state")})});
			this.daStudent.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM Third WHERE (id = ?) AND (about1 = ? OR ? IS NULL AND about1 IS NULL) AND (about2 = ? OR ? IS NULL AND about2 IS NULL) AND (admisno = ?) AND (fname = ?) AND (gender = ? OR ? IS NULL AND gender IS NULL) AND (gpa = ? OR ? IS NULL AND gpa IS NULL) AND (grade = ? OR ? IS NULL AND grade IS NULL) AND (lname = ? OR ? IS NULL AND lname IS NULL) AND ([note] = ? OR ? IS NULL AND [note] IS NULL) AND (pasno = ?) AND (prof = ?) AND (region = ? OR ? IS NULL AND region IS NULL) AND (regno = ?) AND (regno1 = ? OR ? IS NULL AND regno1 IS NULL) AND (regno2 = ? OR ? IS NULL AND regno2 IS NULL) AND (state = ? OR ? IS NULL AND state IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.con;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_admisno", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "admisno", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "fname", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gender", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "gender", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gender1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "gender", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gpa", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gpa1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_grade", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_grade1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lname", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lname", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_note", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "note", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_note1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "note", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_pasno", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "pasno", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_prof", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "prof", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_region", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_region1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno11", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno2", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno21", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_state", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_state1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Third(about1, about2, admisno, fname, gender, gpa, grade, lname, [not" +
				"e], pasno, prof, region, regno, regno1, regno2, state) VALUES (?, ?, ?, ?, ?, ?," +
				" ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.con;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("about1", System.Data.OleDb.OleDbType.VarWChar, 50, "about1"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("about2", System.Data.OleDb.OleDbType.VarWChar, 50, "about2"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("admisno", System.Data.OleDb.OleDbType.VarWChar, 10, "admisno"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("fname", System.Data.OleDb.OleDbType.VarWChar, 20, "fname"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("gender", System.Data.OleDb.OleDbType.VarWChar, 2, "gender"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("gpa", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("grade", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lname", System.Data.OleDb.OleDbType.VarWChar, 20, "lname"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("note", System.Data.OleDb.OleDbType.VarWChar, 50, "note"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("pasno", System.Data.OleDb.OleDbType.VarWChar, 10, "pasno"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("prof", System.Data.OleDb.OleDbType.VarWChar, 10, "prof"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("region", System.Data.OleDb.OleDbType.VarWChar, 20, "region"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("regno", System.Data.OleDb.OleDbType.VarWChar, 10, "regno"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("regno1", System.Data.OleDb.OleDbType.VarWChar, 10, "regno1"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("regno2", System.Data.OleDb.OleDbType.VarWChar, 10, "regno2"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("state", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT about1, about2, admisno, fname, gender, gpa, grade, id, lname, [note], pas" +
				"no, prof, region, regno, regno1, regno2, state FROM Third";
			this.oleDbSelectCommand1.Connection = this.con;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE Third SET about1 = ?, about2 = ?, admisno = ?, fname = ?, gender = ?, gpa = ?, grade = ?, lname = ?, [note] = ?, pasno = ?, prof = ?, region = ?, regno = ?, regno1 = ?, regno2 = ?, state = ? WHERE (id = ?) AND (about1 = ? OR ? IS NULL AND about1 IS NULL) AND (about2 = ? OR ? IS NULL AND about2 IS NULL) AND (admisno = ?) AND (fname = ?) AND (gender = ? OR ? IS NULL AND gender IS NULL) AND (gpa = ? OR ? IS NULL AND gpa IS NULL) AND (grade = ? OR ? IS NULL AND grade IS NULL) AND (lname = ? OR ? IS NULL AND lname IS NULL) AND ([note] = ? OR ? IS NULL AND [note] IS NULL) AND (pasno = ?) AND (prof = ?) AND (region = ? OR ? IS NULL AND region IS NULL) AND (regno = ?) AND (regno1 = ? OR ? IS NULL AND regno1 IS NULL) AND (regno2 = ? OR ? IS NULL AND regno2 IS NULL) AND (state = ? OR ? IS NULL AND state IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.con;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("about1", System.Data.OleDb.OleDbType.VarWChar, 50, "about1"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("about2", System.Data.OleDb.OleDbType.VarWChar, 50, "about2"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("admisno", System.Data.OleDb.OleDbType.VarWChar, 10, "admisno"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("fname", System.Data.OleDb.OleDbType.VarWChar, 20, "fname"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("gender", System.Data.OleDb.OleDbType.VarWChar, 2, "gender"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("gpa", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("grade", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("lname", System.Data.OleDb.OleDbType.VarWChar, 20, "lname"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("note", System.Data.OleDb.OleDbType.VarWChar, 50, "note"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("pasno", System.Data.OleDb.OleDbType.VarWChar, 10, "pasno"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("prof", System.Data.OleDb.OleDbType.VarWChar, 10, "prof"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("region", System.Data.OleDb.OleDbType.VarWChar, 20, "region"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("regno", System.Data.OleDb.OleDbType.VarWChar, 10, "regno"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("regno1", System.Data.OleDb.OleDbType.VarWChar, 10, "regno1"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("regno2", System.Data.OleDb.OleDbType.VarWChar, 10, "regno2"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("state", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_about21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "about2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_admisno", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "admisno", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_fname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "fname", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gender", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "gender", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gender1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "gender", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gpa", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_gpa1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "gpa", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_grade", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_grade1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "grade", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lname", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lname", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_lname1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "lname", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_note", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "note", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_note1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "note", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_pasno", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "pasno", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_prof", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "prof", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_region", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_region1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno11", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno2", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_regno21", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "regno2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_state", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_state1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "state", System.Data.DataRowVersion.Original, null));
			// 
			// menuItem5
			// 
			this.menuItem5.Index = -1;
			this.menuItem5.Text = "";
			// 
			// ThirdView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 377);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboRegion,
																		  this.gridStudent,
																		  this.splitter1,
																		  this.tabDetail});
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuMain;
			this.Name = "ThirdView";
			this.ShowInTaskbar = false;
			this.Text = "Гуравдагч";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThirdView_KeyDown);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridStudent_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
			this.tabDetail.ResumeLayout(false);
			this.pageDoc.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pageTuition.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTuition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void MakeFilter() {
			strFilter = "";
			for (int i=0; i < Student.States.Length; i++) {
				if ((state & Student.States[i]) == Student.States[i]) {
					strFilter += "state=" + Student.States[i] + " or ";
				}
			}
			if (strFilter != "") {
				strFilter = strFilter.Remove(strFilter.Length - 3, 3);
				strFilter = "prof='" + prof + "' and (" + strFilter + ")";
			}
			else {
				strFilter = "prof='" + prof + "'";
			}
		}
		public void ChangeProf(string prof) {
			if (this.prof != prof) {
				this.prof = prof;
				profInfo = Straf.datasetGlobal.Prof.Rows.Find(prof);
				MakeFilter();
				dvMaster.RowFilter = strFilter;
				dataSet.Tables[master].Columns["prof"].DefaultValue = prof;
			}
		}
		public ReportDocument GetDocument() {
			if (doc == null) {
				doc = new ReportThird();
				doc.SetDataSource(dataSet);
			}
			return doc;
		}
		private void ThirdView_KeyDown(object sender, KeyEventArgs e) {
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
			this.BindingContext[dvMaster, ""].Position = 0;
		}
		private void MovePrev() {
			this.BindingContext[dvMaster, ""].Position -= 1;
		}
		private void MoveNext() {
			this.BindingContext[dvMaster, ""].Position += 1;
		}
		private void MoveLast() {
			this.BindingContext[dvMaster, ""].Position = this.BindingContext[dvMaster, ""].Count - 1;
		}
		private void GoTo() {
			GotoDlg dlg = new GotoDlg();
			dlg.labelTitle.Text = "Байрлал: (1 - " + this.BindingContext[dvMaster, ""].Count + ")";
			if (dlg.ShowDialog() == DialogResult.OK) {
				try {
					int no;
					no = Convert.ToInt32(dlg.textPos.Text);
					this.BindingContext[dvMaster, ""].Position = no - 1;
				}
				catch (Exception) {}
			}
		}
		private void gridStudent_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				DataGrid.HitTestInfo hit;
				hit = gridStudent.HitTest(e.X, e.Y);
				int hitRow = hit.Row;
				if (hitRow != -1 && gridStudent.IsSelected(hitRow)) {
					string dragText = "";
					for (int i=0; i < dvMaster.Count; i++) {
						if (gridStudent.IsSelected(i)) {
							for (int j=1; j < dataSet.Tables[master].Columns.Count; j++) {
								dragText += dvMaster[i].Row[j] + "\t";
							}
							dragText += "\r\n";
						}
					}
					gridStudent.DoDragDrop(dragText, DragDropEffects.Copy | DragDropEffects.Move);
				}
			}
		}
		private void dv_PositionChanged(object sender, System.EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				parent.statusRecord.Text = string.Format("{0}/{1}", this.BindingContext[dvMaster, ""].Position + 1, this.BindingContext[dvMaster, ""].Count);
			}
			dvChild.RowFilter = "stid=" + dvMaster[gridStudent.CurrentRowIndex].Row["id"];
		}
		private void gridStudent_CurrentCellChanged(object sender, System.EventArgs e) {
			if (dataSet.Tables[master].Rows.Count > 0) {
				DataGridCell cell = gridStudent.CurrentCell;
				if (cell.ColumnNumber == 5) {
					Rectangle rect = gridStudent.GetCurrentCellBounds();
					comboRegion.SetBounds(rect.X, rect.Y, rect.Width, rect.Height);
					comboRegion.SelectedItem = gridStudent[cell];
					comboRegion.Show();
				}
				else {
					comboRegion.Hide();
				}
			}
		}
		private void gridStudent_Resize(object sender, System.EventArgs e) {
			comboRegion.Hide();
		}

		private void gridStudent_Scroll(object sender, System.EventArgs e) {
			comboRegion.Hide();
		}

		#region Өгөгдөлтэй ажиллах
		
		private void SetBindings() {
			dvMaster = dataSet.Tables[master].DefaultView;
			dvChild = dataSet.Tables[child].DefaultView;
			this.BindingContext[dvMaster, ""].PositionChanged += new EventHandler(dv_PositionChanged);
			gridStudent.SetDataBinding(dvMaster, "");
			dvChild.AllowNew = false;
			dvChild.AllowEdit = false;
			dvChild.AllowDelete = true;
			gridTuition.SetDataBinding(dvChild, "");
			comboRegion.DataSource = Straf.datasetGlobal.Region;
			comboRegion.DisplayMember = "name";
			comboRegion.ValueMember = "name";
			comboRegion.DataBindings.Add("SelectedValue", dvMaster, "region");
			textReg1.DataBindings.Add("Text", dvMaster, "regno1");
			textAbout1.DataBindings.Add("Text", dvMaster, "about1");
			textReg2.DataBindings.Add("Text", dvMaster, "regno2");
			textAbout2.DataBindings.Add("Text", dvMaster, "about2");
		}
		public void FillDataSet(DatasetThird dataset) {
			dataset.EnforceConstraints = false;
			try {
				con.ConnectionString = Straf.strCon;
				con.Open();
				daStudent.Fill(dataset);
				daTuition.Fill(dataset);
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
			DatasetThird tempSet;
			tempSet = new DatasetThird();
			try {
				FillDataSet(tempSet);
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
		public void UpdateDataSource(DatasetThird ChangedRows) {
			try {
				if (ChangedRows != null) {
					con.ConnectionString = Straf.strCon;
					con.Open();
					daStudent.Update(ChangedRows);
					daTuition.Update(ChangedRows);
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
			this.BindingContext[dataSet, master].EndCurrentEdit();
			this.BindingContext[dataSet, child].EndCurrentEdit();

			DatasetThird changedSet = new DatasetThird();
			changedSet = ((DatasetThird)(dataSet.GetChanges()));
			
			if (changedSet != null) {
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
			Cursor.Current = Cursors.WaitCursor;
			try {
				LoadDataSet();
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
			dataSet.RejectChanges();
		}
		private void Copy(object sender, System.EventArgs e) {
			string strData = "";
			for (int i=0; i < dvMaster.Count; i++) {
				if (gridStudent.IsSelected(i)) {
					for (int j = 1; j < dataSet.Tables[master].Columns.Count - 1; j++) {
						strData += dvMaster[i].Row[j] + "\t";
					}
					strData += "\r\n";
				}
			}
			Clipboard.SetDataObject(strData);
		}
		private void CopyWithColumns(object sender, System.EventArgs e) {
			string strData = "";
			for (int i=1; i < dataSet.Tables[master].Columns.Count - 1; i++) {
				strData += dataSet.Tables[master].Columns[i].ColumnName + "\t";
			}
			strData += "\r\n";
			for (int i=0; i < dvMaster.Count; i++) {
				if (gridStudent.IsSelected(i)) {
					for (int j = 1; j < dataSet.Tables[master].Columns.Count - 1; j++) {
						strData += dvMaster[i].Row[j] + "\t";
					}
					strData += "\r\n";
				}
			}
			Clipboard.SetDataObject(strData);
		}
		private void Cut(object sender, System.EventArgs e) {
			Copy(sender, e);
			Win32.SendMessage(gridStudent.Handle, 0x0100, (int) Keys.Delete, 1);
		}
		private void Paste(object sender, System.EventArgs e) {
			IDataObject iData = Clipboard.GetDataObject();

			if (iData.GetDataPresent(typeof(string))) {
				Cursor.Current = Cursors.WaitCursor;
				string strData = (string) iData.GetData(typeof(string));
				try {
					string[] lines = strData.Split(new Char[] {'\n'});
					ArrayList rows = new ArrayList();
					for (int i=0; i<lines.Length;i++) {
						string line = lines[i].Trim(new Char[]{'\r'});
						if (line != "") {
							DataRow row = dataSet.Tables[master].NewRow();
							string[] words = line.Split(new Char[] {'\t'}, dataSet.Tables[master].Columns.Count);
							int j = 0;
							while (j < words.Length && j < dataSet.Tables[master].Columns.Count - 1) {
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
						dataSet.Tables[master].Rows.Add((DataRow) irow.Current);
				}
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
				finally {
					Cursor.Current = Cursors.Default;
				}
			}
			else {
				MessageBox.Show("Clipboard-с өгөгдлийг авч чадахгүй", Straf.appName);
			}
		}
		private void cmdPopDelete_Click(object sender, System.EventArgs e) {
			Win32.SendMessage(gridStudent.Handle, 0x0100, (int) Keys.Delete, 1);
		}
		public int Find(object search, bool regular, bool back) {
			int step = 1;
			if (back) step = -1;
			
			int row = gridStudent.CurrentRowIndex;
			int col = gridStudent.CurrentCell.ColumnNumber;
			string source, data;
			source = Convert.ToString(search);
			source = source.ToUpper();
			
			row += step;
			if (regular) {
				while (0 <= row && row < dvMaster.Count) {
					data = Convert.ToString(gridStudent[row, col]);
					data = data.ToUpper();
					if (data.StartsWith(source))
						break;
					row += step;
				}
			}
			else {
				while (0<=row && row < dvMaster.Count) {
					data = Convert.ToString(gridStudent[row, col]);
					data = data.ToUpper();
					if (data == source)
						break;
					row += step;
				}
			}
			if (0 <= row && row < dvMaster.Count) {
				gridStudent.CurrentRowIndex = row;
				gridStudent.Select(row);
			}
			else
				row = -1;

			return row;
		}
		public int Replace(object search, object replace, bool regular, bool back) {
			int row = Find(search, regular, back);

			if (0 <= row && row < dvMaster.Count) {
				gridStudent.UnSelect(row);
				try {
					gridStudent.CurrentRowIndex = row;
					int col;
					col = gridStudent.CurrentCell.ColumnNumber;	
					string data = gridStudent[row, col].ToString();
					string colName = gridStudent.TableStyles[0].GridColumnStyles[col].MappingName;
					string strReplace = Convert.ToString(replace);
					data = data.Replace(data, strReplace);
					dvMaster[row].BeginEdit();
					dvMaster[row].Row[colName] = data;
					dvMaster[row].EndEdit();
				}
				catch (Exception) {
					MessageBox.Show("Солиход алдаа гарлаа.", Straf.appName);
				}
			}
			else
				row = -1;

			return row;
		}
		public void ReplaceAll(object search, object replace, bool regular) {
		}
		#endregion

		#region Оюутан цэс
		private void cmdPromote_Click(object sender, System.EventArgs e) {
			DataColumn colGrade = dataSet.Tables[master].Columns["grade"];
			int duration = 4;
			try {
				duration = Convert.ToInt32(profInfo["duration"]);
			}
			catch (Exception) {}

			for (int i=0; i < dvMaster.Count; i++) {
				if (gridStudent.IsSelected(i)) {
					DataRowView row = dvMaster[i];
					try {
						int grade = Convert.ToInt32(row.Row[colGrade]);
						if (grade < duration) {
							row.BeginEdit();
							row.Row[colGrade] = grade + 1;
							row.EndEdit();
						}
					}
					catch (Exception) {
						Straf.ShowError("'" + row.Row["fname"] + "' оюутныг анги дэвшүүлэхэд алдаа гарлаа.");
						break;
					}
				}
			}
		}
		private void cmdTransfer_Click(object sender, System.EventArgs e) {
			TransferDlg dlg = new TransferDlg();
			if (dlg.ShowDialog() == DialogResult.OK) {
				float size = 0.0f;
				string desc = "сургалтын төлбөр";
				DateTime date = DateTime.Now;
				
				try {
					size = Convert.ToSingle(dlg.textSize.Text);
					desc = dlg.comboDesc.Text;
					date = Convert.ToDateTime(dlg.dateDate.Text);
				}
				catch(Exception) {
					Straf.ShowError("Шилжүүлгэ буруу бичигдсэн.");
					return;
				}

				for (int i=0; i < dvMaster.Count; i++) {
					if (gridStudent.IsSelected(i)) {
						try {
							DataRow newRow = dataSet.Tables[child].NewRow();
							newRow["stid"] = (int)dvMaster[i].Row[0];
							newRow["tdate"] = date;
							newRow["tsize"] = size;
							newRow["tdesc"] = desc;
							dataSet.Tables[child].Rows.Add(newRow);
						}
						catch (Exception) {
							Straf.ShowError("'" + dvMaster[i].Row["fname"] + "' оюутанд шилжүүлгэ бичихэд алдаа гарлаа.");
							break;
						}
					}
				}
			}
		}
		private void cmdChangeState_Click(object sender, System.EventArgs e) {
			int ind = ((MenuItem) sender).Index;
			int newState = (int) Math.Pow(2, ind);
			
			DataColumn colState = dataSet.Tables[master].Columns["state"];
			
			for (int i=0; i < dvMaster.Count; i++) {
				if (gridStudent.IsSelected(i)) {
					DataRowView row = dvMaster[i];
					row.BeginEdit();
					row.Row[colState]= newState;
					row.EndEdit();
				}
			}
		}
		private void cmdFilter_Click(object sender, System.EventArgs e) {
			FilterDlg dlg = new FilterDlg(state);
			if (dlg.ShowDialog() == DialogResult.OK) {
				state = dlg.State;
				MakeFilter();
				dvMaster.RowFilter = strFilter;
			}
		}
		#endregion
	}
}

