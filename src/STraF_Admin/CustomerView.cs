using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace STraF {
	/// <summary>
	/// Summary description for Customer.
	/// </summary>
	public class Customer : Form, IStrafChild {
		enum Levels { UNIVERSITY = 1, HIGH, COLLEGE, SPECIAL, OTHER	}
		public string[] descLevel = new string[] {"их сургууль", "дээд сургууль", "коллеж", "МСVТ", "бусад"};
		private int level;
		private bool hold;
		private bool valid;
		private bool foreign;
		private string sql;
		private string filter;
		private DataTable[] tables;
		private DataGrid[] grids;
		private MenuItem menuSchool;
		private MenuItem cmdTransfer;
		private MenuItem menuItem1;
		private MenuItem cmdShowFilter;
		private MainMenu menuMain;
		private System.Data.SqlClient.SqlConnection con;
		private System.Data.DataTable tableSchool;
		private System.Data.DataSet dataSet;
		private TabPage pageSchool;
		private Panel panelFilter;
		private CheckBox checkValid;
		private CheckBox checkHold;
		private CheckBox checkForeign;
		private ComboBox comboLevel;
		private Label labelLevel;
		private DataGrid gridSchool;
		private DataGridTableStyle dataGridTableStyleSchool;
		private Panel panelSchoolDetial;
		private TabPage pageRegion;
		private TabPage pageOrg;
		private TabControl tabCustomer;
		private DataGrid gridOrg;
		private System.Data.DataTable tableOrg;
		private DataGridTableStyle dataGridTableStyleOrg;
		private DataGridTextBoxColumn dataGridTextBoxColumnOrgName;
		private DataGridTextBoxColumn dataGridTextBoxColumnOrgPhone;
		private DataGridTextBoxColumn dataGridTextBoxColumnOrgAddress;
		private DataGridTextBoxColumn dataGridTextBoxColumnSchoolName;
		private DataGridBoolColumn dataGridBoolColumnSchoolHold;
		private DataGridBoolColumn dataGridBoolColumnSchoolValid;
		private System.Data.SqlClient.SqlDataAdapter daSchool;
		private System.Data.SqlClient.SqlDataAdapter daOrg;
		private System.Data.DataColumn dataColumnOrgID;
		private DataGrid gridRegion;
		private System.Data.DataTable tableRegion;
		private System.Data.DataColumn dataColumnRegionID;
		private System.Data.DataColumn dataColumnRegionName;
		private System.Data.DataColumn dataColumnRegionForeign;
		private DataGridTableStyle dataGridTableStyleRegion;
		private DataGridTextBoxColumn dataGridTextBoxColumnRegionName;
		private DataGridBoolColumn dataGridBoolColumnRegionForeign;
		private System.Data.SqlClient.SqlDataAdapter daRegion;
		private System.Data.DataColumn dataColumnOrgName;
		private System.Data.DataColumn dataColumnOrgPhone;
		private System.Data.DataColumn dataColumnOrgAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textSchoolBank;
		private System.Windows.Forms.TextBox textSchoolAccount;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlCommand sqlDeleteRegion;
		private System.Data.SqlClient.SqlCommand sqlInsertRegion;
		private System.Data.SqlClient.SqlCommand sqlSelectRegion;
		private System.Data.SqlClient.SqlCommand sqlUpdateRegion;
		private System.Data.SqlClient.SqlCommand sqlDeleteOrg;
		private System.Data.SqlClient.SqlCommand sqlInsertOrg;
		private System.Data.SqlClient.SqlCommand sqlSelectOrg;
		private System.Data.SqlClient.SqlCommand sqlUpdateOrg;
		private System.Data.DataColumn dataColumnSchoolID;
		private System.Data.DataColumn dataColumnSchoolName;
		private System.Data.DataColumn dataColumnSchoolFilial;
		private System.Data.DataColumn dataColumnSchoolLevel;
		private System.Data.DataColumn dataColumnSchoolHold;
		private System.Data.DataColumn dataColumnSchoolValid;
		private System.Data.DataColumn dataColumnSchoolRegion;
		private System.Data.DataColumn dataColumnSchoolBank;
		private System.Data.DataColumn dataColumnSchoolAccount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboSchoolLevel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboSchoolFilial;
		private System.Data.DataTable tableLevel;
		private System.Data.DataColumn dataColumnLevelID;
		private System.Data.DataColumn dataColumnLevelDesc;
		private System.Data.SqlClient.SqlCommand sqlSelectSchool;
		private System.Data.SqlClient.SqlCommand sqlDeleteSchool;
		private System.Data.SqlClient.SqlCommand sqlUpdateSchool;
		private System.Data.SqlClient.SqlCommand sqlInsertSchool;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Customer() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			level = 0;	// all
			hold = checkHold.Checked;
			valid = checkValid.Checked;
			foreign = checkForeign.Checked;
			sql = "select * from school";
			tables = new DataTable[] {tableSchool, tableRegion, tableOrg};
			grids = new DataGrid[] {gridSchool, gridRegion, gridOrg};
			gridSchool.Tag = 1;
			gridRegion.Tag = 2;
			gridOrg.Tag = 3;
			try {
				if (Straf.logged) {
					con.ConnectionString = Straf.strCon;
					con.Open();
					LoadData();
					RefreshSchool();
					RefreshRegion();
					RefreshOrg();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Customer));
			this.menuSchool = new System.Windows.Forms.MenuItem();
			this.cmdTransfer = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.cmdShowFilter = new System.Windows.Forms.MenuItem();
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.tableSchool = new System.Data.DataTable();
			this.dataColumnSchoolID = new System.Data.DataColumn();
			this.dataColumnSchoolName = new System.Data.DataColumn();
			this.dataColumnSchoolFilial = new System.Data.DataColumn();
			this.dataColumnSchoolLevel = new System.Data.DataColumn();
			this.dataColumnSchoolHold = new System.Data.DataColumn();
			this.dataColumnSchoolValid = new System.Data.DataColumn();
			this.dataColumnSchoolRegion = new System.Data.DataColumn();
			this.dataColumnSchoolBank = new System.Data.DataColumn();
			this.dataColumnSchoolAccount = new System.Data.DataColumn();
			this.dataSet = new System.Data.DataSet();
			this.tableOrg = new System.Data.DataTable();
			this.dataColumnOrgID = new System.Data.DataColumn();
			this.dataColumnOrgName = new System.Data.DataColumn();
			this.dataColumnOrgPhone = new System.Data.DataColumn();
			this.dataColumnOrgAddress = new System.Data.DataColumn();
			this.tableRegion = new System.Data.DataTable();
			this.dataColumnRegionID = new System.Data.DataColumn();
			this.dataColumnRegionName = new System.Data.DataColumn();
			this.dataColumnRegionForeign = new System.Data.DataColumn();
			this.tableLevel = new System.Data.DataTable();
			this.dataColumnLevelID = new System.Data.DataColumn();
			this.dataColumnLevelDesc = new System.Data.DataColumn();
			this.con = new System.Data.SqlClient.SqlConnection();
			this.daSchool = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteSchool = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertSchool = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectSchool = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateSchool = new System.Data.SqlClient.SqlCommand();
			this.tabCustomer = new System.Windows.Forms.TabControl();
			this.pageSchool = new System.Windows.Forms.TabPage();
			this.panelFilter = new System.Windows.Forms.Panel();
			this.checkValid = new System.Windows.Forms.CheckBox();
			this.checkHold = new System.Windows.Forms.CheckBox();
			this.checkForeign = new System.Windows.Forms.CheckBox();
			this.comboLevel = new System.Windows.Forms.ComboBox();
			this.labelLevel = new System.Windows.Forms.Label();
			this.gridSchool = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleSchool = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnSchoolName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridBoolColumnSchoolHold = new System.Windows.Forms.DataGridBoolColumn();
			this.dataGridBoolColumnSchoolValid = new System.Windows.Forms.DataGridBoolColumn();
			this.panelSchoolDetial = new System.Windows.Forms.Panel();
			this.comboSchoolFilial = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboSchoolLevel = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textSchoolAccount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textSchoolBank = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pageRegion = new System.Windows.Forms.TabPage();
			this.gridRegion = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleRegion = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnRegionName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridBoolColumnRegionForeign = new System.Windows.Forms.DataGridBoolColumn();
			this.pageOrg = new System.Windows.Forms.TabPage();
			this.gridOrg = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleOrg = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnOrgName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnOrgPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnOrgAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.daOrg = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteOrg = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertOrg = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectOrg = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateOrg = new System.Data.SqlClient.SqlCommand();
			this.daRegion = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteRegion = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertRegion = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectRegion = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateRegion = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.tableSchool)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableOrg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableLevel)).BeginInit();
			this.tabCustomer.SuspendLayout();
			this.pageSchool.SuspendLayout();
			this.panelFilter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSchool)).BeginInit();
			this.panelSchoolDetial.SuspendLayout();
			this.pageRegion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridRegion)).BeginInit();
			this.pageOrg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridOrg)).BeginInit();
			this.SuspendLayout();
			// 
			// menuSchool
			// 
			this.menuSchool.Index = 0;
			this.menuSchool.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.cmdTransfer,
																					   this.menuItem1,
																					   this.cmdShowFilter});
			this.menuSchool.MergeOrder = 3;
			this.menuSchool.Text = "&Харилцагч";
			// 
			// cmdTransfer
			// 
			this.cmdTransfer.Index = 0;
			this.cmdTransfer.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
			this.cmdTransfer.Text = "&Шилжvvлгэ...";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// cmdShowFilter
			// 
			this.cmdShowFilter.Index = 2;
			this.cmdShowFilter.Shortcut = System.Windows.Forms.Shortcut.F12;
			this.cmdShowFilter.Text = "Ялгах...";
			this.cmdShowFilter.Click += new System.EventHandler(this.cmdShowFilter_Click);
			// 
			// menuMain
			// 
			this.menuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuSchool});
			// 
			// tableSchool
			// 
			this.tableSchool.Columns.AddRange(new System.Data.DataColumn[] {
																			   this.dataColumnSchoolID,
																			   this.dataColumnSchoolName,
																			   this.dataColumnSchoolFilial,
																			   this.dataColumnSchoolLevel,
																			   this.dataColumnSchoolHold,
																			   this.dataColumnSchoolValid,
																			   this.dataColumnSchoolRegion,
																			   this.dataColumnSchoolBank,
																			   this.dataColumnSchoolAccount});
			this.tableSchool.Constraints.AddRange(new System.Data.Constraint[] {
																				   new System.Data.UniqueConstraint("ConstraintID", new string[] {
																																					 "id"}, false),
																				   new System.Data.ForeignKeyConstraint("LevelToSchool", "Level", new string[] {
																																								   "id"}, new string[] {
																																														   "level"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
			this.tableSchool.TableName = "School";
			// 
			// dataColumnSchoolID
			// 
			this.dataColumnSchoolID.AutoIncrement = true;
			this.dataColumnSchoolID.ColumnName = "id";
			this.dataColumnSchoolID.DataType = typeof(int);
			// 
			// dataColumnSchoolName
			// 
			this.dataColumnSchoolName.ColumnName = "name";
			this.dataColumnSchoolName.MaxLength = 30;
			// 
			// dataColumnSchoolFilial
			// 
			this.dataColumnSchoolFilial.ColumnName = "filial";
			this.dataColumnSchoolFilial.DataType = typeof(int);
			this.dataColumnSchoolFilial.DefaultValue = 0;
			// 
			// dataColumnSchoolLevel
			// 
			this.dataColumnSchoolLevel.ColumnName = "level";
			this.dataColumnSchoolLevel.DataType = typeof(System.Byte);
			this.dataColumnSchoolLevel.DefaultValue = ((System.Byte)(1));
			// 
			// dataColumnSchoolHold
			// 
			this.dataColumnSchoolHold.ColumnName = "hold";
			this.dataColumnSchoolHold.DataType = typeof(bool);
			this.dataColumnSchoolHold.DefaultValue = true;
			// 
			// dataColumnSchoolValid
			// 
			this.dataColumnSchoolValid.ColumnName = "valid";
			this.dataColumnSchoolValid.DataType = typeof(bool);
			this.dataColumnSchoolValid.DefaultValue = false;
			// 
			// dataColumnSchoolRegion
			// 
			this.dataColumnSchoolRegion.ColumnName = "region";
			this.dataColumnSchoolRegion.DataType = typeof(int);
			this.dataColumnSchoolRegion.DefaultValue = 20;
			// 
			// dataColumnSchoolBank
			// 
			this.dataColumnSchoolBank.ColumnName = "bank";
			this.dataColumnSchoolBank.MaxLength = 20;
			// 
			// dataColumnSchoolAccount
			// 
			this.dataColumnSchoolAccount.ColumnName = "account";
			this.dataColumnSchoolAccount.MaxLength = 10;
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "NewDataSet";
			this.dataSet.Locale = new System.Globalization.CultureInfo("mn-MN");
			this.dataSet.Relations.AddRange(new System.Data.DataRelation[] {
																			   new System.Data.DataRelation("LevelToSchool", "Level", "School", new string[] {
																																								 "id"}, new string[] {
																																														 "level"}, false)});
			this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
																		 this.tableSchool,
																		 this.tableOrg,
																		 this.tableRegion,
																		 this.tableLevel});
			// 
			// tableOrg
			// 
			this.tableOrg.Columns.AddRange(new System.Data.DataColumn[] {
																			this.dataColumnOrgID,
																			this.dataColumnOrgName,
																			this.dataColumnOrgPhone,
																			this.dataColumnOrgAddress});
			this.tableOrg.TableName = "Org";
			// 
			// dataColumnOrgID
			// 
			this.dataColumnOrgID.AllowDBNull = false;
			this.dataColumnOrgID.AutoIncrement = true;
			this.dataColumnOrgID.ColumnName = "id";
			this.dataColumnOrgID.DataType = typeof(int);
			// 
			// dataColumnOrgName
			// 
			this.dataColumnOrgName.AllowDBNull = false;
			this.dataColumnOrgName.ColumnName = "name";
			this.dataColumnOrgName.MaxLength = 30;
			// 
			// dataColumnOrgPhone
			// 
			this.dataColumnOrgPhone.ColumnName = "phone";
			this.dataColumnOrgPhone.MaxLength = 10;
			// 
			// dataColumnOrgAddress
			// 
			this.dataColumnOrgAddress.ColumnName = "address";
			this.dataColumnOrgAddress.MaxLength = 30;
			// 
			// tableRegion
			// 
			this.tableRegion.Columns.AddRange(new System.Data.DataColumn[] {
																			   this.dataColumnRegionID,
																			   this.dataColumnRegionName,
																			   this.dataColumnRegionForeign});
			this.tableRegion.TableName = "Region";
			// 
			// dataColumnRegionID
			// 
			this.dataColumnRegionID.AllowDBNull = false;
			this.dataColumnRegionID.AutoIncrement = true;
			this.dataColumnRegionID.ColumnName = "id";
			this.dataColumnRegionID.DataType = typeof(int);
			// 
			// dataColumnRegionName
			// 
			this.dataColumnRegionName.AllowDBNull = false;
			this.dataColumnRegionName.ColumnName = "name";
			this.dataColumnRegionName.MaxLength = 20;
			// 
			// dataColumnRegionForeign
			// 
			this.dataColumnRegionForeign.AllowDBNull = false;
			this.dataColumnRegionForeign.ColumnName = "foreign";
			this.dataColumnRegionForeign.DataType = typeof(bool);
			this.dataColumnRegionForeign.DefaultValue = true;
			// 
			// tableLevel
			// 
			this.tableLevel.Columns.AddRange(new System.Data.DataColumn[] {
																			  this.dataColumnLevelID,
																			  this.dataColumnLevelDesc});
			this.tableLevel.Constraints.AddRange(new System.Data.Constraint[] {
																				  new System.Data.UniqueConstraint("Constraint1", new string[] {
																																				   "id"}, false)});
			this.tableLevel.TableName = "Level";
			// 
			// dataColumnLevelID
			// 
			this.dataColumnLevelID.ColumnName = "id";
			this.dataColumnLevelID.DataType = typeof(System.Byte);
			// 
			// dataColumnLevelDesc
			// 
			this.dataColumnLevelDesc.ColumnName = "desc";
			// 
			// con
			// 
			this.con.ConnectionString = "data source=onolt;initial catalog=STraF;password=ub;persist security info=True;us" +
				"er id=sa;workstation id=ONOLT;packet size=4096";
			// 
			// daSchool
			// 
			this.daSchool.DeleteCommand = this.sqlDeleteSchool;
			this.daSchool.InsertCommand = this.sqlInsertSchool;
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
			this.daSchool.UpdateCommand = this.sqlUpdateSchool;
			// 
			// sqlDeleteSchool
			// 
			this.sqlDeleteSchool.CommandText = "DELETE FROM School WHERE (id = @id)";
			this.sqlDeleteSchool.CommandTimeout = 10;
			this.sqlDeleteSchool.Connection = this.con;
			this.sqlDeleteSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertSchool
			// 
			this.sqlInsertSchool.CommandText = "INSERT INTO School (id, name, filial, [level], hold, valid, region, bank) VALUES " +
				"(@name, @filial, @level, @hold, @valid, @region, @bank, @account); SELECT id, na" +
				"me, filial, [level], hold, valid, region, bank, account FROM School WHERE (id = " +
				"@@IDENTITY)";
			this.sqlInsertSchool.CommandTimeout = 10;
			this.sqlInsertSchool.Connection = this.con;
			// 
			// sqlSelectSchool
			// 
			this.sqlSelectSchool.CommandText = "SELECT id, name, filial, [level], hold, valid, region, bank, account FROM School";
			this.sqlSelectSchool.CommandTimeout = 10;
			this.sqlSelectSchool.Connection = this.con;
			// 
			// sqlUpdateSchool
			// 
			this.sqlUpdateSchool.CommandText = @"UPDATE School SET name = @name, filial = @filial, [level] = @level, hold = @hold, valid = @valid, region = @region, bank = @bank, account = @account WHERE (id = @id); SELECT id, name, filial, [level], hold, valid, region, bank, account FROM School WHERE (id = @id)";
			this.sqlUpdateSchool.CommandTimeout = 10;
			this.sqlUpdateSchool.Connection = this.con;
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 0, "name"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@filial", System.Data.SqlDbType.Int, 0, "filial"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@level", System.Data.SqlDbType.NVarChar, 0, "level"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@hold", System.Data.SqlDbType.Bit, 0, "hold"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@valid", System.Data.SqlDbType.Bit, 0, "valid"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.Int, 0, "region"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@bank", System.Data.SqlDbType.VarChar, 0, "bank"));
			this.sqlUpdateSchool.Parameters.Add(new System.Data.SqlClient.SqlParameter("@account", System.Data.SqlDbType.VarChar, 0, "account"));
			// 
			// tabCustomer
			// 
			this.tabCustomer.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.pageSchool,
																					  this.pageRegion,
																					  this.pageOrg});
			this.tabCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCustomer.Name = "tabCustomer";
			this.tabCustomer.SelectedIndex = 0;
			this.tabCustomer.Size = new System.Drawing.Size(512, 345);
			this.tabCustomer.TabIndex = 0;
			// 
			// pageSchool
			// 
			this.pageSchool.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.panelFilter,
																					 this.gridSchool,
																					 this.panelSchoolDetial});
			this.pageSchool.Location = new System.Drawing.Point(4, 22);
			this.pageSchool.Name = "pageSchool";
			this.pageSchool.Size = new System.Drawing.Size(504, 319);
			this.pageSchool.TabIndex = 0;
			this.pageSchool.Text = "Сургууль";
			// 
			// panelFilter
			// 
			this.panelFilter.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panelFilter.BackColor = System.Drawing.SystemColors.Info;
			this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFilter.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.checkValid,
																					  this.checkHold,
																					  this.checkForeign,
																					  this.comboLevel,
																					  this.labelLevel});
			this.panelFilter.Location = new System.Drawing.Point(356, 0);
			this.panelFilter.Name = "panelFilter";
			this.panelFilter.Size = new System.Drawing.Size(152, 176);
			this.panelFilter.TabIndex = 10;
			this.panelFilter.Text = "panel1";
			this.panelFilter.Visible = false;
			this.panelFilter.Leave += new System.EventHandler(this.panelFilter_Leave);
			// 
			// checkValid
			// 
			this.checkValid.BackColor = System.Drawing.SystemColors.Info;
			this.checkValid.Checked = true;
			this.checkValid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkValid.Location = new System.Drawing.Point(8, 32);
			this.checkValid.Name = "checkValid";
			this.checkValid.Size = new System.Drawing.Size(136, 24);
			this.checkValid.TabIndex = 10;
			this.checkValid.Text = "Итгэмжлэгдсэн";
			this.checkValid.CheckedChanged += new System.EventHandler(this.checkValid_CheckedChanged);
			// 
			// checkHold
			// 
			this.checkHold.BackColor = System.Drawing.SystemColors.Info;
			this.checkHold.Checked = true;
			this.checkHold.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkHold.Location = new System.Drawing.Point(8, 8);
			this.checkHold.Name = "checkHold";
			this.checkHold.Size = new System.Drawing.Size(136, 24);
			this.checkHold.TabIndex = 9;
			this.checkHold.Text = "Төрийн өмчийн";
			this.checkHold.CheckedChanged += new System.EventHandler(this.checkHold_CheckedChanged);
			// 
			// checkForeign
			// 
			this.checkForeign.BackColor = System.Drawing.SystemColors.Info;
			this.checkForeign.Location = new System.Drawing.Point(8, 56);
			this.checkForeign.Name = "checkForeign";
			this.checkForeign.Size = new System.Drawing.Size(136, 24);
			this.checkForeign.TabIndex = 8;
			this.checkForeign.Text = "Гадаадын";
			this.checkForeign.CheckedChanged += new System.EventHandler(this.checkForeign_CheckedChanged);
			// 
			// comboLevel
			// 
			this.comboLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboLevel.Items.AddRange(new object[] {
															"(бvгд)",
															"их сургууль",
															"дээд сургууль",
															"коллеж",
															"МСVТ",
															"бусад"});
			this.comboLevel.Location = new System.Drawing.Point(8, 104);
			this.comboLevel.Name = "comboLevel";
			this.comboLevel.Size = new System.Drawing.Size(120, 21);
			this.comboLevel.TabIndex = 1;
			this.comboLevel.SelectedIndexChanged += new System.EventHandler(this.comboLevel_SelectedIndexChanged);
			// 
			// labelLevel
			// 
			this.labelLevel.BackColor = System.Drawing.SystemColors.Info;
			this.labelLevel.Location = new System.Drawing.Point(8, 88);
			this.labelLevel.Name = "labelLevel";
			this.labelLevel.Size = new System.Drawing.Size(60, 15);
			this.labelLevel.TabIndex = 0;
			this.labelLevel.Text = "Хэв шинж:";
			// 
			// gridSchool
			// 
			this.gridSchool.AllowDrop = true;
			this.gridSchool.BackgroundColor = System.Drawing.Color.DarkGray;
			this.gridSchool.CaptionVisible = false;
			this.gridSchool.DataMember = "School";
			this.gridSchool.DataSource = this.dataSet;
			this.gridSchool.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSchool.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridSchool.Name = "gridSchool";
			this.gridSchool.Size = new System.Drawing.Size(504, 247);
			this.gridSchool.TabIndex = 9;
			this.gridSchool.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								   this.dataGridTableStyleSchool});
			this.gridSchool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
			this.gridSchool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDown);
			this.gridSchool.DragDrop += new System.Windows.Forms.DragEventHandler(this.grid_DragDrop);
			this.gridSchool.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			this.gridSchool.DragEnter += new System.Windows.Forms.DragEventHandler(this.grid_DragEnter);
			// 
			// dataGridTableStyleSchool
			// 
			this.dataGridTableStyleSchool.DataGrid = this.gridSchool;
			this.dataGridTableStyleSchool.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnSchoolName,
																													   this.dataGridBoolColumnSchoolHold,
																													   this.dataGridBoolColumnSchoolValid});
			this.dataGridTableStyleSchool.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleSchool.MappingName = "School";
			// 
			// dataGridTextBoxColumnSchoolName
			// 
			this.dataGridTextBoxColumnSchoolName.Format = "";
			this.dataGridTextBoxColumnSchoolName.FormatInfo = null;
			this.dataGridTextBoxColumnSchoolName.HeaderText = "Нэр";
			this.dataGridTextBoxColumnSchoolName.MappingName = "name";
			this.dataGridTextBoxColumnSchoolName.Width = 200;
			// 
			// dataGridBoolColumnSchoolHold
			// 
			this.dataGridBoolColumnSchoolHold.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridBoolColumnSchoolHold.FalseValue = false;
			this.dataGridBoolColumnSchoolHold.HeaderText = "Төрийн";
			this.dataGridBoolColumnSchoolHold.MappingName = "hold";
			this.dataGridBoolColumnSchoolHold.NullValue = ((System.DBNull)(resources.GetObject("dataGridBoolColumnSchoolHold.NullValue")));
			this.dataGridBoolColumnSchoolHold.TrueValue = true;
			this.dataGridBoolColumnSchoolHold.Width = 60;
			// 
			// dataGridBoolColumnSchoolValid
			// 
			this.dataGridBoolColumnSchoolValid.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridBoolColumnSchoolValid.FalseValue = false;
			this.dataGridBoolColumnSchoolValid.HeaderText = "Итгэмжлэл";
			this.dataGridBoolColumnSchoolValid.MappingName = "valid";
			this.dataGridBoolColumnSchoolValid.NullValue = ((System.DBNull)(resources.GetObject("dataGridBoolColumnSchoolValid.NullValue")));
			this.dataGridBoolColumnSchoolValid.TrueValue = true;
			this.dataGridBoolColumnSchoolValid.Width = 60;
			// 
			// panelSchoolDetial
			// 
			this.panelSchoolDetial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSchoolDetial.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.comboSchoolFilial,
																							this.label4,
																							this.comboSchoolLevel,
																							this.label3,
																							this.textSchoolAccount,
																							this.label2,
																							this.textSchoolBank,
																							this.label1});
			this.panelSchoolDetial.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSchoolDetial.Location = new System.Drawing.Point(0, 247);
			this.panelSchoolDetial.Name = "panelSchoolDetial";
			this.panelSchoolDetial.Size = new System.Drawing.Size(504, 72);
			this.panelSchoolDetial.TabIndex = 12;
			// 
			// comboSchoolFilial
			// 
			this.comboSchoolFilial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet, "School.filial"));
			this.comboSchoolFilial.DataSource = this.tableSchool;
			this.comboSchoolFilial.DisplayMember = "name";
			this.comboSchoolFilial.Location = new System.Drawing.Point(120, 32);
			this.comboSchoolFilial.Name = "comboSchoolFilial";
			this.comboSchoolFilial.Size = new System.Drawing.Size(121, 21);
			this.comboSchoolFilial.TabIndex = 7;
			this.comboSchoolFilial.ValueMember = "id";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Харъяа сургууль:";
			// 
			// comboSchoolLevel
			// 
			this.comboSchoolLevel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet, "School.level"));
			this.comboSchoolLevel.DataSource = this.tableLevel;
			this.comboSchoolLevel.DisplayMember = "desc";
			this.comboSchoolLevel.Location = new System.Drawing.Point(120, 8);
			this.comboSchoolLevel.Name = "comboSchoolLevel";
			this.comboSchoolLevel.Size = new System.Drawing.Size(121, 21);
			this.comboSchoolLevel.TabIndex = 5;
			this.comboSchoolLevel.ValueMember = "id";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Хэв шинж:";
			// 
			// textSchoolAccount
			// 
			this.textSchoolAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "School.account"));
			this.textSchoolAccount.Location = new System.Drawing.Point(376, 32);
			this.textSchoolAccount.Name = "textSchoolAccount";
			this.textSchoolAccount.TabIndex = 3;
			this.textSchoolAccount.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(264, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Дансны дугаар:";
			// 
			// textSchoolBank
			// 
			this.textSchoolBank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet, "School.bank"));
			this.textSchoolBank.Location = new System.Drawing.Point(376, 8);
			this.textSchoolBank.Name = "textSchoolBank";
			this.textSchoolBank.TabIndex = 1;
			this.textSchoolBank.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(264, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Харилцах банк:";
			// 
			// pageRegion
			// 
			this.pageRegion.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.gridRegion});
			this.pageRegion.Location = new System.Drawing.Point(4, 22);
			this.pageRegion.Name = "pageRegion";
			this.pageRegion.Size = new System.Drawing.Size(504, 319);
			this.pageRegion.TabIndex = 1;
			this.pageRegion.Text = "Аймаг, Улс";
			// 
			// gridRegion
			// 
			this.gridRegion.CaptionVisible = false;
			this.gridRegion.DataMember = "Region";
			this.gridRegion.DataSource = this.dataSet;
			this.gridRegion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridRegion.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridRegion.Name = "gridRegion";
			this.gridRegion.Size = new System.Drawing.Size(504, 319);
			this.gridRegion.TabIndex = 0;
			this.gridRegion.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								   this.dataGridTableStyleRegion});
			this.gridRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
			this.gridRegion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDown);
			this.gridRegion.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			this.gridRegion.DragEnter += new System.Windows.Forms.DragEventHandler(this.grid_DragEnter);
			// 
			// dataGridTableStyleRegion
			// 
			this.dataGridTableStyleRegion.DataGrid = this.gridRegion;
			this.dataGridTableStyleRegion.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnRegionName,
																													   this.dataGridBoolColumnRegionForeign});
			this.dataGridTableStyleRegion.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleRegion.MappingName = "Region";
			// 
			// dataGridTextBoxColumnRegionName
			// 
			this.dataGridTextBoxColumnRegionName.Format = "";
			this.dataGridTextBoxColumnRegionName.FormatInfo = null;
			this.dataGridTextBoxColumnRegionName.HeaderText = "Аймаг, улсын нэр";
			this.dataGridTextBoxColumnRegionName.MappingName = "name";
			this.dataGridTextBoxColumnRegionName.Width = 200;
			// 
			// dataGridBoolColumnRegionForeign
			// 
			this.dataGridBoolColumnRegionForeign.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridBoolColumnRegionForeign.AllowNull = false;
			this.dataGridBoolColumnRegionForeign.FalseValue = false;
			this.dataGridBoolColumnRegionForeign.HeaderText = "Гадаадын";
			this.dataGridBoolColumnRegionForeign.MappingName = "foreign";
			this.dataGridBoolColumnRegionForeign.NullText = "";
			this.dataGridBoolColumnRegionForeign.NullValue = ((System.DBNull)(resources.GetObject("dataGridBoolColumnRegionForeign.NullValue")));
			this.dataGridBoolColumnRegionForeign.TrueValue = true;
			this.dataGridBoolColumnRegionForeign.Width = 60;
			// 
			// pageOrg
			// 
			this.pageOrg.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.gridOrg});
			this.pageOrg.Location = new System.Drawing.Point(4, 22);
			this.pageOrg.Name = "pageOrg";
			this.pageOrg.Size = new System.Drawing.Size(504, 319);
			this.pageOrg.TabIndex = 2;
			this.pageOrg.Text = "Байгууллага (Улаанбаатар)";
			// 
			// gridOrg
			// 
			this.gridOrg.CaptionVisible = false;
			this.gridOrg.DataMember = "Org";
			this.gridOrg.DataSource = this.dataSet;
			this.gridOrg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridOrg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridOrg.Name = "gridOrg";
			this.gridOrg.Size = new System.Drawing.Size(504, 319);
			this.gridOrg.TabIndex = 0;
			this.gridOrg.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dataGridTableStyleOrg});
			this.gridOrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
			this.gridOrg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDown);
			this.gridOrg.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			this.gridOrg.DragEnter += new System.Windows.Forms.DragEventHandler(this.grid_DragEnter);
			// 
			// dataGridTableStyleOrg
			// 
			this.dataGridTableStyleOrg.DataGrid = this.gridOrg;
			this.dataGridTableStyleOrg.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													this.dataGridTextBoxColumnOrgName,
																													this.dataGridTextBoxColumnOrgPhone,
																													this.dataGridTextBoxColumnOrgAddress});
			this.dataGridTableStyleOrg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleOrg.MappingName = "Org";
			// 
			// dataGridTextBoxColumnOrgName
			// 
			this.dataGridTextBoxColumnOrgName.Format = "";
			this.dataGridTextBoxColumnOrgName.FormatInfo = null;
			this.dataGridTextBoxColumnOrgName.HeaderText = "Нэр";
			this.dataGridTextBoxColumnOrgName.MappingName = "name";
			this.dataGridTextBoxColumnOrgName.Width = 200;
			// 
			// dataGridTextBoxColumnOrgPhone
			// 
			this.dataGridTextBoxColumnOrgPhone.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumnOrgPhone.Format = "";
			this.dataGridTextBoxColumnOrgPhone.FormatInfo = null;
			this.dataGridTextBoxColumnOrgPhone.HeaderText = "Утас";
			this.dataGridTextBoxColumnOrgPhone.MappingName = "phone";
			this.dataGridTextBoxColumnOrgPhone.Width = 75;
			// 
			// dataGridTextBoxColumnOrgAddress
			// 
			this.dataGridTextBoxColumnOrgAddress.Format = "";
			this.dataGridTextBoxColumnOrgAddress.FormatInfo = null;
			this.dataGridTextBoxColumnOrgAddress.HeaderText = "Хаяг";
			this.dataGridTextBoxColumnOrgAddress.MappingName = "address";
			this.dataGridTextBoxColumnOrgAddress.Width = 75;
			// 
			// daOrg
			// 
			this.daOrg.DeleteCommand = this.sqlDeleteOrg;
			this.daOrg.InsertCommand = this.sqlInsertOrg;
			this.daOrg.SelectCommand = this.sqlSelectOrg;
			this.daOrg.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							new System.Data.Common.DataTableMapping("Table", "Org", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("id", "id"),
																																																   new System.Data.Common.DataColumnMapping("name", "name"),
																																																   new System.Data.Common.DataColumnMapping("phone", "phone"),
																																																   new System.Data.Common.DataColumnMapping("address", "address")})});
			this.daOrg.UpdateCommand = this.sqlUpdateOrg;
			// 
			// sqlDeleteOrg
			// 
			this.sqlDeleteOrg.CommandText = "DELETE FROM Org WHERE (id = @id)";
			this.sqlDeleteOrg.Connection = this.con;
			this.sqlDeleteOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertOrg
			// 
			this.sqlInsertOrg.CommandText = "INSERT INTO Org (name, phone, address) VALUES (@name, @phone, @address); SELECT i" +
				"d, name, phone, address FROM Org WHERE (id = @@IDENTITY)";
			this.sqlInsertOrg.Connection = this.con;
			this.sqlInsertOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 30, "name"));
			this.sqlInsertOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.NVarChar, 10, "phone"));
			this.sqlInsertOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 30, "address"));
			// 
			// sqlSelectOrg
			// 
			this.sqlSelectOrg.CommandText = "SELECT id, name, phone, address FROM Org";
			this.sqlSelectOrg.Connection = this.con;
			// 
			// sqlUpdateOrg
			// 
			this.sqlUpdateOrg.CommandText = "UPDATE Org SET name = @name, phone = @phone, address = @address WHERE (id = @id);" +
				" SELECT id, name, phone, address FROM Org WHERE (id = @id)";
			this.sqlUpdateOrg.Connection = this.con;
			this.sqlUpdateOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 30, "name"));
			this.sqlUpdateOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.NVarChar, 10, "phone"));
			this.sqlUpdateOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 30, "address"));
			this.sqlUpdateOrg.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// daRegion
			// 
			this.daRegion.DeleteCommand = this.sqlDeleteRegion;
			this.daRegion.InsertCommand = this.sqlInsertRegion;
			this.daRegion.SelectCommand = this.sqlSelectRegion;
			this.daRegion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							   new System.Data.Common.DataTableMapping("Table", "Region", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("id", "id"),
																																																		 new System.Data.Common.DataColumnMapping("name", "name"),
																																																		 new System.Data.Common.DataColumnMapping("foreign", "foreign")})});
			this.daRegion.UpdateCommand = this.sqlUpdateRegion;
			// 
			// sqlDeleteRegion
			// 
			this.sqlDeleteRegion.CommandText = "DELETE FROM Region WHERE (id = @id)";
			this.sqlDeleteRegion.Connection = this.con;
			this.sqlDeleteRegion.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertRegion
			// 
			this.sqlInsertRegion.CommandText = "INSERT INTO Region (name, [foreign]) VALUES (@name, @foreign); SELECT id, name, [" +
				"foreign] FROM Region WHERE (id = @@IDENTITY)";
			this.sqlInsertRegion.Connection = this.con;
			this.sqlInsertRegion.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20, "name"));
			this.sqlInsertRegion.Parameters.Add(new System.Data.SqlClient.SqlParameter("@foreign", System.Data.SqlDbType.Bit, 1, "foreign"));
			// 
			// sqlSelectRegion
			// 
			this.sqlSelectRegion.CommandText = "SELECT id, name, [foreign] FROM Region";
			this.sqlSelectRegion.Connection = this.con;
			// 
			// sqlUpdateRegion
			// 
			this.sqlUpdateRegion.CommandText = "UPDATE Region SET name = @name, [foreign] = @foreign WHERE (id = @id); SELECT id," +
				" name, [foreign] FROM Region WHERE (id = @id)";
			this.sqlUpdateRegion.Connection = this.con;
			this.sqlUpdateRegion.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20, "name"));
			this.sqlUpdateRegion.Parameters.Add(new System.Data.SqlClient.SqlParameter("@foreign", System.Data.SqlDbType.Bit, 1, "foreign"));
			this.sqlUpdateRegion.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// Customer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 345);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabCustomer});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuMain;
			this.Name = "Customer";
			this.ShowInTaskbar = false;
			this.Text = "Харилцагчид";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Customer_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.tableSchool)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableOrg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableLevel)).EndInit();
			this.tabCustomer.ResumeLayout(false);
			this.pageSchool.ResumeLayout(false);
			this.panelFilter.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSchool)).EndInit();
			this.panelSchoolDetial.ResumeLayout(false);
			this.pageRegion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridRegion)).EndInit();
			this.pageOrg.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridOrg)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		private void LoadData() {
			dataSet.EnforceConstraints = false;
			try {
				for (int i=0;i<descLevel.Length;i++) {
					DataRow newRow = tableLevel.NewRow();
					newRow[0] = i + 1;
					newRow[1] = descLevel[i];
					tableLevel.Rows.Add(newRow);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				dataSet.EnforceConstraints = true;
			}
		}
		private void RefreshSchool() {
			this.Cursor = Cursors.WaitCursor;
			MakeFilter();
			tableSchool.Clear();
			dataSet.EnforceConstraints = false;
			if (filter != "")
				daSchool.SelectCommand.CommandText = sql + " where " + filter;
			else
				daSchool.SelectCommand.CommandText = sql;
			try {
				daSchool.Fill(tableSchool);
				DataRow newRow = tableSchool.NewRow();
				newRow[0]= 0;
				newRow[1] = "(салбар бус)";
				tableSchool.Rows.Add(newRow);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				dataSet.EnforceConstraints = true;
				this.Cursor = Cursors.Default;
			}
		}
		private void RefreshRegion() {
			this.Cursor = Cursors.WaitCursor;
			dataSet.EnforceConstraints = false;
			tableRegion.Clear();
			try {
				daRegion.Fill(tableRegion);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				dataSet.EnforceConstraints = true;
				this.Cursor = Cursors.Default;
			}
		}
		private void RefreshOrg() {
			this.Cursor = Cursors.WaitCursor;
			dataSet.EnforceConstraints = false;
			tableOrg.Clear();
			try {
				daOrg.Fill(tableOrg);
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
			int row = gridSchool.CurrentRowIndex;
			int col = gridSchool.CurrentCell.ColumnNumber;
			string source, data;
			source = Convert.ToString(search);
			source = source.ToUpper();
			if (back)
				step = -1;
			row += step;
			while (row < tableSchool.Rows.Count && row >=0) {
				data = Convert.ToString(gridSchool[row, col]);
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
			if (row < tableSchool.Rows.Count && row >=0) {
				gridSchool.CurrentRowIndex = row;
				gridSchool.Select(row);
			}
		}
		public void Replace(object search, object replace, bool regular, bool back) {
			int step = 1;
			int row = gridSchool.CurrentRowIndex;
			int col = gridSchool.CurrentCell.ColumnNumber;
			string source, data, rep;
			source = Convert.ToString(search);
			source = source.ToUpper();
			rep = Convert.ToString(replace);
			if (back)
				step = -1;
			row += step;
			while (row < tableSchool.Rows.Count && row >=0) {
				data = Convert.ToString(gridSchool[row, col]);
				data = data.ToUpper();
				if (regular) {
					if (data.StartsWith(source)) {
						gridSchool[row, col] = data.Replace(source, rep);
					}
				}
				else {
					if (data == source) {
						gridSchool[row, col] = data.Replace(source, rep);
					}
				}
				row += step;
			}
		}

		public ReportDocument GetReportDocument() {
			/*
			ReportDocument doc = new ReportLoan();
			doc.SetDataSource(dataSet);
			return doc;
			*/
			return null;
		}
		private void Customer_KeyDown(object sender, KeyEventArgs e) {
			if (ActiveControl != null)
				Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, (int)e.KeyData, 1);
		}
		private void grid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.S: 
					Save(sender, e); 
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
					Undo(sender, e); 
					break;
			}
		}
		private void Save(object sender, EventArgs e) {
			try {
				daSchool.Update(dataSet, "School");
				daRegion.Update(dataSet, "Region");
				daOrg.Update(dataSet, "Org");
			}
			catch (Exception ex) {
				if (MessageBox.Show(ex.ToString() + "\nVйлдлийг буцаах уу ?", Straf.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.OK) {
					tableSchool.RejectChanges();
					tableRegion.RejectChanges();
					tableOrg.RejectChanges();
				}
			}
		}
		private void Copy(object sender, EventArgs e) {
			if (tabCustomer.SelectedIndex != -1) {
				string strData = "";
				for (int i=0;i<tables[tabCustomer.SelectedIndex].Rows.Count;i++) {
					if (grids[tabCustomer.SelectedIndex].IsSelected(i)) {
						for (int j = 0; j < tables[tabCustomer.SelectedIndex].Columns.Count; j++) {
							strData += tables[tabCustomer.SelectedIndex].Rows[i].ItemArray.GetValue(j).ToString() + "\t";
						}
						strData += "\r\n";
					}
				}
				Clipboard.SetDataObject(strData);
			}
		}
		private void Cut(object sender, EventArgs e) {
			Copy(sender, e);
			Win32.SendMessage(gridSchool.Handle, 0x0100 /*WM_KEYDOWN*/, (int) Keys.Delete, 1);
		}
		private void Paste(object sender, EventArgs e) {
			IDataObject iData = Clipboard.GetDataObject();
			if (iData.GetDataPresent(typeof(DataRowCollection))) {
			}
			else if (iData.GetDataPresent(DataFormats.Text)) {
				this.Cursor = Cursors.WaitCursor;
				dataSet.EnforceConstraints = false;
				string strData = (string) iData.GetData(DataFormats.Text);
				try {
					string[] lines = strData.Split(new Char[] {'\n'});
                    ArrayList rows = new ArrayList();
					for (int i=0; i<lines.Length;i++) {
						string line = lines[i].Trim(new Char[]{'\r'});
						if (line != "") {
							DataRow row = tableSchool.NewRow();
							string[] words = line.Split(new Char[] {'\t'});
							int j = 0;
							while (j < tableSchool.Columns.Count - 1 && j < words.Length) {
								row[j + 1] = words[j];
								j++;
							}
							rows.Add(row);
						}
					}
					System.Collections.IEnumerator enumerator = rows.GetEnumerator();
					while ( enumerator.MoveNext() )
						tableSchool.Rows.Add((DataRow)enumerator.Current);
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
		private void Undo(object sender, EventArgs e) {
			tableSchool.RejectChanges();
		}
		private void ShowFilter(bool b) {
			if (b) {
				panelFilter.Show();
				cmdShowFilter.Checked = true;
			}
			else {
				panelFilter.Hide();
				cmdShowFilter.Checked = false;
			}
		}
		private void cmdShowFilter_Click(object sender, System.EventArgs e) {
			if (panelFilter.Visible) 
				ShowFilter(false);
			else 
				ShowFilter(true);
		}		
		private void panelFilter_Leave(object sender, System.EventArgs e) {
			ShowFilter(false);
		}
		private void checkHold_CheckedChanged(object sender, System.EventArgs e) {
			if (hold != checkHold.Checked) {
				hold = checkHold.Checked;
				RefreshSchool();
				if (hold)
					checkHold.Text = "Төрийн";
				else
					checkHold.Text = "Төрийн бус";
			}
		}
		private void checkValid_CheckedChanged(object sender, System.EventArgs e) {
			if (valid != checkValid.Checked) {
				valid = checkValid.Checked;
				RefreshSchool();
				if (valid)
					checkValid.Text = "Итгэмжлэгдсэн";
				else
					checkValid.Text = "Итгэмжлэгдээгvй";
			}
		}
		private void checkForeign_CheckedChanged(object sender, System.EventArgs e) {
			if (foreign != checkForeign.Checked) {
				foreign = checkForeign.Checked;
				RefreshSchool();
			}
		}
		private void comboLevel_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (level != comboLevel.SelectedIndex) {
				level = comboLevel.SelectedIndex;
				RefreshSchool();
			}
		}
		private void  MakeFilter() {
			filter = "";
			if (1 <= level && level <= 5)
				filter += "level=" + Convert.ToString(level);
			if (filter != "")
				filter += " and ";
			filter += " hold=" + (hold ? "1" : "0") + " and valid=" + (valid ? "1" : "0");
		}

		private void grid_CurrentCellChanged(object sender, System.EventArgs e) {
			Straf parent = (Straf)this.MdiParent;
			if (parent != null) {
				int item = (int)((DataGrid)sender).Tag;
				item--;
				parent.statusRecord.Text = string.Format("{0}/{1}", grids[item].CurrentRowIndex + 1, tables[item].Rows.Count);
			}
		}
		private void grid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				int item = (int)((DataGrid)sender).Tag;
				item--;
				System.Windows.Forms.DataGrid.HitTestInfo hit;
				hit = grids[item].HitTest(e.X, e.Y);
				int selRow = hit.Row;
				if (selRow != -1) {
					grids[item].Select(selRow);
					string dragText = "";
					int i = 0;
					foreach (DataRow row in tables[item].Rows) {
                        if (grids[item].IsSelected(i)) {
							foreach (DataColumn col in tables[item].Columns) {
								dragText += row[col] + "\t";
							}
							dragText += "\r\n";
						}
						i++;
					}
					grids[item].DoDragDrop(dragText, DragDropEffects.Copy | DragDropEffects.Move);
				}
			}
		}

		private void grid_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
			if (e.Data.GetDataPresent(typeof(DataRow))) 
				e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
			else if (e.Data.GetDataPresent(DataFormats.Text)) 
				e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}
		private void grid_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
		
		}
	}
}

