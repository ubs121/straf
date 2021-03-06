using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace STraF {
	/// <summary>
	/// STraF Main Form
	/// </summary>
	public class Straf : Form {
		public const string appName = "STraF Програм";
		public static string strCon;
		public static bool logged;
		public static Hashtable permissions;
		
        
		public struct Setting {
			public string server;
			public string uid;
			public string pwd;
		
			public int mainState;
			public int childState;
			public int findX, findY;
		}

		public static Setting opt;
		private bool optSaved;
		private string wksFileSchool;
		private string wksFileRegion;
		private string wksFileOrg;

		private FindDlg formFind;
		private Customer formCustomer;
		private SummaryView formSummary;
		private PoorView formLoan;
		private HelpView formHelp;
		private ThirdView formThird;
		private TaxView formTax;
		private HerderView formHerder;
		private PoorView formPoor;
		private PrizeView formPrize;
		private ForeignView formForeign;
		private TaxUBView formTaxUB;
		private QueryView formQuery;
		private ReportView formReport;
		private MenuItem[] dbCommands;
		private ToolBarButton[] dbTools;

		private MainMenu menuMain;
		private MenuItem menuFile;
		public MenuItem cmdConnect;
		private MenuItem sep1;
		public MenuItem cmdNew;
		public MenuItem cmdOpen;
		public MenuItem cmdSave;
		private MenuItem cmdClose;
		private MenuItem cmdCloseAll;
		private MenuItem menuItem2;
		public MenuItem cmdImport;
		public MenuItem cmdPrint;
		private MenuItem menuItem6;
		private MenuItem cmdExit;
		private MenuItem menuEdit;
		public MenuItem cmdCut;
		public MenuItem cmdCopy;
		public MenuItem cmdPaste;
		public MenuItem cmdDelete;
		public MenuItem cmdSelectAll;
		private MenuItem sep3;
		public MenuItem cmdFind;
		private MenuItem menuView;
		private MenuItem cmdToolbar;
		private MenuItem cmdStatus;
		private MenuItem cmdWks;
		private MenuItem menuItem5;
		public MenuItem cmdRefresh;
		public MenuItem cmdSort;
		private MenuItem menuTools;
		private MenuItem cmdOptions;
		private MenuItem menuWindow;
		private MenuItem cmdCascade;
		private MenuItem cmdHTile;
		private MenuItem cmdVTile;
		private MenuItem cmdArrange;
		private MenuItem menuHelp;
		private MenuItem cmdAbout;
		private ImageList images;
		private ToolBar toolBar;
		public ToolBarButton toolNew;
		public ToolBarButton toolOpen;
		public ToolBarButton toolSave;
		public ToolBarButton toolPrint;
		public ToolBarButton toolCut;
		public ToolBarButton toolCopy;
		public ToolBarButton toolPaste;
		public ToolBarButton toolDelete;
		public ToolBarButton toolWks;
		public ToolBarButton toolRefresh;
		public ToolBarButton toolImport;
		public ToolBarButton toolFind;
		private StatusBar statusBar;
		public StatusBarPanel statusMain;
		public StatusBarPanel statusRecord;
		public StatusBarPanel statusConnect;
		public StatusBarPanel statusCap;
		public StatusBarPanel statusNum;
		public System.Data.SqlClient.SqlConnection con;
		private ProgressBar progress;
		private TabControl tabWks;
		private TabPage pageSchool;
		private TreeView treeSchool;
		private TabPage pageRegion;
		private TabPage pageOrg;
		private Splitter splitterWks;
		private TreeView treeRegion;
		private TreeView treeOrg;
		public ToolBarButton toolSeparator1;
		public ToolBarButton toolSeparotor2;
		private ToolBarButton toolQuery;
		private MenuItem cmdQuery;
		public MenuItem cmdRename;
		private System.Data.SqlClient.SqlCommand cmd;
		private MenuItem cmdPermission;
		private ToolBarButton toolUndo;
		private MenuItem cmdUndo;
		private MenuItem menuItem3;
		private MenuItem cmdCustomer;
		private ToolBarButton toolCustomer;
		private MenuItem cmdPrintPreview;
		private ToolBarButton toolPrintPreview;
		private MenuItem cmdReport;
		private System.Windows.Forms.MenuItem cmdExport;
		private System.Windows.Forms.Label labelPType;
		private System.Windows.Forms.ComboBox comboPType;
		private System.Windows.Forms.MenuItem cmdSummary;
		private System.Windows.Forms.ToolBarButton toolMoveFirst;
		private System.Windows.Forms.ToolBarButton toolMovePrev;
		private System.Windows.Forms.ToolBarButton toolMoveNext;
		private System.Windows.Forms.ToolBarButton toolMoveLast;
		private System.Windows.Forms.ToolBarButton toolSeparator3;
		private System.Windows.Forms.ToolBarButton toolGoto;
		private System.Windows.Forms.ToolBarButton tooSeparotor4;
		private System.ComponentModel.IContainer components;

		public Straf() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			Application.ApplicationExit += new System.EventHandler(this.Straf_OnExit);
			Application.Idle += new System.EventHandler(this.Straf_Idle);
			strCon = "initial catalog=STraF;persist security info=True;packet size=4096;";
			wksFileSchool = "school.wks";
			wksFileRegion = "region.wks";
			wksFileOrg = "org.wks";
			dbCommands = new MenuItem[] {cmdImport, cmdFind, cmdCustomer, cmdQuery};
			dbTools = new ToolBarButton[] {toolImport, toolFind, toolCustomer, toolQuery};
			permissions = new Hashtable();
			Text = appName;
			opt.server = "";
			opt.uid = "";
			opt.pwd = "";
			serializeOption(true);

			treeSchool.Tag = 1;
			treeRegion.Tag = 2;
			treeOrg.Tag = 3;
			WindowState = (FormWindowState) opt.mainState;
			Show();
			Update();
		
			cmdConnect_Click(null, null);
			if (logged)	{
				progress.Show();
				progress.Value = 0;
				LoadPermissions();
				progress.Value = 30;
				serializeWks(treeSchool, wksFileSchool, true);
				serializeWks(treeRegion, wksFileRegion, true);
				serializeWks(treeOrg, wksFileOrg, true);
				treeSchool.Select();
				progress.Value = 100;
				progress.Hide();
			}
		}
		~Straf() {
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Straf));
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.cmdConnect = new System.Windows.Forms.MenuItem();
			this.sep1 = new System.Windows.Forms.MenuItem();
			this.cmdNew = new System.Windows.Forms.MenuItem();
			this.cmdOpen = new System.Windows.Forms.MenuItem();
			this.cmdSave = new System.Windows.Forms.MenuItem();
			this.cmdRename = new System.Windows.Forms.MenuItem();
			this.cmdClose = new System.Windows.Forms.MenuItem();
			this.cmdCloseAll = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.cmdImport = new System.Windows.Forms.MenuItem();
			this.cmdExport = new System.Windows.Forms.MenuItem();
			this.cmdPrint = new System.Windows.Forms.MenuItem();
			this.cmdPrintPreview = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.cmdExit = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.cmdUndo = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.cmdCut = new System.Windows.Forms.MenuItem();
			this.cmdCopy = new System.Windows.Forms.MenuItem();
			this.cmdPaste = new System.Windows.Forms.MenuItem();
			this.cmdDelete = new System.Windows.Forms.MenuItem();
			this.cmdSelectAll = new System.Windows.Forms.MenuItem();
			this.sep3 = new System.Windows.Forms.MenuItem();
			this.cmdFind = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.cmdToolbar = new System.Windows.Forms.MenuItem();
			this.cmdStatus = new System.Windows.Forms.MenuItem();
			this.cmdWks = new System.Windows.Forms.MenuItem();
			this.cmdCustomer = new System.Windows.Forms.MenuItem();
			this.cmdSummary = new System.Windows.Forms.MenuItem();
			this.cmdQuery = new System.Windows.Forms.MenuItem();
			this.cmdReport = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.cmdRefresh = new System.Windows.Forms.MenuItem();
			this.cmdSort = new System.Windows.Forms.MenuItem();
			this.menuTools = new System.Windows.Forms.MenuItem();
			this.cmdOptions = new System.Windows.Forms.MenuItem();
			this.cmdPermission = new System.Windows.Forms.MenuItem();
			this.menuWindow = new System.Windows.Forms.MenuItem();
			this.cmdCascade = new System.Windows.Forms.MenuItem();
			this.cmdHTile = new System.Windows.Forms.MenuItem();
			this.cmdVTile = new System.Windows.Forms.MenuItem();
			this.cmdArrange = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.cmdAbout = new System.Windows.Forms.MenuItem();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.toolBar = new System.Windows.Forms.ToolBar();
			this.toolNew = new System.Windows.Forms.ToolBarButton();
			this.toolOpen = new System.Windows.Forms.ToolBarButton();
			this.toolSave = new System.Windows.Forms.ToolBarButton();
			this.toolPrint = new System.Windows.Forms.ToolBarButton();
			this.toolPrintPreview = new System.Windows.Forms.ToolBarButton();
			this.toolSeparator1 = new System.Windows.Forms.ToolBarButton();
			this.toolCut = new System.Windows.Forms.ToolBarButton();
			this.toolCopy = new System.Windows.Forms.ToolBarButton();
			this.toolPaste = new System.Windows.Forms.ToolBarButton();
			this.toolDelete = new System.Windows.Forms.ToolBarButton();
			this.toolUndo = new System.Windows.Forms.ToolBarButton();
			this.toolSeparotor2 = new System.Windows.Forms.ToolBarButton();
			this.toolRefresh = new System.Windows.Forms.ToolBarButton();
			this.toolWks = new System.Windows.Forms.ToolBarButton();
			this.toolCustomer = new System.Windows.Forms.ToolBarButton();
			this.toolQuery = new System.Windows.Forms.ToolBarButton();
			this.toolImport = new System.Windows.Forms.ToolBarButton();
			this.toolFind = new System.Windows.Forms.ToolBarButton();
			this.toolSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.toolMoveFirst = new System.Windows.Forms.ToolBarButton();
			this.toolMovePrev = new System.Windows.Forms.ToolBarButton();
			this.toolMoveNext = new System.Windows.Forms.ToolBarButton();
			this.toolMoveLast = new System.Windows.Forms.ToolBarButton();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusMain = new System.Windows.Forms.StatusBarPanel();
			this.statusRecord = new System.Windows.Forms.StatusBarPanel();
			this.statusConnect = new System.Windows.Forms.StatusBarPanel();
			this.statusCap = new System.Windows.Forms.StatusBarPanel();
			this.statusNum = new System.Windows.Forms.StatusBarPanel();
			this.con = new System.Data.SqlClient.SqlConnection();
			this.progress = new System.Windows.Forms.ProgressBar();
			this.tabWks = new System.Windows.Forms.TabControl();
			this.pageSchool = new System.Windows.Forms.TabPage();
			this.treeSchool = new System.Windows.Forms.TreeView();
			this.pageRegion = new System.Windows.Forms.TabPage();
			this.treeRegion = new System.Windows.Forms.TreeView();
			this.pageOrg = new System.Windows.Forms.TabPage();
			this.treeOrg = new System.Windows.Forms.TreeView();
			this.splitterWks = new System.Windows.Forms.Splitter();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.labelPType = new System.Windows.Forms.Label();
			this.comboPType = new System.Windows.Forms.ComboBox();
			this.toolGoto = new System.Windows.Forms.ToolBarButton();
			this.tooSeparotor4 = new System.Windows.Forms.ToolBarButton();
			((System.ComponentModel.ISupportInitialize)(this.statusMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusRecord)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusConnect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusCap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusNum)).BeginInit();
			this.tabWks.SuspendLayout();
			this.pageSchool.SuspendLayout();
			this.pageRegion.SuspendLayout();
			this.pageOrg.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFile,
																					 this.menuEdit,
																					 this.menuView,
																					 this.menuTools,
																					 this.menuWindow,
																					 this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmdConnect,
																					 this.sep1,
																					 this.cmdNew,
																					 this.cmdOpen,
																					 this.cmdSave,
																					 this.cmdRename,
																					 this.cmdClose,
																					 this.cmdCloseAll,
																					 this.menuItem2,
																					 this.cmdImport,
																					 this.cmdExport,
																					 this.cmdPrint,
																					 this.cmdPrintPreview,
																					 this.menuItem6,
																					 this.cmdExit});
			this.menuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuFile.Text = "&Файл";
			// 
			// cmdConnect
			// 
			this.cmdConnect.Index = 0;
			this.cmdConnect.Text = "Бааз &холбох...";
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// sep1
			// 
			this.sep1.Index = 1;
			this.sep1.MergeOrder = 2;
			this.sep1.Text = "-";
			// 
			// cmdNew
			// 
			this.cmdNew.Index = 2;
			this.cmdNew.MergeOrder = 3;
			this.cmdNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.cmdNew.Text = "&Шинэ";
			this.cmdNew.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdOpen
			// 
			this.cmdOpen.Index = 3;
			this.cmdOpen.MergeOrder = 4;
			this.cmdOpen.MergeType = System.Windows.Forms.MenuMerge.Replace;
			this.cmdOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.cmdOpen.Text = "&Нээх";
			this.cmdOpen.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdSave
			// 
			this.cmdSave.Index = 4;
			this.cmdSave.MergeOrder = 5;
			this.cmdSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.cmdSave.Text = "Ха&дгалах";
			this.cmdSave.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdRename
			// 
			this.cmdRename.Index = 5;
			this.cmdRename.MergeOrder = 6;
			this.cmdRename.MergeType = System.Windows.Forms.MenuMerge.Replace;
			this.cmdRename.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.cmdRename.Text = "&Нэр солих";
			this.cmdRename.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdClose
			// 
			this.cmdClose.Index = 6;
			this.cmdClose.MergeOrder = 7;
			this.cmdClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
			this.cmdClose.Text = "Х&аах";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdCloseAll
			// 
			this.cmdCloseAll.Index = 7;
			this.cmdCloseAll.MergeOrder = 8;
			this.cmdCloseAll.Text = "&Бvгдийг хаах";
			this.cmdCloseAll.Click += new System.EventHandler(this.cmdCloseAll_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 8;
			this.menuItem2.MergeOrder = 9;
			this.menuItem2.Text = "-";
			// 
			// cmdImport
			// 
			this.cmdImport.Index = 9;
			this.cmdImport.MergeOrder = 10;
			this.cmdImport.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
			this.cmdImport.Text = "&Импорт...";
			this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
			// 
			// cmdExport
			// 
			this.cmdExport.Index = 10;
			this.cmdExport.MergeOrder = 11;
			this.cmdExport.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
			this.cmdExport.Text = "&Экспорт...";
			this.cmdExport.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdPrint
			// 
			this.cmdPrint.Index = 11;
			this.cmdPrint.MergeOrder = 12;
			this.cmdPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.cmdPrint.Text = "&Хэвлэх";
			this.cmdPrint.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdPrintPreview
			// 
			this.cmdPrintPreview.Index = 12;
			this.cmdPrintPreview.MergeOrder = 13;
			this.cmdPrintPreview.Text = "Хэвлэхийн өмнө харах";
			this.cmdPrintPreview.Click += new System.EventHandler(this.cmdPrintPreview_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 13;
			this.menuItem6.MergeOrder = 14;
			this.menuItem6.Text = "-";
			// 
			// cmdExit
			// 
			this.cmdExit.Index = 14;
			this.cmdExit.MergeOrder = 15;
			this.cmdExit.Text = "&Гарах";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmdUndo,
																					 this.menuItem3,
																					 this.cmdCut,
																					 this.cmdCopy,
																					 this.cmdPaste,
																					 this.cmdDelete,
																					 this.cmdSelectAll,
																					 this.sep3,
																					 this.cmdFind});
			this.menuEdit.MergeOrder = 1;
			this.menuEdit.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuEdit.Text = "&Засах";
			// 
			// cmdUndo
			// 
			this.cmdUndo.Index = 0;
			this.cmdUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.cmdUndo.Text = "Vйл&длийг буцаах";
			this.cmdUndo.Click += new System.EventHandler(this.sendCommand);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// cmdCut
			// 
			this.cmdCut.Index = 2;
			this.cmdCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.cmdCut.Text = "&Зөөх";
			this.cmdCut.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdCopy
			// 
			this.cmdCopy.Index = 3;
			this.cmdCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.cmdCopy.Text = "&Хуулах";
			this.cmdCopy.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdPaste
			// 
			this.cmdPaste.Index = 4;
			this.cmdPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.cmdPaste.Text = "&Оруулах";
			this.cmdPaste.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdDelete
			// 
			this.cmdDelete.Index = 5;
			this.cmdDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.cmdDelete.Text = "Ха&сах";
			this.cmdDelete.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdSelectAll
			// 
			this.cmdSelectAll.Index = 6;
			this.cmdSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.cmdSelectAll.Text = "&Бvгдийг сонгох";
			this.cmdSelectAll.Click += new System.EventHandler(this.sendCommand);
			// 
			// sep3
			// 
			this.sep3.Index = 7;
			this.sep3.Text = "-";
			// 
			// cmdFind
			// 
			this.cmdFind.Index = 8;
			this.cmdFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.cmdFind.Text = "&Хайлт && Солилт...";
			this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmdToolbar,
																					 this.cmdStatus,
																					 this.cmdWks,
																					 this.cmdCustomer,
																					 this.cmdSummary,
																					 this.cmdQuery,
																					 this.cmdReport,
																					 this.menuItem5,
																					 this.cmdRefresh,
																					 this.cmdSort});
			this.menuView.MergeOrder = 2;
			this.menuView.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuView.Text = "&Харах";
			// 
			// cmdToolbar
			// 
			this.cmdToolbar.Checked = true;
			this.cmdToolbar.Index = 0;
			this.cmdToolbar.Text = "&Хэрэгсэл";
			this.cmdToolbar.Click += new System.EventHandler(this.cmdToolbar_Click);
			// 
			// cmdStatus
			// 
			this.cmdStatus.Checked = true;
			this.cmdStatus.Index = 1;
			this.cmdStatus.Text = "&Төлвийн мөр";
			this.cmdStatus.Click += new System.EventHandler(this.cmdStatus_Click);
			// 
			// cmdWks
			// 
			this.cmdWks.Checked = true;
			this.cmdWks.Index = 2;
			this.cmdWks.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
			this.cmdWks.Text = "&Ажлын самбар";
			this.cmdWks.Click += new System.EventHandler(this.cmdWks_Click);
			// 
			// cmdCustomer
			// 
			this.cmdCustomer.Index = 3;
			this.cmdCustomer.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftU;
			this.cmdCustomer.Text = "&Харилцагчид";
			this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
			// 
			// cmdSummary
			// 
			this.cmdSummary.Index = 4;
			this.cmdSummary.Text = "Т&овчоо";
			this.cmdSummary.Click += new System.EventHandler(this.cmdSummary_Click);
			// 
			// cmdQuery
			// 
			this.cmdQuery.Index = 5;
			this.cmdQuery.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftQ;
			this.cmdQuery.Text = "Асуулга";
			this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_Click);
			// 
			// cmdReport
			// 
			this.cmdReport.Index = 6;
			this.cmdReport.Text = "&Тайлан";
			this.cmdReport.Click += new System.EventHandler(this.cmdReport_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 7;
			this.menuItem5.Text = "-";
			// 
			// cmdRefresh
			// 
			this.cmdRefresh.Index = 8;
			this.cmdRefresh.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.cmdRefresh.Text = "&Сэргээх";
			this.cmdRefresh.Click += new System.EventHandler(this.sendCommand);
			// 
			// cmdSort
			// 
			this.cmdSort.Index = 9;
			this.cmdSort.Shortcut = System.Windows.Forms.Shortcut.F6;
			this.cmdSort.Text = "&Эрэмбэлэх";
			this.cmdSort.Click += new System.EventHandler(this.sendCommand);
			// 
			// menuTools
			// 
			this.menuTools.Index = 3;
			this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.cmdOptions,
																					  this.cmdPermission});
			this.menuTools.MergeOrder = 4;
			this.menuTools.Text = "&Хэрэгсэл";
			// 
			// cmdOptions
			// 
			this.cmdOptions.Index = 0;
			this.cmdOptions.Text = "&Тохиргоо...";
			this.cmdOptions.Click += new System.EventHandler(this.cmdOptions_Click);
			// 
			// cmdPermission
			// 
			this.cmdPermission.Index = 1;
			this.cmdPermission.Text = "&Зөвшөөрөл...";
			this.cmdPermission.Click += new System.EventHandler(this.cmdPermission_Click);
			// 
			// menuWindow
			// 
			this.menuWindow.Index = 4;
			this.menuWindow.MdiList = true;
			this.menuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.cmdCascade,
																					   this.cmdHTile,
																					   this.cmdVTile,
																					   this.cmdArrange});
			this.menuWindow.MergeOrder = 5;
			this.menuWindow.Text = "&Цонх";
			// 
			// cmdCascade
			// 
			this.cmdCascade.Index = 0;
			this.cmdCascade.Text = "&Жагсаах";
			this.cmdCascade.Click += new System.EventHandler(this.cmdCascade_Click);
			// 
			// cmdHTile
			// 
			this.cmdHTile.Index = 1;
			this.cmdHTile.Text = "&Хэвтээ зэрэгцvvлэх";
			this.cmdHTile.Click += new System.EventHandler(this.cmdHTile_Click);
			// 
			// cmdVTile
			// 
			this.cmdVTile.Index = 2;
			this.cmdVTile.Text = "&Босоо зэрэгцvvлэх";
			this.cmdVTile.Click += new System.EventHandler(this.cmdVTile_Click);
			// 
			// cmdArrange
			// 
			this.cmdArrange.Index = 3;
			this.cmdArrange.Text = "&Цэгцлэх";
			this.cmdArrange.Click += new System.EventHandler(this.cmdArrange_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 5;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmdAbout});
			this.menuHelp.MergeOrder = 6;
			this.menuHelp.Text = "&Тусламж";
			// 
			// cmdAbout
			// 
			this.cmdAbout.Index = 0;
			this.cmdAbout.Text = "&Тухай...";
			this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
			// 
			// images
			// 
			this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.images.ImageSize = new System.Drawing.Size(16, 16);
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// toolBar
			// 
			this.toolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.toolNew,
																					   this.toolOpen,
																					   this.toolSave,
																					   this.toolPrint,
																					   this.toolPrintPreview,
																					   this.toolSeparator1,
																					   this.toolCut,
																					   this.toolCopy,
																					   this.toolPaste,
																					   this.toolDelete,
																					   this.toolUndo,
																					   this.toolSeparotor2,
																					   this.toolRefresh,
																					   this.toolWks,
																					   this.toolCustomer,
																					   this.toolQuery,
																					   this.toolImport,
																					   this.toolFind,
																					   this.toolSeparator3,
																					   this.toolGoto,
																					   this.toolMoveFirst,
																					   this.toolMovePrev,
																					   this.toolMoveNext,
																					   this.toolMoveLast,
																					   this.tooSeparotor4});
			this.toolBar.ButtonSize = new System.Drawing.Size(16, 16);
			this.toolBar.DropDownArrows = true;
			this.toolBar.ImageList = this.images;
			this.toolBar.Name = "toolBar";
			this.toolBar.ShowToolTips = true;
			this.toolBar.Size = new System.Drawing.Size(704, 25);
			this.toolBar.TabIndex = 1;
			this.toolBar.Wrappable = false;
			this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
			// 
			// toolNew
			// 
			this.toolNew.ImageIndex = 0;
			this.toolNew.ToolTipText = "Шинэ";
			// 
			// toolOpen
			// 
			this.toolOpen.ImageIndex = 1;
			this.toolOpen.ToolTipText = "Нээх";
			// 
			// toolSave
			// 
			this.toolSave.ImageIndex = 2;
			this.toolSave.ToolTipText = "Хадгалах";
			// 
			// toolPrint
			// 
			this.toolPrint.ImageIndex = 3;
			this.toolPrint.ToolTipText = "Хэвлэх";
			// 
			// toolPrintPreview
			// 
			this.toolPrintPreview.ImageIndex = 4;
			// 
			// toolSeparator1
			// 
			this.toolSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolCut
			// 
			this.toolCut.ImageIndex = 5;
			this.toolCut.ToolTipText = "Зөөх";
			// 
			// toolCopy
			// 
			this.toolCopy.ImageIndex = 6;
			this.toolCopy.ToolTipText = "Хуулах";
			// 
			// toolPaste
			// 
			this.toolPaste.ImageIndex = 7;
			this.toolPaste.ToolTipText = "Оруулах";
			// 
			// toolDelete
			// 
			this.toolDelete.ImageIndex = 8;
			this.toolDelete.ToolTipText = "Устгах";
			// 
			// toolUndo
			// 
			this.toolUndo.ImageIndex = 9;
			this.toolUndo.ToolTipText = "Vйлдлийг буцаах";
			// 
			// toolSeparotor2
			// 
			this.toolSeparotor2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolRefresh
			// 
			this.toolRefresh.ImageIndex = 10;
			this.toolRefresh.ToolTipText = "Сэргээх";
			// 
			// toolWks
			// 
			this.toolWks.ImageIndex = 11;
			this.toolWks.Pushed = true;
			this.toolWks.ToolTipText = "Ажлын самбар";
			// 
			// toolCustomer
			// 
			this.toolCustomer.ImageIndex = 12;
			this.toolCustomer.ToolTipText = "Харицагчид цонх";
			// 
			// toolQuery
			// 
			this.toolQuery.ImageIndex = 13;
			this.toolQuery.ToolTipText = "Асуулгын цонх";
			// 
			// toolImport
			// 
			this.toolImport.ImageIndex = 14;
			this.toolImport.ToolTipText = "Импорт";
			// 
			// toolFind
			// 
			this.toolFind.ImageIndex = 15;
			this.toolFind.ToolTipText = "Хайх";
			// 
			// toolSeparator3
			// 
			this.toolSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolMoveFirst
			// 
			this.toolMoveFirst.ImageIndex = 17;
			this.toolMoveFirst.ToolTipText = "Эхэнд шилжих";
			// 
			// toolMovePrev
			// 
			this.toolMovePrev.ImageIndex = 18;
			this.toolMovePrev.ToolTipText = "Урагш шилжих";
			// 
			// toolMoveNext
			// 
			this.toolMoveNext.ImageIndex = 19;
			this.toolMoveNext.ToolTipText = "Хойш шилжих";
			// 
			// toolMoveLast
			// 
			this.toolMoveLast.ImageIndex = 20;
			this.toolMoveLast.ToolTipText = "Сvvлд шилжих";
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 405);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.statusMain,
																						 this.statusRecord,
																						 this.statusConnect,
																						 this.statusCap,
																						 this.statusNum});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(704, 20);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 2;
			// 
			// statusMain
			// 
			this.statusMain.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusMain.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.statusMain.Width = 529;
			// 
			// statusRecord
			// 
			this.statusRecord.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusRecord.ToolTipText = "Бичлэгийн дугаар";
			this.statusRecord.Width = 80;
			// 
			// statusConnect
			// 
			this.statusConnect.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusConnect.ToolTipText = "Холбогдсон байдал";
			this.statusConnect.Width = 25;
			// 
			// statusCap
			// 
			this.statusCap.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusCap.MinWidth = 35;
			this.statusCap.ToolTipText = "CAPS LOCK";
			this.statusCap.Width = 35;
			// 
			// statusNum
			// 
			this.statusNum.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusNum.MinWidth = 35;
			this.statusNum.ToolTipText = "NUM LOCK";
			this.statusNum.Width = 35;
			// 
			// con
			// 
			this.con.ConnectionString = "data source=uugan;initial catalog=STraF;password=secret;persist security info=Tru" +
				"e;user id=sa;workstation id=UUGAN;packet size=4096";
			// 
			// progress
			// 
			this.progress.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.progress.Location = new System.Drawing.Point(200, 408);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(304, 16);
			this.progress.TabIndex = 7;
			this.progress.Visible = false;
			// 
			// tabWks
			// 
			this.tabWks.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabWks.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.pageSchool,
																				 this.pageRegion,
																				 this.pageOrg});
			this.tabWks.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabWks.Location = new System.Drawing.Point(0, 25);
			this.tabWks.Name = "tabWks";
			this.tabWks.SelectedIndex = 0;
			this.tabWks.Size = new System.Drawing.Size(184, 380);
			this.tabWks.TabIndex = 9;
			// 
			// pageSchool
			// 
			this.pageSchool.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.treeSchool});
			this.pageSchool.Location = new System.Drawing.Point(4, 4);
			this.pageSchool.Name = "pageSchool";
			this.pageSchool.Size = new System.Drawing.Size(176, 354);
			this.pageSchool.TabIndex = 0;
			this.pageSchool.Text = "Сургууль";
			// 
			// treeSchool
			// 
			this.treeSchool.AllowDrop = true;
			this.treeSchool.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeSchool.FullRowSelect = true;
			this.treeSchool.HideSelection = false;
			this.treeSchool.ImageIndex = -1;
			this.treeSchool.LabelEdit = true;
			this.treeSchool.Name = "treeSchool";
			this.treeSchool.SelectedImageIndex = -1;
			this.treeSchool.Size = new System.Drawing.Size(176, 354);
			this.treeSchool.TabIndex = 1;
			this.treeSchool.Tag = "1";
			this.treeSchool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tree_KeyDown);
			this.treeSchool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
			this.treeSchool.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
			this.treeSchool.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
			this.treeSchool.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tree_AfterLabelEdit);
			this.treeSchool.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_DragEnter);
			this.treeSchool.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tree_ItemDrag);
			this.treeSchool.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
			this.treeSchool.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.treeSchool_GiveFeedback);
			// 
			// pageRegion
			// 
			this.pageRegion.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.treeRegion});
			this.pageRegion.Location = new System.Drawing.Point(4, 4);
			this.pageRegion.Name = "pageRegion";
			this.pageRegion.Size = new System.Drawing.Size(176, 354);
			this.pageRegion.TabIndex = 1;
			this.pageRegion.Text = "Аймаг";
			this.pageRegion.Visible = false;
			// 
			// treeRegion
			// 
			this.treeRegion.AllowDrop = true;
			this.treeRegion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeRegion.ImageIndex = -1;
			this.treeRegion.LabelEdit = true;
			this.treeRegion.Name = "treeRegion";
			this.treeRegion.SelectedImageIndex = -1;
			this.treeRegion.Size = new System.Drawing.Size(176, 354);
			this.treeRegion.TabIndex = 0;
			this.treeRegion.Tag = "2";
			this.treeRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tree_KeyDown);
			this.treeRegion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
			this.treeRegion.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
			this.treeRegion.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
			this.treeRegion.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tree_AfterLabelEdit);
			this.treeRegion.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_DragEnter);
			this.treeRegion.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tree_ItemDrag);
			this.treeRegion.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
			// 
			// pageOrg
			// 
			this.pageOrg.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.treeOrg});
			this.pageOrg.Location = new System.Drawing.Point(4, 4);
			this.pageOrg.Name = "pageOrg";
			this.pageOrg.Size = new System.Drawing.Size(176, 354);
			this.pageOrg.TabIndex = 2;
			this.pageOrg.Text = "Байгууллага";
			this.pageOrg.Visible = false;
			// 
			// treeOrg
			// 
			this.treeOrg.AllowDrop = true;
			this.treeOrg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeOrg.ImageIndex = -1;
			this.treeOrg.LabelEdit = true;
			this.treeOrg.Name = "treeOrg";
			this.treeOrg.SelectedImageIndex = -1;
			this.treeOrg.Size = new System.Drawing.Size(176, 354);
			this.treeOrg.TabIndex = 0;
			this.treeOrg.Tag = "3";
			this.treeOrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tree_KeyDown);
			this.treeOrg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
			this.treeOrg.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
			this.treeOrg.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
			this.treeOrg.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tree_AfterLabelEdit);
			this.treeOrg.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_DragEnter);
			this.treeOrg.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tree_ItemDrag);
			this.treeOrg.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
			// 
			// splitterWks
			// 
			this.splitterWks.Location = new System.Drawing.Point(184, 25);
			this.splitterWks.Name = "splitterWks";
			this.splitterWks.Size = new System.Drawing.Size(3, 380);
			this.splitterWks.TabIndex = 10;
			this.splitterWks.TabStop = false;
			// 
			// cmd
			// 
			this.cmd.Connection = this.con;
			// 
			// labelPType
			// 
			this.labelPType.Location = new System.Drawing.Point(520, 5);
			this.labelPType.Name = "labelPType";
			this.labelPType.Size = new System.Drawing.Size(48, 16);
			this.labelPType.TabIndex = 12;
			this.labelPType.Text = "Хэлбэр:";
			// 
			// comboPType
			// 
			this.comboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPType.Items.AddRange(new object[] {
															"Зээл",
															"Буцалтгvй",
															"Гуравдагч",
															"ТАХ",
															"Малчны",
															"Ядуу өрхийн",
															"Шагнал",
															"Гадаад",
															"ТАХ Улаанбаатар"});
			this.comboPType.Location = new System.Drawing.Point(568, 2);
			this.comboPType.Name = "comboPType";
			this.comboPType.Size = new System.Drawing.Size(121, 21);
			this.comboPType.TabIndex = 13;
			this.comboPType.SelectedIndexChanged += new System.EventHandler(this.comboPType_SelectedIndexChanged);
			// 
			// toolGoto
			// 
			this.toolGoto.ImageIndex = 16;
			this.toolGoto.ToolTipText = "Байрлалд шилжих";
			// 
			// tooSeparotor4
			// 
			this.tooSeparotor4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// Straf
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 425);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboPType,
																		  this.labelPType,
																		  this.splitterWks,
																		  this.tabWks,
																		  this.progress,
																		  this.statusBar,
																		  this.toolBar});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.menuMain;
			this.Name = "Straf";
			this.Text = "STraF Програм";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Straf_Closing);
			((System.ComponentModel.ISupportInitialize)(this.statusMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusRecord)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusConnect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusCap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusNum)).EndInit();
			this.tabWks.ResumeLayout(false);
			this.pageSchool.ResumeLayout(false);
			this.pageRegion.ResumeLayout(false);
			this.pageOrg.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Straf());
		}

		private void DBInit() {
			foreach (string ptype in Student.types)
				permissions.Add(ptype, 1);
			LoadPermissions();
		}
		private void  LoadPermissions() {
			cmd.CommandText = "select * from get_permissions()";
			using (System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader()) {
				while (reader.Read()) {
					permissions.Add(reader.GetString(0), reader.GetInt32(1));
				}
			}
		}
		private void  Straf_OnExit(object sender, System.EventArgs e) {
			if (!optSaved)
				serializeOption(false);
			serializeWks(treeSchool, wksFileSchool, false);
			serializeWks(treeRegion, wksFileRegion, false);
			serializeWks(treeOrg, wksFileOrg, false);
		}
		private void  Straf_Idle(object sender, System.EventArgs e) {
			if (logged)
				statusConnect.Text = "-+-";
			else
				statusConnect.Text = "- -";
			if ((Win32.GetKeyState((int)Keys.Capital) & 1) == 1)
				statusCap.Text = "CAP";
			else
				statusCap.Text = "";
			if ((Win32.GetKeyState((int)Keys.NumLock) & 1) == 1)
				statusNum.Text = "NUM";
			else
				statusNum.Text = "";
		}
		private void cmdExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}
		private void Straf_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			opt.mainState = (int)this.WindowState;
			if (ActiveMdiChild != null)
				opt.childState = (int) ActiveMdiChild.WindowState;
		}
		private void  sendKey(int key) {
			if (ActiveControl != null) {
				Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, key, 1);
			}
		}
		private void  sendCommand(object source, EventArgs e) {
			sendKey((int) ((MenuItem) source).Shortcut);
		}

		public static void ShowError(string error) {
			MessageBox.Show(error, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void cmdCascade_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.Cascade);
		}

		private void cmdHTile_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void cmdVTile_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void cmdArrange_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void cmdAbout_Click(object sender, System.EventArgs e) {
			AboutDlg dlg = new AboutDlg();
			dlg.ShowDialog();
		}

		private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			if (e.Button == toolNew)
				sendKey((int) Keys.Control | (int) Keys.N);
			else if (e.Button == toolOpen)
				sendKey((int) Keys.Control | (int) Keys.O);
			else if (e.Button == toolSave)
				sendKey((int) Keys.Control | (int) Keys.S);
			else if (e.Button == toolCut)
				sendKey((int) Keys.Control | (int) Keys.X);
			else if (e.Button == toolCopy)
				sendKey((int) Keys.Control | (int) Keys.C);
			else if (e.Button == toolPaste)
				sendKey((int) Keys.Control | (int) Keys.V);
			else if (e.Button == toolDelete)
				sendKey((int) Keys.Delete);
			else if (e.Button == toolUndo)
				sendKey((int) Keys.Control | (int) Keys.Z);
			else if (e.Button == toolPrint)
				sendKey((int) Keys.Control | (int) Keys.P);
			else if (e.Button == toolPrintPreview)
				cmdPrintPreview_Click(sender, e);
			else if (e.Button == toolWks)
				showWks(!toolWks.Pushed);
			else if (e.Button == toolCustomer)
				cmdCustomer_Click(sender, e);
			else if (e.Button == toolQuery)
				cmdQuery_Click(sender, e);
			else if (e.Button == toolImport)
				cmdImport_Click(sender, e);
			else if (e.Button == toolRefresh)
				sendKey((int) Keys.F5);
			else if (e.Button == toolFind)
				cmdFind_Click(sender, e);
			else if (e.Button == toolMoveFirst)
				sendKey((int) Keys.Alt | (int) Keys.Left);
			else if (e.Button == toolMovePrev)
				sendKey((int) Keys.Alt | (int) Keys.Up);
			else if (e.Button == toolMoveNext)
				sendKey((int) Keys.Alt | (int) Keys.Down);
			else if (e.Button == toolMoveLast)
				sendKey((int) Keys.Alt | (int) Keys.Right);
		}
		private void cmdWks_Click(object sender, System.EventArgs e) {
			showWks(!cmdWks.Checked);
		}
		private void  showWks(bool b) {
			splitterWks.Visible = b;
			tabWks.Visible = b;
			toolWks.Pushed = b;
			cmdWks.Checked = b;
		}
		private void cmdStatus_Click(object sender, System.EventArgs e) {
			statusBar.Visible = !cmdStatus.Checked;
			cmdStatus.Checked = !cmdStatus.Checked;
		}

		private void cmdToolbar_Click(object sender, System.EventArgs e) {
			labelPType.Visible = !cmdToolbar.Checked;
			comboPType.Visible = !cmdToolbar.Checked;
			toolBar.Visible = !cmdToolbar.Checked;
			cmdToolbar.Checked = !cmdToolbar.Checked;			
		}
		private void cmdClose_Click(object sender, System.EventArgs e) {
			if (ActiveMdiChild != null)
				ActiveMdiChild.Close();
		}

		private void cmdCloseAll_Click(object sender, System.EventArgs e) {
			foreach (Form kid in MdiChildren)
				kid.Close();
		}

		private void cmdConnect_Click(object sender, System.EventArgs e) {
			statusMain.Text = "Холбож байна...";
			this.Cursor = Cursors.WaitCursor;
			
			if (opt.server != "" && opt.uid !=  "") {
				strCon = string.Format("persist security info=True;initial catalog=STraF;packet size=4096;data source={0};workstation id={0};user id={1};password={2};", opt.server, opt.uid, opt.pwd);
				con.ConnectionString = strCon;
				try {
					con.Open();
					if (con.State == ConnectionState.Open)
						logged = true;
				}
				catch (Exception) {
					logged = false;
				}
			}
		
			if (!logged) {
				LoginDlg dlg = new LoginDlg();
				DialogResult result;
				int counter = 0;
				do {
					dlg.textPassword.Text = opt.pwd;
					dlg.textUser.Text = opt.uid;
					dlg.textServer.Text = opt.server;
					dlg.textChanged(null, null);
					result = dlg.ShowDialog();
					if (result == DialogResult.OK) {
						strCon = string.Format("persist security info=True;initial catalog=STraF;packet size=4096;data source={0};workstation id={0};user id={1};password={2};", dlg.textServer.Text, dlg.textUser.Text, dlg.textPassword.Text);
						con.ConnectionString = strCon;
						try {
							con.Open();
							if (con.State == ConnectionState.Open) {
								opt.server = dlg.textServer.Text;
								opt.uid = dlg.textUser.Text;
								if (dlg.checkPassRemember.Checked)
									opt.pwd = dlg.textPassword.Text;
								else
									opt.pwd = "";
								optSaved = false;
								logged = true;
							}
						}
						catch (Exception) {
							logged = false;
						}
						counter++;
					}
				}
				while (!logged && result != DialogResult.Cancel && counter < 3);
			}
			if (logged) {
				cmdConnect.Enabled = false;
				enableCommands(true);
			}
			else  {
				cmdConnect.Enabled = true;
				enableCommands(false);
			}
			statusMain.Text = "";
			this.Cursor = Cursors.Default;
		}		
		private void  enableCommands(bool b) {
			foreach (MenuItem cmd in dbCommands)
				cmd.Enabled = b;
			foreach (ToolBarButton button in dbTools)
				button.Enabled = b;
		}

		private void cmdOptions_Click(object sender, System.EventArgs e) {
			OptionDlg dlg = new OptionDlg();
			dlg.textUser.Text = opt.uid;
			dlg.textPwd.Text = opt.pwd;
			dlg.ShowDialog();
		}
		
		private void  serializeWks(TreeView tree, string filename, bool read) {
			FileStream file = null;
            if (read) {
				try {
					file = File.OpenRead(filename);
					BinaryReader reader;
					reader = new BinaryReader(file);
					while (file.Position < file.Length) {
						TreeNode node = LoadNode(reader);
						if (node != null)
							tree.Nodes.Add(node);
					}
				}
				catch (Exception) {
					File.Create(filename);
				}
				finally {
					if (file != null)
						file.Close();
				}
			}
			else {
				try {
					file = File.OpenWrite(filename);
					BinaryWriter writer;
					writer = new BinaryWriter(file);
					foreach (TreeNode node in tree.Nodes) {
						SaveNode(node, writer);
					}
				}
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
				finally {
					if (file != null)
						file.Close();
				}
			}
		}
		private TreeNode LoadNode(BinaryReader bin) {
			TreeNode node = null;
			try {
				node = new TreeNode();
				node.Text = bin.ReadString();
				node.Tag = bin.ReadInt32();
				int childCount = bin.ReadInt32();
				int i = 0;
				while (i++ < childCount) {
					TreeNode n = LoadNode(bin);
					if (n != null)
						node.Nodes.Add(n);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				node = null;
			}
			return node;
		}
		private void SaveNode(TreeNode node, BinaryWriter bout) {
			try {
				bout.Write(node.Text);
				bout.Write((int)node.Tag);
				bout.Write(node.GetNodeCount(false));
				foreach (TreeNode n in node.Nodes) {
					SaveNode(n, bout);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		private void  serializeOption(bool read) {
			if (read) {
				try {
					Microsoft.Win32.RegistryKey keySettings = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\EIMS\\STraF\\Settings");
					opt.server = (string)keySettings.GetValue("Server");
					opt.uid = (string)keySettings.GetValue("Uid");
					opt.pwd = (string)keySettings.GetValue("Pwd");
					opt.mainState = (int)keySettings.GetValue("MainState");
					opt.childState = (int)keySettings.GetValue("ChildState");
					opt.findX = (int)keySettings.GetValue("FindX");
					opt.findY = (int)keySettings.GetValue("FindY");
				} 
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
			}
			else {
				try {
					Microsoft.Win32.RegistryKey keySettings = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\EIMS\\STraF\\Settings", true);
					if (keySettings == null) {
						keySettings = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\EIMS\\STraF\\Settings");
					}
					keySettings.SetValue("Server", opt.server);
					keySettings.SetValue("Uid", opt.uid);
					keySettings.SetValue("Pwd", opt.pwd);
					keySettings.SetValue("MainState", opt.mainState);
					keySettings.SetValue("ChildState", opt.childState);
					keySettings.SetValue("FindX", opt.findX);
					keySettings.SetValue("FindY", opt.findY);
					optSaved = true;
				}
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
			}
		}
		private void cmdFind_Click(object sender, System.EventArgs e) {
			if (formFind == null || !formFind.Visible) {
				formFind = new FindDlg(this);
				formFind.Location = new Point(opt.findX, opt.findY);
				formFind.Show();
			}
			else
				formFind.Select();
		}

		private void cmdCustomer_Click(object sender, System.EventArgs e) {
			if (formCustomer == null || !formCustomer.Visible) {
				formCustomer = new Customer();
				formCustomer.WindowState = (FormWindowState) opt.childState;
				formCustomer.MdiParent = this;
				formCustomer.Show();
			}
			else
				formCustomer.Select();
		}
		private void cmdSummary_Click(object sender, System.EventArgs e) {
			if (formSummary == null || !formSummary.Visible) {
				formSummary = new SummaryView();
				formSummary.WindowState = (FormWindowState) opt.childState;
				formSummary.MdiParent = this;
				formSummary.Show();
			}
			else
				formSummary.Select();
		}
		private void cmdQuery_Click(object sender, System.EventArgs e) {
			if (formQuery == null || !formQuery.Visible) {
				formQuery = new QueryView();
				formQuery.WindowState = (FormWindowState) opt.childState;
				formQuery.MdiParent = this;
				formQuery.Show();
			}
			else
				formQuery.Select();
		}
		public void cmdReport_Click(object sender, System.EventArgs e) {
			if (formReport == null || !formReport.Visible) {
				formReport = new ReportView();
				formReport.WindowState = (FormWindowState) opt.childState;
				formReport.MdiParent = this;
				formReport.Show();
			}
			else
				formReport.Select();
		}
		private void cmdPrintPreview_Click(object sender, System.EventArgs e) {
			IStrafChild child = this.ActiveMdiChild as IStrafChild;
			if (child != null) {
				cmdReport_Click(null, null);
				formReport.SetDocument(child.GetReportDocument());
			}
		}
		private void cmdImport_Click(object sender, System.EventArgs e) {
			ImportDlg dlg = new ImportDlg(-1, -1);
			dlg.ShowDialog();
			/*
			Node n = (Node) treeSchool.SelectedNode;
			int school = - 1;
			byte type = - 1;
			if (n != null) {
				school = (int) n.getFilterValue("school");
				type = (byte) n.getFilterValue("ptype");
			}
			Importer imp = new Importer(school, type);
			imp.Start();
			*/
		}
		private void tree_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case  Keys.Control | Keys.N: 
					NewNode(sender, e);
					break;

				case Keys.Return: 
					OpenNode(sender, e);
					break;
			
				case  Keys.Control | Keys.C: 
					CopyNode(sender, e);
					break;
			
				case  Keys.Control | Keys.X: 
					CutNode(sender, e);
					break;
			
				case  Keys.Control | Keys.V: 
					PasteNode(sender, e);
					break;
			
				case  Keys.Delete: 
					DeleteNode(sender, e);
					break;
			
				case  Keys.F5: 
					break;
			
				case  Keys.F6: 
					SortNode(sender, e);
					break;
			
				case  Keys.F2: 
					RenameNode(sender, e);
					break;
			
				case  Keys.Escape: 
					UnselectNode(sender, e);
					break;
			
				default:
					string c = Keys.GetName(new Keys().GetType(),  e.KeyCode);
					FindNode(sender, c);
					break;
			}
		}
		private void NewNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				TreeNode selNode = tree.SelectedNode;
				TreeNode newNode = new TreeNode("unnamed");
				newNode.Tag = -1;
				if (selNode != null)
					selNode.Nodes.Add(newNode);
				else
					tree.Nodes.Add(newNode);
				tree.SelectedNode = newNode;
				tree.Sorted = false;
			}
		}
		private void OpenNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;
			
			TreeNode selNode = tree.SelectedNode;
			if (selNode != null) {
				int tag = (int)tree.Tag;
				int sel = (int)selNode.Tag;
				if (sel != -1) {
					switch (tag) {
						case 1 : OpenStudentBySchool(sel); break;
						case 2 : OpenStudentByRegion(sel); break;
						case 3 : OpenStudentByOrg(sel); break;
					}
				}
			}
		}
		private void tree_DoubleClick(object sender, System.EventArgs e) {
			OpenNode(sender, e);
		}
		
		private void OpenStudentBySchool(int school) {
			IStudentChild child = this.ActiveMdiChild as IStudentChild;
			if (child != null) {
				child.ChangeSchool(school);
			}
		}
		private void OpenStudentByRegion(int region) {
			IStudentChild child = this.ActiveMdiChild as IStudentChild;
			if (child != null) {
				child.ChangeRegion(region);
			}
		}
		private void OpenStudentByOrg(int org) {
			IStudentChild child = this.ActiveMdiChild as IStudentChild;
			if (child != null) {
				child.ChangeOrg(org);
			}
		}
		private void RenameNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				if (tree.SelectedNode != null)
					tree.SelectedNode.BeginEdit();
			}
		}
		private void CopyNode(object sender, EventArgs e) {
		}
		private void CutNode(object sender, EventArgs e) {
		}
		private void PasteNode(object sender, EventArgs e) {
		}
		private void FindNode(object sender, string text) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				TreeNode node = tree.SelectedNode;
				while (node != null && !node.Text.StartsWith(text))
					node = node.NextVisibleNode;
				if (node != null)
					tree.SelectedNode = node;
			}
		}
		private void DeleteNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				if (tree.SelectedNode != null) {
					if (MessageBox.Show("Устгах уу ?", Straf.appName, MessageBoxButtons.YesNo) == DialogResult.Yes)
						tree.SelectedNode.Remove();
				}
			}
		}
		private void SortNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				tree.Sorted = true;
				tree.Refresh();
			}
		}
		private void UnselectNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				tree.SelectedNode = null;
			}
		}
		private void tree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
			/*
			TreeView tree = sender as TreeView;
			if (tree != null) {
				if (formStudent != null && formStudent.Visible)
					formStudent.Text = e.Node.FullPath;
				e.Node.EndEdit(false);
				tree.Sorted = false;
			}
			*/
		}
		private void tree_MouseDown(object sender, MouseEventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null) {
				if (e.Button == MouseButtons.Right)
					tree.SelectedNode = tree.GetNodeAt(e.X, e.Y);
			}
		}
		private void tree_AfterSelect(object sender, TreeViewEventArgs e) {
			/*
			TreeView tree = sender as TreeView;
			if (tree != null) {
				if (formStudent != null && formStudent.Visible)
					formStudent.Text = e.Node.FullPath;
			}
			*/
		}

		private void cmdPermission_Click(object sender, System.EventArgs e) {
			PermissionDlg dlg = new PermissionDlg();
			foreach (string obj in permissions.Keys) {
				ListViewItem item = new ListViewItem();
				item.Text = obj;
				int val = (int)permissions[obj];
				item.SubItems.Add(((val & 1) == 1) ? "+" : "-");
				item.SubItems.Add(((val & 2) == 2) ? "+" : "-");
				item.SubItems.Add(((val & 8) == 8) ? "+" : "-");
				item.SubItems.Add(((val & 16) == 16) ? "+" : "-");
				dlg.listPermission.Items.Add(item);
			}
			dlg.ShowDialog();
		}
		private void comboPType_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch (comboPType.SelectedIndex) {
				case 0 : OpenLoan(); break;
				case 1 : OpenHelp(); break;
				case 2 : OpenThird(); break;
				case 3 : OpenTax(); break;
				case 4 : OpenHerder(); break;
				case 5 : OpenPoor(); break;
				case 6 : OpenPrize(); break;
				case 7 : OpenForeign(); break;
				case 8 : OpenTaxUB(); break;
			}
		}
		private void OpenLoan() {
			int pm = (int)permissions["loan"];
			if ((pm & 1) != 1)
				return;
			if (formLoan== null || !formLoan.Visible) {
				formLoan = new PoorView(false);
				formLoan.WindowState = (FormWindowState) opt.childState;
				formLoan.MdiParent = this;
				formLoan.Show();
			}
			else
				formLoan.Select();
		}
		private void OpenHelp() {
			int pm = (int)permissions["help"];
			if ((pm & 1) != 1)
				return;
			if (formHelp== null || !formHelp.Visible) {
				formHelp = new HelpView();
				formHelp.WindowState = (FormWindowState) opt.childState;
				formHelp.MdiParent = this;
				formHelp.Show();
			}
			else
				formHelp.Select();
		}
		private void OpenThird() {
			int pm = (int)permissions["third"];
			if ((pm & 1) != 1)
				return;
			if (formThird== null || !formThird.Visible) {
				formThird = new ThirdView();
				formThird.WindowState = (FormWindowState) opt.childState;
				formThird.MdiParent = this;
				formThird.Show();
			}
			else
				formThird.Select();
		}
		private void OpenTax() {
			int pm = (int)permissions["tax"];
			if ((pm & 1) != 1)
				return;
			if (formTax== null || !formTax.Visible) {
				formTax = new TaxView();
				formTax.WindowState = (FormWindowState) opt.childState;
				formTax.MdiParent = this;
				formTax.Show();
			}
			else
				formTax.Select();
		}
		private void OpenTaxUB() {
			int pm = (int)permissions["taxub"];
			if ((pm & 1) != 1)
				return;
			if (formTaxUB == null || !formTaxUB.Visible) {
				formTaxUB = new TaxUBView();
				formTaxUB.WindowState = (FormWindowState) opt.childState;
				formTaxUB.MdiParent = this;
				formTaxUB.Show();
			}
			else
				formTaxUB.Select();
		}
		private void OpenHerder() {
			int pm = (int)permissions["herder"];
			if ((pm & 1) != 1)
				return;
			if (formHerder== null || !formHerder.Visible) {
				formHerder = new HerderView();
				formHerder.WindowState = (FormWindowState) opt.childState;
				formHerder.MdiParent = this;
				formHerder.Show();
			}
			else
				formHerder.Select();
		}
		private void OpenPoor() {
			int pm = (int)permissions["poor"];
			if ((pm & 1) != 1)
				return;
			if (formPoor== null || !formPoor.Visible) {
				formPoor = new PoorView(true);
				formPoor.WindowState = (FormWindowState) opt.childState;
				formPoor.MdiParent = this;
				formPoor.Show();
			}
			else
				formPoor.Select();
		}
		private void OpenPrize() {
			int pm = (int)permissions["prize"];
			if ((pm & 1) != 1)
				return;
			if (formPrize== null || !formPrize.Visible) {
				formPrize = new PrizeView();
				formPrize.WindowState = (FormWindowState) opt.childState;
				formPrize.MdiParent = this;
				formPrize.Show();
			}
			else
				formPrize.Select();
		}
		private void OpenForeign() {
			int pm = (int)permissions["foreign"];
			if ((pm & 1) != 1)
				return;
			if (formForeign== null || !formForeign.Visible) {
				formForeign = new ForeignView();
				formForeign.WindowState = (FormWindowState) opt.childState;
				formForeign.MdiParent = this;
				formForeign.Show();
			}
			else
				formForeign.Select();
		}
		private void treeSchool_GiveFeedback(object sender, System.Windows.Forms.GiveFeedbackEventArgs e) {
			
		}

		private void tree_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null)
				tree.DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);
		}
		private void tree_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
			if (e.Data.GetDataPresent(typeof(TreeNode))) 
				e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
			else if (e.Data.GetDataPresent(DataFormats.Text)) 
				e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}
		private void tree_DragDrop(object sender, DragEventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			if (e.Data.GetDataPresent(typeof(TreeNode))) {
				TreeNode dropNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
				TreeNode selNode = tree.GetNodeAt(tree.PointToClient(new Point(e.X, e.Y)));
				if (dropNode != selNode) {
					TreeNode newNode = (TreeNode)dropNode.Clone();
					dropNode.Remove();
					if (selNode == null)
						tree.Nodes.Add(newNode);
					else
						selNode.Nodes.Add(newNode);
				}
			}
			else if (e.Data.GetDataPresent(DataFormats.Text)) {
				string dropText = (string)e.Data.GetData(DataFormats.Text);
				string[] lines = dropText.Split(new Char[] {'\n'});
				ArrayList nodes = new ArrayList();
				for (int i=0; i<lines.Length;i++) {
					string line = lines[i].Trim(new Char[]{'\r'});
					if (line != "") {
						string[] words = line.Split(new Char[] {'\t'}, 3);
						if (words.Length >= 2) {
							TreeNode newNode = new TreeNode();
							try {
								newNode.Tag = Convert.ToInt32(words[0]);
							}
							catch (Exception) {
								newNode.Tag = -1;
							}
							newNode.Text = words[1];
							nodes.Add(newNode);
						}
					}
				}
				TreeNode selNode = tree.GetNodeAt(tree.PointToClient(new Point(e.X, e.Y)));
				if (selNode != null) {
					System.Collections.IEnumerator enumerator = nodes.GetEnumerator();
					while ( enumerator.MoveNext() )
						selNode.Nodes.Add((TreeNode)enumerator.Current);
				}
				else {
					System.Collections.IEnumerator enumerator = nodes.GetEnumerator();
					while ( enumerator.MoveNext() )
						tree.Nodes.Add((TreeNode)enumerator.Current);
				}
			}
		}
	}
}

