using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace STraF {
	/// <summary>
	/// Summary description for SummaryView.
	/// </summary>
	public class SummaryView : Form {
		private string[] d1={"нэг","хоёр","гурав","дөрөв","тав","зургаа","долоо","найм","ес"};
		private string[] d2={"арав","хорь","гуч","дөч","тавь","жар","дал","ная","ер"};
		private string[] d1_n={"нэгэн","хоёр","гурван","дөрвөн","таван","зургаан","долоон","найман","есөн"}; 
		private string[] d2_n={"арван","хорин","гучин","дөчин","тавин","жаран","далан","наян","ерэн"};
		private string d0="тэг";
		private string d3="зуу";
		private string d3_n="зуун";
		private string d4="мянга";
		private string d6="сая";
		private string d7="миллард";
		private BindingManagerBase managerTransfer;
		private BindingManagerBase managerSummary;
		private Label label1;
		private Label label2;
		private Label label3;
		private System.Data.SqlClient.SqlConnection con;
		private System.Data.DataSet dataSet;
		private TextBox textYear;
		private TextBox textBeginMonth;
		private TextBox textEndMonth;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label label21;
		private TextBox textBox12;
		private Label label22;
		private Label label23;
		private Label label24;
		private Label label25;
		private Label label26;
		private System.Data.DataTable tableSummary;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn7;
		private System.Data.DataColumn dataColumn8;
		private System.Data.DataColumn dataColumn9;
		private System.Data.DataColumn dataColumn10;
		private System.Data.DataColumn dataColumn11;
		private System.Data.DataColumn dataColumn12;
		private System.Data.DataColumn dataColumn13;
		private System.Data.DataColumn dataColumn14;
		private System.Data.DataColumn dataColumn15;
		private System.Data.DataColumn dataColumn16;
		private System.Data.DataColumn dataColumn17;
		private System.Data.DataColumn dataColumn18;
		private System.Data.DataColumn dataColumn19;
		private System.Data.DataColumn dataColumn20;
		private System.Data.DataColumn dataColumn21;
		private System.Data.DataColumn dataColumn22;
		private System.Data.DataColumn dataColumn23;
		private System.Data.DataTable tableTransfer;
		private System.Data.DataColumn dataColumn24;
		private System.Data.DataColumn dataColumn25;
		private System.Data.DataColumn dataColumn26;
		private System.Data.DataColumn dataColumn27;
		private System.Data.DataColumn dataColumn28;
		private System.Data.DataColumn dataColumn29;
		private System.Data.DataColumn dataColumn30;
		private System.Data.DataColumn dataColumn31;
		private System.Data.SqlClient.SqlDataAdapter daSummary;
		private DataGridTableStyle dataGridTableStyle;
		private DataGridTextBoxColumn dataGridTextBoxColumnLoan;
		private DataGridTextBoxColumn dataGridTextBoxColumnHelp;
		private DataGridTextBoxColumn dataGridTextBoxColumnPrize;
		private System.Data.DataColumn dataColumn32;
		private DataGridTextBoxColumn dataGridTextBoxColumnTotalLoan;
		private DataGridTextBoxColumn dataGridTextBoxColumnMoneyTotal;
		private DataGridTextBoxColumn dataGridTextBoxColumnHerder;
		private DataGridTextBoxColumn dataGridTextBoxColumnPoor;
		private DataGridTextBoxColumn dataGridTextBoxColumnThird;
		private DataGridTextBoxColumn dataGridTextBoxColumnTotalProg;
		private DataGridTextBoxColumn dataGridTextBoxColumnMoneyProg;
		private DataGridTextBoxColumn dataGridTextBoxColumnTax;
		private DataGridTextBoxColumn dataGridTextBoxColumnMoneyTax;
		private DataGridTextBoxColumn dataGridTextBoxColumnMaster;
		private DataGridTextBoxColumn dataGridTextBoxColumnDoctor;
		private DataGridTextBoxColumn dataGridTextBoxColumnTotalHigh;
		private DataGridTextBoxColumn dataGridTextBoxColumnMoneyHigh;
		private DataGridTextBoxColumn dataGridTextBoxColumnForeign;
		private DataGridTextBoxColumn dataGridTextBoxColumnMoneyForeign;
		private DataGridTextBoxColumn dataGridTextBoxColumnTotalStudent;
		private DataGridTextBoxColumn dataGridTextBoxColumnTotalMoney;
		private DataGridTextBoxColumn dataGridTextBoxColumnSchool;
		private System.Data.DataTable tableSchool;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn33;
		private System.Data.DataColumn dataColumn34;
		private System.Data.DataColumn dataColumn35;
		private System.Data.SqlClient.SqlDataAdapter daSchool;
		private DataGrid gridSummary;
		private TabControl tabSummary;
		private TabPage pageSummary;
		private Panel panelSummaryHead;
		private TabPage pageTransfer;
		private DateTimePicker dateTransferDate;
		private TextBox textPay;
		private TextBox textSize;
		private TextBox textCredit;
		private TextBox textDebet;
		private TextBox textSortCode;
		private TextBox textDesc;
		private TextBox textSizeByLetter;
		private TextBox textReceiverBank;
		private TextBox textReceiver;
		private TextBox textPayBank;
		private TextBox textID;
		private System.Data.SqlClient.SqlCommand sqlSelectSummary;
		private System.Data.SqlClient.SqlCommand sqlSelectSchool;
		private System.Data.SqlClient.SqlDataAdapter daTransfer;
		private System.Data.SqlClient.SqlCommand sqlSelectTransfer;
		private TextBox textCurrency;
		private Label label27;
		private System.Data.DataColumn dataColumn36;
		private System.Data.SqlClient.SqlCommand sqlDeleteTransfer;
		private System.Data.SqlClient.SqlCommand sqlInsertTransfer;
		private System.Data.SqlClient.SqlCommand sqlUpdateTransfer;
		private System.Data.SqlClient.SqlCommand sqlDeleteSummary;
		private System.Data.SqlClient.SqlCommand sqlInsertSummary;
		private System.Data.SqlClient.SqlCommand sqlUpdateSummary;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.ComboBox comboSummarySchool;
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
			managerTransfer = this.BindingContext[tableTransfer];
			managerSummary = this.BindingContext[dataSet, "Summary"];
			managerTransfer.PositionChanged += new EventHandler(ManagerTransfer_PositionChanged);
			managerSummary.PositionChanged += new EventHandler(ManagerSummary_PositionChanged);
			textYear.Text = Convert.ToString(DateTime.Now.Year);
			tableSummary.Columns["date"].DefaultValue = DateTime.Now.Date;
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
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SummaryView));
			this.tabSummary = new System.Windows.Forms.TabControl();
			this.pageSummary = new System.Windows.Forms.TabPage();
			this.gridSummary = new System.Windows.Forms.DataGrid();
			this.dataSet = new System.Data.DataSet();
			this.tableSummary = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataColumn7 = new System.Data.DataColumn();
			this.dataColumn8 = new System.Data.DataColumn();
			this.dataColumn9 = new System.Data.DataColumn();
			this.dataColumn10 = new System.Data.DataColumn();
			this.dataColumn11 = new System.Data.DataColumn();
			this.dataColumn12 = new System.Data.DataColumn();
			this.dataColumn13 = new System.Data.DataColumn();
			this.dataColumn14 = new System.Data.DataColumn();
			this.dataColumn15 = new System.Data.DataColumn();
			this.dataColumn16 = new System.Data.DataColumn();
			this.dataColumn17 = new System.Data.DataColumn();
			this.dataColumn18 = new System.Data.DataColumn();
			this.dataColumn19 = new System.Data.DataColumn();
			this.dataColumn20 = new System.Data.DataColumn();
			this.dataColumn21 = new System.Data.DataColumn();
			this.dataColumn22 = new System.Data.DataColumn();
			this.dataColumn23 = new System.Data.DataColumn();
			this.dataColumn32 = new System.Data.DataColumn();
			this.tableTransfer = new System.Data.DataTable();
			this.dataColumn24 = new System.Data.DataColumn();
			this.dataColumn25 = new System.Data.DataColumn();
			this.dataColumn26 = new System.Data.DataColumn();
			this.dataColumn27 = new System.Data.DataColumn();
			this.dataColumn28 = new System.Data.DataColumn();
			this.dataColumn29 = new System.Data.DataColumn();
			this.dataColumn30 = new System.Data.DataColumn();
			this.dataColumn31 = new System.Data.DataColumn();
			this.dataColumn36 = new System.Data.DataColumn();
			this.tableSchool = new System.Data.DataTable();
			this.dataColumn6 = new System.Data.DataColumn();
			this.dataColumn33 = new System.Data.DataColumn();
			this.dataColumn34 = new System.Data.DataColumn();
			this.dataColumn35 = new System.Data.DataColumn();
			this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnSchool = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLoan = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHelp = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPrize = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTotalLoan = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMoneyTotal = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHerder = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPoor = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnThird = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTotalProg = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMoneyProg = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMoneyTax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMaster = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDoctor = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTotalHigh = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMoneyHigh = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnForeign = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMoneyForeign = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTotalStudent = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTotalMoney = new System.Windows.Forms.DataGridTextBoxColumn();
			this.comboSummarySchool = new System.Windows.Forms.ComboBox();
			this.panelSummaryHead = new System.Windows.Forms.Panel();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textEndMonth = new System.Windows.Forms.TextBox();
			this.textBeginMonth = new System.Windows.Forms.TextBox();
			this.textYear = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pageTransfer = new System.Windows.Forms.TabPage();
			this.label27 = new System.Windows.Forms.Label();
			this.textCurrency = new System.Windows.Forms.TextBox();
			this.dateTransferDate = new System.Windows.Forms.DateTimePicker();
			this.label26 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textSize = new System.Windows.Forms.TextBox();
			this.textCredit = new System.Windows.Forms.TextBox();
			this.textDebet = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textSortCode = new System.Windows.Forms.TextBox();
			this.textDesc = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textSizeByLetter = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textReceiverBank = new System.Windows.Forms.TextBox();
			this.textReceiver = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textPayBank = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textPay = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.con = new System.Data.SqlClient.SqlConnection();
			this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteSummary = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertSummary = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectSummary = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateSummary = new System.Data.SqlClient.SqlCommand();
			this.daSchool = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectSchool = new System.Data.SqlClient.SqlCommand();
			this.daTransfer = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteTransfer = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertTransfer = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectTransfer = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateTransfer = new System.Data.SqlClient.SqlCommand();
			this.tabSummary.SuspendLayout();
			this.pageSummary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
			this.gridSummary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableSummary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableTransfer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableSchool)).BeginInit();
			this.panelSummaryHead.SuspendLayout();
			this.pageTransfer.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabSummary
			// 
			this.tabSummary.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.pageSummary,
																					 this.pageTransfer});
			this.tabSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabSummary.Name = "tabSummary";
			this.tabSummary.SelectedIndex = 0;
			this.tabSummary.Size = new System.Drawing.Size(624, 413);
			this.tabSummary.TabIndex = 0;
			// 
			// pageSummary
			// 
			this.pageSummary.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.gridSummary,
																					  this.panelSummaryHead});
			this.pageSummary.Location = new System.Drawing.Point(4, 22);
			this.pageSummary.Name = "pageSummary";
			this.pageSummary.Size = new System.Drawing.Size(616, 387);
			this.pageSummary.TabIndex = 0;
			this.pageSummary.Text = "Суралцагчдийн судалгаа";
			// 
			// gridSummary
			// 
			this.gridSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridSummary.CaptionVisible = false;
			this.gridSummary.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.comboSummarySchool});
			this.gridSummary.DataMember = "Summary";
			this.gridSummary.DataSource = this.dataSet;
			this.gridSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSummary.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridSummary.Location = new System.Drawing.Point(0, 40);
			this.gridSummary.Name = "gridSummary";
			this.gridSummary.Size = new System.Drawing.Size(616, 347);
			this.gridSummary.TabIndex = 0;
			this.gridSummary.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyle});
			this.gridSummary.CurrentCellChanged += new System.EventHandler(this.gridSummary_CurrentCellChanged);
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "NewDataSet";
			this.dataSet.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
																		 this.tableSummary,
																		 this.tableTransfer,
																		 this.tableSchool});
			// 
			// tableSummary
			// 
			this.tableSummary.Columns.AddRange(new System.Data.DataColumn[] {
																				this.dataColumn1,
																				this.dataColumn2,
																				this.dataColumn3,
																				this.dataColumn4,
																				this.dataColumn5,
																				this.dataColumn7,
																				this.dataColumn8,
																				this.dataColumn9,
																				this.dataColumn10,
																				this.dataColumn11,
																				this.dataColumn12,
																				this.dataColumn13,
																				this.dataColumn14,
																				this.dataColumn15,
																				this.dataColumn16,
																				this.dataColumn17,
																				this.dataColumn18,
																				this.dataColumn19,
																				this.dataColumn20,
																				this.dataColumn21,
																				this.dataColumn22,
																				this.dataColumn23,
																				this.dataColumn32});
			this.tableSummary.Constraints.AddRange(new System.Data.Constraint[] {
																					new System.Data.UniqueConstraint("Constraint1", new string[] {
																																					 "sid",
																																					 "date"}, true)});
			this.tableSummary.PrimaryKey = new System.Data.DataColumn[] {
																			this.dataColumn1,
																			this.dataColumn32};
			this.tableSummary.TableName = "Summary";
			// 
			// dataColumn1
			// 
			this.dataColumn1.AllowDBNull = false;
			this.dataColumn1.ColumnName = "sid";
			this.dataColumn1.DataType = typeof(int);
			// 
			// dataColumn2
			// 
			this.dataColumn2.ColumnName = "sname";
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "loan";
			this.dataColumn3.DataType = typeof(int);
			// 
			// dataColumn4
			// 
			this.dataColumn4.ColumnName = "help";
			this.dataColumn4.DataType = typeof(int);
			// 
			// dataColumn5
			// 
			this.dataColumn5.ColumnName = "prize";
			this.dataColumn5.DataType = typeof(int);
			// 
			// dataColumn7
			// 
			this.dataColumn7.ColumnName = "total_loan";
			this.dataColumn7.DataType = typeof(int);
			this.dataColumn7.Expression = "loan+help+prize";
			this.dataColumn7.ReadOnly = true;
			// 
			// dataColumn8
			// 
			this.dataColumn8.ColumnName = "money_loan";
			this.dataColumn8.DataType = typeof(System.Double);
			// 
			// dataColumn9
			// 
			this.dataColumn9.ColumnName = "herder";
			this.dataColumn9.DataType = typeof(int);
			// 
			// dataColumn10
			// 
			this.dataColumn10.ColumnName = "poor";
			this.dataColumn10.DataType = typeof(int);
			// 
			// dataColumn11
			// 
			this.dataColumn11.ColumnName = "third";
			this.dataColumn11.DataType = typeof(int);
			// 
			// dataColumn12
			// 
			this.dataColumn12.ColumnName = "total_prog";
			this.dataColumn12.DataType = typeof(int);
			this.dataColumn12.Expression = "herder+poor+third";
			this.dataColumn12.ReadOnly = true;
			// 
			// dataColumn13
			// 
			this.dataColumn13.ColumnName = "money_prog";
			this.dataColumn13.DataType = typeof(System.Double);
			// 
			// dataColumn14
			// 
			this.dataColumn14.ColumnName = "tax";
			this.dataColumn14.DataType = typeof(int);
			// 
			// dataColumn15
			// 
			this.dataColumn15.ColumnName = "money_tax";
			this.dataColumn15.DataType = typeof(System.Double);
			// 
			// dataColumn16
			// 
			this.dataColumn16.ColumnName = "master";
			this.dataColumn16.DataType = typeof(int);
			// 
			// dataColumn17
			// 
			this.dataColumn17.ColumnName = "doctor";
			this.dataColumn17.DataType = typeof(int);
			// 
			// dataColumn18
			// 
			this.dataColumn18.ColumnName = "total_high";
			this.dataColumn18.DataType = typeof(int);
			this.dataColumn18.Expression = "master+doctor";
			this.dataColumn18.ReadOnly = true;
			// 
			// dataColumn19
			// 
			this.dataColumn19.ColumnName = "money_high";
			this.dataColumn19.DataType = typeof(System.Double);
			// 
			// dataColumn20
			// 
			this.dataColumn20.ColumnName = "foreign";
			this.dataColumn20.DataType = typeof(int);
			// 
			// dataColumn21
			// 
			this.dataColumn21.ColumnName = "money_foreign";
			this.dataColumn21.DataType = typeof(int);
			// 
			// dataColumn22
			// 
			this.dataColumn22.ColumnName = "total";
			this.dataColumn22.DataType = typeof(int);
			this.dataColumn22.Expression = "total_loan+total_prog+tax+total_high+foreign";
			this.dataColumn22.ReadOnly = true;
			// 
			// dataColumn23
			// 
			this.dataColumn23.ColumnName = "money_total";
			this.dataColumn23.DataType = typeof(System.Double);
			this.dataColumn23.Expression = "money_loan+money_prog+money_tax+money_high+money_foreign";
			this.dataColumn23.ReadOnly = true;
			// 
			// dataColumn32
			// 
			this.dataColumn32.AllowDBNull = false;
			this.dataColumn32.ColumnName = "date";
			// 
			// tableTransfer
			// 
			this.tableTransfer.Columns.AddRange(new System.Data.DataColumn[] {
																				 this.dataColumn24,
																				 this.dataColumn25,
																				 this.dataColumn26,
																				 this.dataColumn27,
																				 this.dataColumn28,
																				 this.dataColumn29,
																				 this.dataColumn30,
																				 this.dataColumn31,
																				 this.dataColumn36});
			this.tableTransfer.TableName = "Transfer";
			// 
			// dataColumn24
			// 
			this.dataColumn24.ColumnName = "id";
			this.dataColumn24.DataType = typeof(int);
			// 
			// dataColumn25
			// 
			this.dataColumn25.ColumnName = "date";
			this.dataColumn25.DataType = typeof(System.DateTime);
			// 
			// dataColumn26
			// 
			this.dataColumn26.ColumnName = "size";
			this.dataColumn26.DataType = typeof(System.Double);
			// 
			// dataColumn27
			// 
			this.dataColumn27.ColumnName = "sid";
			this.dataColumn27.DataType = typeof(int);
			// 
			// dataColumn28
			// 
			this.dataColumn28.ColumnName = "stid";
			this.dataColumn28.DataType = typeof(int);
			// 
			// dataColumn29
			// 
			this.dataColumn29.ColumnName = "ptype";
			this.dataColumn29.DataType = typeof(System.Byte);
			// 
			// dataColumn30
			// 
			this.dataColumn30.ColumnName = "type";
			this.dataColumn30.DataType = typeof(System.Byte);
			// 
			// dataColumn31
			// 
			this.dataColumn31.ColumnName = "desc";
			// 
			// dataColumn36
			// 
			this.dataColumn36.ColumnName = "currency";
			this.dataColumn36.MaxLength = 10;
			// 
			// tableSchool
			// 
			this.tableSchool.Columns.AddRange(new System.Data.DataColumn[] {
																			   this.dataColumn6,
																			   this.dataColumn33,
																			   this.dataColumn34,
																			   this.dataColumn35});
			this.tableSchool.TableName = "School";
			// 
			// dataColumn6
			// 
			this.dataColumn6.ColumnName = "id";
			this.dataColumn6.DataType = typeof(int);
			// 
			// dataColumn33
			// 
			this.dataColumn33.ColumnName = "name";
			// 
			// dataColumn34
			// 
			this.dataColumn34.ColumnName = "bank";
			this.dataColumn34.MaxLength = 20;
			// 
			// dataColumn35
			// 
			this.dataColumn35.ColumnName = "account";
			this.dataColumn35.MaxLength = 10;
			// 
			// dataGridTableStyle
			// 
			this.dataGridTableStyle.DataGrid = this.gridSummary;
			this.dataGridTableStyle.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												 this.dataGridTextBoxColumnSchool,
																												 this.dataGridTextBoxColumnLoan,
																												 this.dataGridTextBoxColumnHelp,
																												 this.dataGridTextBoxColumnPrize,
																												 this.dataGridTextBoxColumnTotalLoan,
																												 this.dataGridTextBoxColumnMoneyTotal,
																												 this.dataGridTextBoxColumnHerder,
																												 this.dataGridTextBoxColumnPoor,
																												 this.dataGridTextBoxColumnThird,
																												 this.dataGridTextBoxColumnTotalProg,
																												 this.dataGridTextBoxColumnMoneyProg,
																												 this.dataGridTextBoxColumnTax,
																												 this.dataGridTextBoxColumnMoneyTax,
																												 this.dataGridTextBoxColumnMaster,
																												 this.dataGridTextBoxColumnDoctor,
																												 this.dataGridTextBoxColumnTotalHigh,
																												 this.dataGridTextBoxColumnMoneyHigh,
																												 this.dataGridTextBoxColumnForeign,
																												 this.dataGridTextBoxColumnMoneyForeign,
																												 this.dataGridTextBoxColumnTotalStudent,
																												 this.dataGridTextBoxColumnTotalMoney});
			this.dataGridTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle.MappingName = "Summary";
			// 
			// dataGridTextBoxColumnSchool
			// 
			this.dataGridTextBoxColumnSchool.Format = "";
			this.dataGridTextBoxColumnSchool.FormatInfo = null;
			this.dataGridTextBoxColumnSchool.HeaderText = "Сургууль";
			this.dataGridTextBoxColumnSchool.MappingName = "sname";
			this.dataGridTextBoxColumnSchool.Width = 150;
			// 
			// dataGridTextBoxColumnLoan
			// 
			this.dataGridTextBoxColumnLoan.Format = "";
			this.dataGridTextBoxColumnLoan.FormatInfo = null;
			this.dataGridTextBoxColumnLoan.HeaderText = "Зээл";
			this.dataGridTextBoxColumnLoan.MappingName = "loan";
			this.dataGridTextBoxColumnLoan.Width = 40;
			// 
			// dataGridTextBoxColumnHelp
			// 
			this.dataGridTextBoxColumnHelp.Format = "";
			this.dataGridTextBoxColumnHelp.FormatInfo = null;
			this.dataGridTextBoxColumnHelp.HeaderText = "Буцалтгvй";
			this.dataGridTextBoxColumnHelp.MappingName = "help";
			this.dataGridTextBoxColumnHelp.Width = 40;
			// 
			// dataGridTextBoxColumnPrize
			// 
			this.dataGridTextBoxColumnPrize.Format = "";
			this.dataGridTextBoxColumnPrize.FormatInfo = null;
			this.dataGridTextBoxColumnPrize.HeaderText = "Шагнал";
			this.dataGridTextBoxColumnPrize.MappingName = "prize";
			this.dataGridTextBoxColumnPrize.Width = 40;
			// 
			// dataGridTextBoxColumnTotalLoan
			// 
			this.dataGridTextBoxColumnTotalLoan.Format = "";
			this.dataGridTextBoxColumnTotalLoan.FormatInfo = null;
			this.dataGridTextBoxColumnTotalLoan.HeaderText = "Бvгд";
			this.dataGridTextBoxColumnTotalLoan.MappingName = "total_loan";
			this.dataGridTextBoxColumnTotalLoan.ReadOnly = true;
			this.dataGridTextBoxColumnTotalLoan.Width = 40;
			// 
			// dataGridTextBoxColumnMoneyTotal
			// 
			this.dataGridTextBoxColumnMoneyTotal.Format = "";
			this.dataGridTextBoxColumnMoneyTotal.FormatInfo = null;
			this.dataGridTextBoxColumnMoneyTotal.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnMoneyTotal.MappingName = "money_loan";
			this.dataGridTextBoxColumnMoneyTotal.Width = 60;
			// 
			// dataGridTextBoxColumnHerder
			// 
			this.dataGridTextBoxColumnHerder.Format = "";
			this.dataGridTextBoxColumnHerder.FormatInfo = null;
			this.dataGridTextBoxColumnHerder.HeaderText = "Малчин";
			this.dataGridTextBoxColumnHerder.MappingName = "herder";
			this.dataGridTextBoxColumnHerder.Width = 40;
			// 
			// dataGridTextBoxColumnPoor
			// 
			this.dataGridTextBoxColumnPoor.Format = "";
			this.dataGridTextBoxColumnPoor.FormatInfo = null;
			this.dataGridTextBoxColumnPoor.HeaderText = "Нэн ядуу";
			this.dataGridTextBoxColumnPoor.MappingName = "poor";
			this.dataGridTextBoxColumnPoor.Width = 40;
			// 
			// dataGridTextBoxColumnThird
			// 
			this.dataGridTextBoxColumnThird.Format = "";
			this.dataGridTextBoxColumnThird.FormatInfo = null;
			this.dataGridTextBoxColumnThird.HeaderText = "3-дагч";
			this.dataGridTextBoxColumnThird.MappingName = "third";
			this.dataGridTextBoxColumnThird.Width = 40;
			// 
			// dataGridTextBoxColumnTotalProg
			// 
			this.dataGridTextBoxColumnTotalProg.Format = "";
			this.dataGridTextBoxColumnTotalProg.FormatInfo = null;
			this.dataGridTextBoxColumnTotalProg.HeaderText = "Бvгд";
			this.dataGridTextBoxColumnTotalProg.MappingName = "total_prog";
			this.dataGridTextBoxColumnTotalProg.ReadOnly = true;
			this.dataGridTextBoxColumnTotalProg.Width = 40;
			// 
			// dataGridTextBoxColumnMoneyProg
			// 
			this.dataGridTextBoxColumnMoneyProg.Format = "";
			this.dataGridTextBoxColumnMoneyProg.FormatInfo = null;
			this.dataGridTextBoxColumnMoneyProg.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnMoneyProg.MappingName = "money_prog";
			this.dataGridTextBoxColumnMoneyProg.Width = 60;
			// 
			// dataGridTextBoxColumnTax
			// 
			this.dataGridTextBoxColumnTax.Format = "";
			this.dataGridTextBoxColumnTax.FormatInfo = null;
			this.dataGridTextBoxColumnTax.HeaderText = "ТАХ";
			this.dataGridTextBoxColumnTax.MappingName = "tax";
			this.dataGridTextBoxColumnTax.Width = 40;
			// 
			// dataGridTextBoxColumnMoneyTax
			// 
			this.dataGridTextBoxColumnMoneyTax.Format = "";
			this.dataGridTextBoxColumnMoneyTax.FormatInfo = null;
			this.dataGridTextBoxColumnMoneyTax.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnMoneyTax.MappingName = "money_tax";
			this.dataGridTextBoxColumnMoneyTax.Width = 60;
			// 
			// dataGridTextBoxColumnMaster
			// 
			this.dataGridTextBoxColumnMaster.Format = "";
			this.dataGridTextBoxColumnMaster.FormatInfo = null;
			this.dataGridTextBoxColumnMaster.HeaderText = "Магистр";
			this.dataGridTextBoxColumnMaster.MappingName = "master";
			this.dataGridTextBoxColumnMaster.Width = 40;
			// 
			// dataGridTextBoxColumnDoctor
			// 
			this.dataGridTextBoxColumnDoctor.Format = "";
			this.dataGridTextBoxColumnDoctor.FormatInfo = null;
			this.dataGridTextBoxColumnDoctor.HeaderText = "Доктор";
			this.dataGridTextBoxColumnDoctor.MappingName = "doctor";
			this.dataGridTextBoxColumnDoctor.Width = 40;
			// 
			// dataGridTextBoxColumnTotalHigh
			// 
			this.dataGridTextBoxColumnTotalHigh.Format = "";
			this.dataGridTextBoxColumnTotalHigh.FormatInfo = null;
			this.dataGridTextBoxColumnTotalHigh.HeaderText = "Бvгд";
			this.dataGridTextBoxColumnTotalHigh.MappingName = "total_high";
			this.dataGridTextBoxColumnTotalHigh.ReadOnly = true;
			this.dataGridTextBoxColumnTotalHigh.Width = 40;
			// 
			// dataGridTextBoxColumnMoneyHigh
			// 
			this.dataGridTextBoxColumnMoneyHigh.Format = "";
			this.dataGridTextBoxColumnMoneyHigh.FormatInfo = null;
			this.dataGridTextBoxColumnMoneyHigh.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnMoneyHigh.MappingName = "money_high";
			this.dataGridTextBoxColumnMoneyHigh.Width = 60;
			// 
			// dataGridTextBoxColumnForeign
			// 
			this.dataGridTextBoxColumnForeign.Format = "";
			this.dataGridTextBoxColumnForeign.FormatInfo = null;
			this.dataGridTextBoxColumnForeign.HeaderText = "Гадаад (ЗГ Гэрээ)";
			this.dataGridTextBoxColumnForeign.MappingName = "foreign";
			this.dataGridTextBoxColumnForeign.Width = 40;
			// 
			// dataGridTextBoxColumnMoneyForeign
			// 
			this.dataGridTextBoxColumnMoneyForeign.Format = "";
			this.dataGridTextBoxColumnMoneyForeign.FormatInfo = null;
			this.dataGridTextBoxColumnMoneyForeign.HeaderText = "Төлбөр";
			this.dataGridTextBoxColumnMoneyForeign.MappingName = "money_foreign";
			this.dataGridTextBoxColumnMoneyForeign.Width = 60;
			// 
			// dataGridTextBoxColumnTotalStudent
			// 
			this.dataGridTextBoxColumnTotalStudent.Format = "";
			this.dataGridTextBoxColumnTotalStudent.FormatInfo = null;
			this.dataGridTextBoxColumnTotalStudent.HeaderText = "Оюутны тоо";
			this.dataGridTextBoxColumnTotalStudent.MappingName = "total";
			this.dataGridTextBoxColumnTotalStudent.ReadOnly = true;
			this.dataGridTextBoxColumnTotalStudent.Width = 40;
			// 
			// dataGridTextBoxColumnTotalMoney
			// 
			this.dataGridTextBoxColumnTotalMoney.Format = "";
			this.dataGridTextBoxColumnTotalMoney.FormatInfo = null;
			this.dataGridTextBoxColumnTotalMoney.HeaderText = "Дvн";
			this.dataGridTextBoxColumnTotalMoney.MappingName = "money_total";
			this.dataGridTextBoxColumnTotalMoney.ReadOnly = true;
			this.dataGridTextBoxColumnTotalMoney.Width = 60;
			// 
			// comboSummarySchool
			// 
			this.comboSummarySchool.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet, "Summary.sid"));
			this.comboSummarySchool.DataSource = this.dataSet;
			this.comboSummarySchool.DisplayMember = "School.name";
			this.comboSummarySchool.Name = "comboSummarySchool";
			this.comboSummarySchool.Size = new System.Drawing.Size(144, 21);
			this.comboSummarySchool.TabIndex = 3;
			this.comboSummarySchool.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
			this.comboSummarySchool.ValueMember = "School.id";
			this.comboSummarySchool.Visible = false;
			// 
			// panelSummaryHead
			// 
			this.panelSummaryHead.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.buttonRefresh,
																						   this.label3,
																						   this.label2,
																						   this.textEndMonth,
																						   this.textBeginMonth,
																						   this.textYear,
																						   this.label1});
			this.panelSummaryHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSummaryHead.Name = "panelSummaryHead";
			this.panelSummaryHead.Size = new System.Drawing.Size(616, 40);
			this.panelSummaryHead.TabIndex = 1;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(328, 8);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.TabIndex = 6;
			this.buttonRefresh.Text = "&дуудах";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(166, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "--";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(235, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "сарын тооцоо";
			// 
			// textEndMonth
			// 
			this.textEndMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textEndMonth.Location = new System.Drawing.Point(184, 8);
			this.textEndMonth.Name = "textEndMonth";
			this.textEndMonth.Size = new System.Drawing.Size(40, 20);
			this.textEndMonth.TabIndex = 3;
			this.textEndMonth.Text = "";
			// 
			// textBeginMonth
			// 
			this.textBeginMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBeginMonth.Location = new System.Drawing.Point(120, 8);
			this.textBeginMonth.Name = "textBeginMonth";
			this.textBeginMonth.Size = new System.Drawing.Size(40, 20);
			this.textBeginMonth.TabIndex = 2;
			this.textBeginMonth.Text = "";
			// 
			// textYear
			// 
			this.textYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textYear.Location = new System.Drawing.Point(16, 8);
			this.textYear.Name = "textYear";
			this.textYear.Size = new System.Drawing.Size(64, 20);
			this.textYear.TabIndex = 1;
			this.textYear.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "он";
			// 
			// pageTransfer
			// 
			this.pageTransfer.BackColor = System.Drawing.SystemColors.Control;
			this.pageTransfer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pageTransfer.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.label27,
																					   this.textCurrency,
																					   this.dateTransferDate,
																					   this.label26,
																					   this.label24,
																					   this.label25,
																					   this.label23,
																					   this.label22,
																					   this.textBox12,
																					   this.textSize,
																					   this.textCredit,
																					   this.textDebet,
																					   this.label21,
																					   this.label20,
																					   this.label19,
																					   this.label18,
																					   this.label16,
																					   this.label17,
																					   this.label15,
																					   this.label14,
																					   this.label13,
																					   this.textSortCode,
																					   this.textDesc,
																					   this.label12,
																					   this.textSizeByLetter,
																					   this.label11,
																					   this.textReceiverBank,
																					   this.textReceiver,
																					   this.label10,
																					   this.label9,
																					   this.label8,
																					   this.textPayBank,
																					   this.label7,
																					   this.label6,
																					   this.label5,
																					   this.textPay,
																					   this.textID,
																					   this.label4});
			this.pageTransfer.Location = new System.Drawing.Point(4, 22);
			this.pageTransfer.Name = "pageTransfer";
			this.pageTransfer.Size = new System.Drawing.Size(616, 387);
			this.pageTransfer.TabIndex = 1;
			this.pageTransfer.Text = "Төлбөрийн даалгавар";
			// 
			// label27
			// 
			this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label27.Location = new System.Drawing.Point(335, 254);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(137, 19);
			this.label27.TabIndex = 38;
			this.label27.Text = "Валют:";
			// 
			// textCurrency
			// 
			this.textCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableTransfer, "currency"));
			this.textCurrency.Location = new System.Drawing.Point(335, 272);
			this.textCurrency.Name = "textCurrency";
			this.textCurrency.Size = new System.Drawing.Size(137, 20);
			this.textCurrency.TabIndex = 37;
			this.textCurrency.Text = "";
			// 
			// dateTransferDate
			// 
			this.dateTransferDate.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
			this.dateTransferDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableTransfer, "date"));
			this.dateTransferDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTransferDate.Location = new System.Drawing.Point(136, 32);
			this.dateTransferDate.Name = "dateTransferDate";
			this.dateTransferDate.TabIndex = 36;
			// 
			// label26
			// 
			this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label26.Location = new System.Drawing.Point(471, 283);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(121, 20);
			this.label26.TabIndex = 35;
			this.label26.Text = "төлбөрийн ээлж";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label24.Location = new System.Drawing.Point(471, 302);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(121, 20);
			this.label24.TabIndex = 34;
			this.label24.Text = "төлөх хугацаа";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label25
			// 
			this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label25.Location = new System.Drawing.Point(471, 321);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(121, 20);
			this.label25.TabIndex = 33;
			this.label25.Text = "төлбөрийн зориулалт";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label23.Location = new System.Drawing.Point(471, 264);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(121, 20);
			this.label23.TabIndex = 32;
			this.label23.Text = "гvйлгээний утга";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label22.Location = new System.Drawing.Point(471, 245);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(121, 20);
			this.label22.TabIndex = 31;
			this.label22.Text = "дvн торгуулийн хамт";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox12
			// 
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Location = new System.Drawing.Point(471, 179);
			this.textBox12.Multiline = true;
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(121, 68);
			this.textBox12.TabIndex = 30;
			this.textBox12.Text = "хоногийн\r\n\r\nхувийн торгууль\r\n... төг ... мөн";
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textSize
			// 
			this.textSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableTransfer, "size"));
			this.textSize.Location = new System.Drawing.Point(471, 66);
			this.textSize.MaxLength = 10;
			this.textSize.Multiline = true;
			this.textSize.Name = "textSize";
			this.textSize.Size = new System.Drawing.Size(121, 114);
			this.textSize.TabIndex = 29;
			this.textSize.Text = "";
			this.textSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textSize.TextChanged += new System.EventHandler(this.textSize_TextChanged);
			// 
			// textCredit
			// 
			this.textCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCredit.Location = new System.Drawing.Point(404, 160);
			this.textCredit.Name = "textCredit";
			this.textCredit.Size = new System.Drawing.Size(68, 20);
			this.textCredit.TabIndex = 28;
			this.textCredit.Text = "";
			// 
			// textDebet
			// 
			this.textDebet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDebet.Location = new System.Drawing.Point(404, 85);
			this.textDebet.Name = "textDebet";
			this.textDebet.Size = new System.Drawing.Size(68, 20);
			this.textDebet.TabIndex = 27;
			this.textDebet.Text = "3332407";
			this.textDebet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label21
			// 
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label21.Location = new System.Drawing.Point(404, 142);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(68, 20);
			this.label21.TabIndex = 26;
			this.label21.Text = "кредит";
			// 
			// label20
			// 
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label20.Location = new System.Drawing.Point(404, 123);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 20);
			this.label20.TabIndex = 25;
			// 
			// label19
			// 
			this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label19.Location = new System.Drawing.Point(404, 104);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(68, 20);
			this.label19.TabIndex = 24;
			// 
			// label18
			// 
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label18.Location = new System.Drawing.Point(404, 66);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 20);
			this.label18.TabIndex = 23;
			this.label18.Text = "дебет";
			// 
			// label16
			// 
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label16.Location = new System.Drawing.Point(373, 160);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 20);
			this.label16.TabIndex = 22;
			this.label16.Text = "код";
			// 
			// label17
			// 
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label17.Location = new System.Drawing.Point(334, 160);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(40, 20);
			this.label17.TabIndex = 21;
			this.label17.Text = "банк";
			// 
			// label15
			// 
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label15.Location = new System.Drawing.Point(373, 85);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 20);
			this.label15.TabIndex = 20;
			this.label15.Text = "код";
			// 
			// label14
			// 
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Location = new System.Drawing.Point(334, 85);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 20);
			this.label14.TabIndex = 19;
			this.label14.Text = "банк";
			// 
			// label13
			// 
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Location = new System.Drawing.Point(103, 207);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(89, 20);
			this.label13.TabIndex = 18;
			this.label13.Text = "Sort Code:";
			// 
			// textSortCode
			// 
			this.textSortCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSortCode.Location = new System.Drawing.Point(190, 207);
			this.textSortCode.Name = "textSortCode";
			this.textSortCode.Size = new System.Drawing.Size(145, 20);
			this.textSortCode.TabIndex = 17;
			this.textSortCode.Text = "";
			// 
			// textDesc
			// 
			this.textDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableTransfer, "desc"));
			this.textDesc.Location = new System.Drawing.Point(104, 309);
			this.textDesc.Multiline = true;
			this.textDesc.Name = "textDesc";
			this.textDesc.Size = new System.Drawing.Size(232, 48);
			this.textDesc.TabIndex = 16;
			this.textDesc.Text = "";
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Location = new System.Drawing.Point(8, 291);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(184, 19);
			this.label12.TabIndex = 15;
			this.label12.Text = "Төлбөрийн зориулалт:";
			// 
			// textSizeByLetter
			// 
			this.textSizeByLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSizeByLetter.Location = new System.Drawing.Point(104, 244);
			this.textSizeByLetter.Multiline = true;
			this.textSizeByLetter.Name = "textSizeByLetter";
			this.textSizeByLetter.ReadOnly = true;
			this.textSizeByLetter.Size = new System.Drawing.Size(232, 48);
			this.textSizeByLetter.TabIndex = 14;
			this.textSizeByLetter.Text = "";
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Location = new System.Drawing.Point(8, 226);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(184, 19);
			this.label11.TabIndex = 13;
			this.label11.Text = "Мөнгөний дvн vсгээр:";
			// 
			// textReceiverBank
			// 
			this.textReceiverBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textReceiverBank.Location = new System.Drawing.Point(103, 160);
			this.textReceiverBank.Multiline = true;
			this.textReceiverBank.Name = "textReceiverBank";
			this.textReceiverBank.Size = new System.Drawing.Size(232, 48);
			this.textReceiverBank.TabIndex = 12;
			this.textReceiverBank.Text = "";
			// 
			// textReceiver
			// 
			this.textReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textReceiver.Location = new System.Drawing.Point(103, 123);
			this.textReceiver.Name = "textReceiver";
			this.textReceiver.Size = new System.Drawing.Size(232, 20);
			this.textReceiver.TabIndex = 11;
			this.textReceiver.Text = "";
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Location = new System.Drawing.Point(8, 160);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 20);
			this.label10.TabIndex = 10;
			this.label10.Text = "Хvлээн авагчийн";
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Location = new System.Drawing.Point(8, 142);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "код";
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(8, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 20);
			this.label8.TabIndex = 8;
			this.label8.Text = "Хvлээн авагч";
			// 
			// textPayBank
			// 
			this.textPayBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPayBank.Location = new System.Drawing.Point(103, 104);
			this.textPayBank.Name = "textPayBank";
			this.textPayBank.ReadOnly = true;
			this.textPayBank.Size = new System.Drawing.Size(232, 20);
			this.textPayBank.TabIndex = 7;
			this.textPayBank.Text = "МОНГОЛ БАНК";
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(8, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Төлөгчийн";
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(8, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "код";
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(8, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Төлөгч";
			// 
			// textPay
			// 
			this.textPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPay.Location = new System.Drawing.Point(103, 85);
			this.textPay.Name = "textPay";
			this.textPay.ReadOnly = true;
			this.textPay.Size = new System.Drawing.Size(232, 20);
			this.textPay.TabIndex = 3;
			this.textPay.Text = "СУРГАЛТЫН ТӨРИЙН САН";
			// 
			// textID
			// 
			this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableTransfer, "id"));
			this.textID.Location = new System.Drawing.Point(296, 8);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(40, 20);
			this.textID.TabIndex = 1;
			this.textID.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(136, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "ТӨЛБӨРИЙН ДААЛГАВАР";
			// 
			// con
			// 
			this.con.ConnectionString = "data source=onolt;initial catalog=STraF;password=joker;persist security info=True" +
				";user id=sa;workstation id=ONOLT;packet size=4096";
			// 
			// daSummary
			// 
			this.daSummary.DeleteCommand = this.sqlDeleteSummary;
			this.daSummary.InsertCommand = this.sqlInsertSummary;
			this.daSummary.SelectCommand = this.sqlSelectSummary;
			this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								new System.Data.Common.DataTableMapping("Table", "Summary", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("sid", "sid"),
																																																		   new System.Data.Common.DataColumnMapping("name", "name"),
																																																		   new System.Data.Common.DataColumnMapping("date", "date"),
																																																		   new System.Data.Common.DataColumnMapping("loan", "loan"),
																																																		   new System.Data.Common.DataColumnMapping("help", "help"),
																																																		   new System.Data.Common.DataColumnMapping("prize", "prize"),
																																																		   new System.Data.Common.DataColumnMapping("money_loan", "money_loan"),
																																																		   new System.Data.Common.DataColumnMapping("herder", "herder"),
																																																		   new System.Data.Common.DataColumnMapping("poor", "poor"),
																																																		   new System.Data.Common.DataColumnMapping("third", "third"),
																																																		   new System.Data.Common.DataColumnMapping("money_prog", "money_prog"),
																																																		   new System.Data.Common.DataColumnMapping("tax", "tax"),
																																																		   new System.Data.Common.DataColumnMapping("money_tax", "money_tax"),
																																																		   new System.Data.Common.DataColumnMapping("master", "master"),
																																																		   new System.Data.Common.DataColumnMapping("doctor", "doctor"),
																																																		   new System.Data.Common.DataColumnMapping("money_high", "money_high"),
																																																		   new System.Data.Common.DataColumnMapping("foreign", "foreign"),
																																																		   new System.Data.Common.DataColumnMapping("money_foreign", "money_foreign")})});
			this.daSummary.UpdateCommand = this.sqlUpdateSummary;
			// 
			// sqlDeleteSummary
			// 
			this.sqlDeleteSummary.CommandText = "[delete_summary]";
			this.sqlDeleteSummary.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteSummary.Connection = this.con;
			this.sqlDeleteSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "sid", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime, 8, "date"));
			// 
			// sqlInsertSummary
			// 
			this.sqlInsertSummary.CommandText = "[insert_summary]";
			this.sqlInsertSummary.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlInsertSummary.Connection = this.con;
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "sid", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime, 8, "date"));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@loan", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "loan", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@help", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "help", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@prize", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "prize", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_loan", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_loan", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@herder", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "herder", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@poor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "poor", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@third", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "third", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_prog", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_prog", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "tax", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_tax", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_tax", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@master", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "master", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@doctor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "doctor", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_high", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_high", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@foreign", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "foreign", System.Data.DataRowVersion.Current, null));
			this.sqlInsertSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_foreign", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_foreign", System.Data.DataRowVersion.Current, null));
			// 
			// sqlSelectSummary
			// 
			this.sqlSelectSummary.CommandText = "[select_summary]";
			this.sqlSelectSummary.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectSummary.Connection = this.con;
			this.sqlSelectSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@year", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@begin", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateSummary
			// 
			this.sqlUpdateSummary.CommandText = "[update_summary]";
			this.sqlUpdateSummary.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateSummary.Connection = this.con;
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "sid", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime, 8, "date"));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@loan", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "loan", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@help", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "help", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@prize", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "prize", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_loan", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_loan", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@herder", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "herder", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@poor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "poor", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@third", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "third", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_prog", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_prog", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "tax", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_tax", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_tax", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@master", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "master", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@doctor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "doctor", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_high", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_high", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@foreign", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "foreign", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateSummary.Parameters.Add(new System.Data.SqlClient.SqlParameter("@money_foreign", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "money_foreign", System.Data.DataRowVersion.Current, null));
			// 
			// daSchool
			// 
			this.daSchool.SelectCommand = this.sqlSelectSchool;
			this.daSchool.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							   new System.Data.Common.DataTableMapping("Table", "School", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("id", "id"),
																																																		 new System.Data.Common.DataColumnMapping("name", "name"),
																																																		 new System.Data.Common.DataColumnMapping("filial", "filial"),
																																																		 new System.Data.Common.DataColumnMapping("level", "level"),
																																																		 new System.Data.Common.DataColumnMapping("hold", "hold"),
																																																		 new System.Data.Common.DataColumnMapping("valid", "valid"),
																																																		 new System.Data.Common.DataColumnMapping("region", "region"),
																																																		 new System.Data.Common.DataColumnMapping("bank", "bank"),
																																																		 new System.Data.Common.DataColumnMapping("account", "account")})});
			// 
			// sqlSelectSchool
			// 
			this.sqlSelectSchool.CommandText = "SELECT id, name, bank, account FROM School";
			this.sqlSelectSchool.Connection = this.con;
			// 
			// daTransfer
			// 
			this.daTransfer.DeleteCommand = this.sqlDeleteTransfer;
			this.daTransfer.InsertCommand = this.sqlInsertTransfer;
			this.daTransfer.SelectCommand = this.sqlSelectTransfer;
			this.daTransfer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								 new System.Data.Common.DataTableMapping("Table", "Transfer", new System.Data.Common.DataColumnMapping[] {
																																																			 new System.Data.Common.DataColumnMapping("id", "id"),
																																																			 new System.Data.Common.DataColumnMapping("date", "date"),
																																																			 new System.Data.Common.DataColumnMapping("size", "size"),
																																																			 new System.Data.Common.DataColumnMapping("sid", "sid"),
																																																			 new System.Data.Common.DataColumnMapping("stid", "stid"),
																																																			 new System.Data.Common.DataColumnMapping("ptype", "ptype"),
																																																			 new System.Data.Common.DataColumnMapping("type", "type"),
																																																			 new System.Data.Common.DataColumnMapping("desc", "desc"),
																																																			 new System.Data.Common.DataColumnMapping("name", "name"),
																																																			 new System.Data.Common.DataColumnMapping("bank", "bank"),
																																																			 new System.Data.Common.DataColumnMapping("account", "account"),
																																																			 new System.Data.Common.DataColumnMapping("currency", "currency")})});
			this.daTransfer.UpdateCommand = this.sqlUpdateTransfer;
			// 
			// sqlDeleteTransfer
			// 
			this.sqlDeleteTransfer.CommandText = "[delete_transfer]";
			this.sqlDeleteTransfer.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteTransfer.Connection = this.con;
			this.sqlDeleteTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertTransfer
			// 
			this.sqlInsertTransfer.CommandText = "[insert_transfer]";
			this.sqlInsertTransfer.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlInsertTransfer.Connection = this.con;
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime, 8, "date"));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@size", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "size", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@currency", System.Data.SqlDbType.NVarChar, 10, "currency"));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "sid", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@stid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "stid", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ptype", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "ptype", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "type", System.Data.DataRowVersion.Current, null));
			this.sqlInsertTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@desc", System.Data.SqlDbType.NVarChar, 50, "desc"));
			// 
			// sqlSelectTransfer
			// 
			this.sqlSelectTransfer.CommandText = "SELECT id, date, size, sid, stid, ptype, type, [desc], name, bank, account, curre" +
				"ncy FROM View_Transfer";
			this.sqlSelectTransfer.Connection = this.con;
			// 
			// sqlUpdateTransfer
			// 
			this.sqlUpdateTransfer.CommandText = "[update_transfer]";
			this.sqlUpdateTransfer.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateTransfer.Connection = this.con;
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id_1", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id_2", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime, 8, "date"));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@size", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "size", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@currency", System.Data.SqlDbType.NVarChar, 10, "currency"));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "sid", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@stid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "stid", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ptype", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "ptype", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(3)), ((System.Byte)(0)), "type", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateTransfer.Parameters.Add(new System.Data.SqlClient.SqlParameter("@desc", System.Data.SqlDbType.NVarChar, 50, "desc"));
			// 
			// SummaryView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(624, 413);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabSummary});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SummaryView";
			this.Text = "Товчоо";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SummaryView_KeyDown);
			this.tabSummary.ResumeLayout(false);
			this.pageSummary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
			this.gridSummary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableSummary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableTransfer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableSchool)).EndInit();
			this.panelSummaryHead.ResumeLayout(false);
			this.pageTransfer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadData() {
			dataSet.EnforceConstraints = false;
			try {
				daSchool.Fill(tableSchool);
				daTransfer.Fill(tableTransfer);
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
			tableSummary.Clear();
			ushort year;
			byte begin, end;
			try {
				year = Convert.ToUInt16(textYear.Text);
				begin = Convert.ToByte(textBeginMonth.Text);
				end = Convert.ToByte(textEndMonth.Text);
			}
			catch (Exception) {
				return;
			}
			daSummary.SelectCommand.Parameters[1].Value = year;
			daSummary.SelectCommand.Parameters[2].Value = begin;
			daSummary.SelectCommand.Parameters[3].Value = end;
			try {
				daSummary.Fill(tableSummary);
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
			int row = gridSummary.CurrentRowIndex;
			int col = gridSummary.CurrentCell.ColumnNumber;
			string source, data;
			source = Convert.ToString(search);
			source = source.ToUpper();
			if (back)
				step = -1;
			row += step;
			while (row < tableSummary.Rows.Count && row >=0) {
				data = Convert.ToString(gridSummary[row, col]);
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
			if (row < tableSummary.Rows.Count && row >= 0) {
				gridSummary.CurrentRowIndex = row;
				gridSummary.Select(row);
			}
		}
		public void Replace(object search, object replace, bool regular, bool back) {
		}
		private void SummaryView_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.N: 
					New(); 
					break;

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
					if (tabSummary.SelectedIndex == 0)
						RefreshData(); 
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
		private void New() {
			if (tabSummary.SelectedIndex == 0) {
				managerSummary.AddNew();
			}
			else if (tabSummary.SelectedIndex == 1) {
				managerTransfer.AddNew();
			}
		}
		private void Save() {
			if (tabSummary.SelectedIndex == 0) {
				try {
					daSummary.Update(dataSet, "Summary");
				}
				catch (Exception ex) {
					if (MessageBox.Show(ex.ToString() + "\nVйлдлийг буцаах уу ?", Straf.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.OK) {
						tableSummary.RejectChanges();
					}
				}
			}
			else if (tabSummary.SelectedIndex == 1) {
				try {
					daTransfer.Update(tableTransfer);
				}
				catch (Exception ex) {
					if (MessageBox.Show(ex.ToString() + "\nVйлдлийг буцаах уу ?", Straf.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.OK) {
						tableTransfer.RejectChanges();
					}
				}
			}
		}
		private void Copy() {
			string strData = "";
			for (int i=0;i<tableSummary.Rows.Count;i++) {
				if (gridSummary.IsSelected(i)) {
					for (int j = 0; j < tableSummary.Columns.Count; j++) {
						strData += tableSummary.Rows[i].ItemArray.GetValue(j).ToString() + "\t";
					}
					strData += "\r\n";
				}
			}
			Clipboard.SetDataObject(strData);
		}
		private void Cut() {
			Copy();
			Win32.SendMessage(gridSummary.Handle, 0x0100 /*WM_KEYDOWN*/, (int) Keys.Delete, 1);
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
							DataRow row = tableSummary.NewRow();
							string[] words = line.Split(new Char[] {'\t'});
							int j = 0;
							while (j < tableSummary.Columns.Count - 1 && j < words.Length) {
								row[j + 1] = words[j];
								j++;
							}
							rows.Add(row);
						}
					}
					System.Collections.IEnumerator enumerator = rows.GetEnumerator();
					while ( enumerator.MoveNext() )
						tableSummary.Rows.Add((DataRow)enumerator.Current);
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
			if (tabSummary.SelectedIndex == 0) {
				tableSummary.RejectChanges();
			}
			else if (tabSummary.SelectedIndex == 1) {
				tableTransfer.RejectChanges();
			}
		}
		private void MoveFirst() {
			if (tabSummary.SelectedIndex == 0)
				managerSummary.Position = 0;
			else if (tabSummary.SelectedIndex == 1)
				managerTransfer.Position = 0;
		}
		private void MovePrev() {
			if (tabSummary.SelectedIndex == 0)
				managerSummary.Position -= 1;
			else if (tabSummary.SelectedIndex == 1)
				managerTransfer.Position -= 1;
		}
		private void MoveNext() {
			if (tabSummary.SelectedIndex == 0)
				managerSummary.Position += 1;
			else if (tabSummary.SelectedIndex == 1)
				managerTransfer.Position += 1;
		}
		private void MoveLast() {
			if (tabSummary.SelectedIndex == 0)
				managerSummary.Position = managerSummary.Count - 1;
			else if (tabSummary.SelectedIndex == 1)
				managerTransfer.Position = managerTransfer.Count - 1;
		}
		private void ManagerSummary_PositionChanged(object sender, EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				parent.statusRecord.Text = string.Format("{0}/{1}", managerSummary.Position + 1, managerSummary.Count);
			}
		}
		private void ManagerTransfer_PositionChanged(object sender, EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				parent.statusRecord.Text = string.Format("{0}/{1}", managerTransfer.Position + 1, managerTransfer.Count);
			}
		}
		private void textSize_TextChanged(object sender, System.EventArgs e) {
			if (textSize.Text == "") {
				textSizeByLetter.Text = "";
				return;
			}
			int c=1, d=1, r, rem;
			long b, m;
			double f = 0.0;
			string res="", t="";

			try {
				f = Convert.ToDouble(textSize.Text);
			}
			catch (Exception) {
				MessageBox.Show("Тоо буруу !");
				textSize.Text = "0";
			}
			m = (long)f;
			rem = (int)(((f - m) * 100) / 100);
			Straf parent = (Straf)this.MdiParent;
			parent.statusMain.Text = Convert.ToString(m) + "," + Convert.ToString(rem);
			if (m == 0) res = d0;
		
			while (m != 0) {
				b = m/1000; m %= 1000;
				if (m != 0) {
					switch (d) {
						case 2 : t = d4; t += " " + res; res = t; break;
						case 3 : t = d6; t += " " + res; res = t; break;
						case 4 : t = d7; t += " " + res; res = t; break;
					}
				}
				while (m != 0) {
					r = (int)m % 10;
					if (r != 0) {
						switch (c) {
							case 1 : if (r == 1 && (d == 1 || m / 10 == 0)) {
										 t =d1[r-1]; t+=" "+res; res=t;
									 }
									 else if (r!=0 && d!=1) {
										 t=d1_n[r-1]; t+=" "+res; res=t;
									 }
									 else if (r!=0) {
										 t=d1[r-1]; t+=" "+res; res=t;
									 }
								break;
							case 2 : if (r!=0 && res != "") {
										 t=d2_n[r-1]; t+=" "+res; res=t;
									 }
									 else if (r!=0 && res == "") {
										 res=d2[r-1];
									 }
								break;
							case 3 : if (r!=0) {
										 if (b==0) t=d1[r-1]; else t=d1_n[r-1];
										 if (res != "") t+=" "+d3_n; else t+=" "+d3;
										 t+=" "+res; res=t;
									 }
								break;
						}
					}
					c++; m/=10;
				}
				d++; c=1; m=b;
			}
			string ch = res[0] + "";
			textSizeByLetter.Text = ch.ToUpper() + res.Substring(1, res.Length - 1);
		}

		private void buttonRefresh_Click(object sender, System.EventArgs e) {
			RefreshData();
		}

		private void gridSummary_CurrentCellChanged(object sender, System.EventArgs e) {
			if (gridSummary.CurrentCell.ColumnNumber == 0) {
				Rectangle rect = gridSummary.GetCurrentCellBounds();
				comboSummarySchool.SetBounds(rect.X, rect.Y, rect.Width, rect.Height);
				try {
					comboSummarySchool.Text = (string)gridSummary[gridSummary.CurrentCell];
				}
				catch (Exception) {}
				comboSummarySchool.Show();
			}
			else {
				comboSummarySchool.Hide();
			}
		}

		private void comboSummarySchool_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (comboSummarySchool.SelectedIndex != -1) {
				gridSummary[gridSummary.CurrentCell] = comboSummarySchool.GetItemText(comboSummarySchool.SelectedIndex);
				tableSummary.Rows[gridSummary.CurrentRowIndex]["sname"] = comboSummarySchool.GetItemText(comboSummarySchool.SelectedIndex);
			}
		}
	}
}

