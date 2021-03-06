using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.OleDb;

namespace STraF_U {
	/// <summary>
	/// STraF Main Form
	/// </summary>
	public class Straf : Form {

		#region Програмын хувьсагчид
		public const string appName = "STraF_U Програм";
		public static string strCon;
		public static bool logged;
		private int toolFlag;
		private int cmdFlag;
		private MenuItem[] cmds;
		public struct Setting {
			public string school;
			public int level;
			public int hold;
			public string help;

			public string database;
			public string uid;
			public string pwd;

			public int mainState;
			public int childState;
			public int findX, findY;
		}

		public static Setting opt;
		private bool optSaved;
		private bool wksSaved;
		private string wksFile;
		
		private FindDlg formFind;
		private ProfView formProf;
		private SummaryView formSummary;
		private QueryView formQuery;
		private ReportView formReport;
		private Form[] studentForms;
		
		private MainMenu menuMain;
		private MenuItem menuFile;
		public MenuItem cmdConnect;
		private MenuItem sep1;
		public MenuItem cmdNew;
		public MenuItem cmdOpen;
		public MenuItem cmdSave;
		private MenuItem cmdClose;
		private MenuItem cmdCloseAll;
		public MenuItem cmdPrint;
		private MenuItem cmdExit;
		private MenuItem menuEdit;
		public MenuItem cmdCut;
		public MenuItem cmdCopy;
		public MenuItem cmdPaste;
		public MenuItem cmdDelete;
		public MenuItem cmdSelectAll;
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
		public ToolBarButton toolFind;
		private StatusBar statusBar;
		public StatusBarPanel statusMain;
		public StatusBarPanel statusRecord;
		public StatusBarPanel statusCap;
		public StatusBarPanel statusNum;
		private ProgressBar progress;
		private TabControl tabWks;
		private Splitter splitterWks;
		public ToolBarButton toolSeparator1;
		public ToolBarButton toolSeparotor2;
		private ToolBarButton toolQuery;
		private MenuItem cmdQuery;
		private ToolBarButton toolUndo;
		private MenuItem cmdUndo;
		private MenuItem cmdPrintPreview;
		private ToolBarButton toolPrintPreview;
		private MenuItem cmdReport;
		private Label labelPType;
		private ComboBox comboPType;
		private ToolBarButton toolMoveFirst;
		private ToolBarButton toolMovePrev;
		private ToolBarButton toolMoveNext;
		private ToolBarButton toolMoveLast;
		private ToolBarButton toolSeparator3;
		private TabPage pageClass;
		private OleDbConnection con;
		private MenuItem cmdHelp;
		private ToolBarButton toolSeparator4;
		private ToolBarButton toolGoTo;
		private ToolBarButton toolProf;
		private MenuItem cmdProf;
		private PrintDialog printDlg;
		private MenuItem cmdGoto;
		private ContextMenu contextWks;
		private MenuItem cmdPopSort;
		private MenuItem cmdPopNew;
		private MenuItem cmdPopDelete;
		private MenuItem menuItem8;
		private OleDbDataAdapter daProf;
		private OleDbDataAdapter daRegion;
		private TreeView treeProf;
		public static STraF_U.DatasetGlobal datasetGlobal;
		private HelpProvider help;
		private MenuItem cmdClear;
		private MenuItem sep2;
		private MenuItem sep3;
		private MenuItem sep4;
		private MenuItem sep6;
		private MenuItem sep5;
		private OleDbCommand oleDbSelectCommand1;
		private OleDbCommand oleDbInsertCommand1;
		private OleDbCommand oleDbUpdateCommand1;
		private OleDbCommand oleDbDeleteCommand1;
		private OleDbCommand oleDbSelectCommand2;
		private OleDbCommand oleDbInsertCommand2;
		private OleDbCommand oleDbUpdateCommand2;
		private OleDbCommand oleDbDeleteCommand2;
		private MenuItem cmdSummary;
		private System.ComponentModel.IContainer components;
		#endregion

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

			studentForms = new Form[] {null, null, null, null, null, null};
			cmds = new MenuItem[] {cmdNew, cmdOpen, cmdSave, cmdPrint};

			// settings
			opt.school = "";
			opt.level = 0;
			opt.hold = 0;
			opt.database = "data.mdb";
			opt.uid = "Admin";
			opt.pwd = "";
			opt.mainState = (int) FormWindowState.Maximized;
			opt.childState = (int) FormWindowState.Normal;
			opt.findX = 500;
			opt.findY = 500;
			opt.help = "help.chm";

			strCon = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Password={2};User ID={1};Data Source={0};", opt.database, opt.uid, opt.pwd);
			
			// datasetGlobal
			datasetGlobal = new STraF_U.DatasetGlobal();
			
			wksFile = "prof.wks";
			Text = appName;
			
			Show();
			Update();

			progress.Show();
			SerializeOption(true);

			help.HelpNamespace = opt.help;
			help.SetShowHelp(this, true);

			progress.Value = 30;
			if (Connect())	{
				progress.Value = 70;
				SerializeWks(treeProf, wksFile, true);
				treeProf.Select();
				progress.Value = 100;
			}
			progress.Hide();
			this.WindowState = (FormWindowState) opt.mainState;
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
			this.cmdClose = new System.Windows.Forms.MenuItem();
			this.cmdCloseAll = new System.Windows.Forms.MenuItem();
			this.sep2 = new System.Windows.Forms.MenuItem();
			this.cmdPrint = new System.Windows.Forms.MenuItem();
			this.cmdPrintPreview = new System.Windows.Forms.MenuItem();
			this.sep3 = new System.Windows.Forms.MenuItem();
			this.cmdExit = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.cmdUndo = new System.Windows.Forms.MenuItem();
			this.sep4 = new System.Windows.Forms.MenuItem();
			this.cmdCut = new System.Windows.Forms.MenuItem();
			this.cmdCopy = new System.Windows.Forms.MenuItem();
			this.cmdPaste = new System.Windows.Forms.MenuItem();
			this.sep5 = new System.Windows.Forms.MenuItem();
			this.cmdDelete = new System.Windows.Forms.MenuItem();
			this.cmdClear = new System.Windows.Forms.MenuItem();
			this.cmdSelectAll = new System.Windows.Forms.MenuItem();
			this.sep6 = new System.Windows.Forms.MenuItem();
			this.cmdFind = new System.Windows.Forms.MenuItem();
			this.cmdGoto = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.cmdToolbar = new System.Windows.Forms.MenuItem();
			this.cmdStatus = new System.Windows.Forms.MenuItem();
			this.cmdWks = new System.Windows.Forms.MenuItem();
			this.cmdProf = new System.Windows.Forms.MenuItem();
			this.cmdSummary = new System.Windows.Forms.MenuItem();
			this.cmdQuery = new System.Windows.Forms.MenuItem();
			this.cmdReport = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.cmdRefresh = new System.Windows.Forms.MenuItem();
			this.cmdSort = new System.Windows.Forms.MenuItem();
			this.menuTools = new System.Windows.Forms.MenuItem();
			this.cmdOptions = new System.Windows.Forms.MenuItem();
			this.menuWindow = new System.Windows.Forms.MenuItem();
			this.cmdCascade = new System.Windows.Forms.MenuItem();
			this.cmdHTile = new System.Windows.Forms.MenuItem();
			this.cmdVTile = new System.Windows.Forms.MenuItem();
			this.cmdArrange = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.cmdHelp = new System.Windows.Forms.MenuItem();
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
			this.toolProf = new System.Windows.Forms.ToolBarButton();
			this.toolQuery = new System.Windows.Forms.ToolBarButton();
			this.toolFind = new System.Windows.Forms.ToolBarButton();
			this.toolSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.toolGoTo = new System.Windows.Forms.ToolBarButton();
			this.toolMoveFirst = new System.Windows.Forms.ToolBarButton();
			this.toolMovePrev = new System.Windows.Forms.ToolBarButton();
			this.toolMoveNext = new System.Windows.Forms.ToolBarButton();
			this.toolMoveLast = new System.Windows.Forms.ToolBarButton();
			this.toolSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusMain = new System.Windows.Forms.StatusBarPanel();
			this.statusRecord = new System.Windows.Forms.StatusBarPanel();
			this.statusCap = new System.Windows.Forms.StatusBarPanel();
			this.statusNum = new System.Windows.Forms.StatusBarPanel();
			this.progress = new System.Windows.Forms.ProgressBar();
			this.tabWks = new System.Windows.Forms.TabControl();
			this.pageClass = new System.Windows.Forms.TabPage();
			this.treeProf = new System.Windows.Forms.TreeView();
			this.contextWks = new System.Windows.Forms.ContextMenu();
			this.cmdPopNew = new System.Windows.Forms.MenuItem();
			this.cmdPopDelete = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.cmdPopSort = new System.Windows.Forms.MenuItem();
			this.splitterWks = new System.Windows.Forms.Splitter();
			this.labelPType = new System.Windows.Forms.Label();
			this.comboPType = new System.Windows.Forms.ComboBox();
			this.con = new System.Data.OleDb.OleDbConnection();
			this.printDlg = new System.Windows.Forms.PrintDialog();
			this.daProf = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.daRegion = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.help = new System.Windows.Forms.HelpProvider();
			((System.ComponentModel.ISupportInitialize)(this.statusMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusRecord)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusCap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusNum)).BeginInit();
			this.tabWks.SuspendLayout();
			this.pageClass.SuspendLayout();
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
																					 this.cmdClose,
																					 this.cmdCloseAll,
																					 this.sep2,
																					 this.cmdPrint,
																					 this.cmdPrintPreview,
																					 this.sep3,
																					 this.cmdExit});
			this.menuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuFile.Text = "&Файл";
			// 
			// cmdConnect
			// 
			this.cmdConnect.Index = 0;
			this.cmdConnect.Text = "&Бааз холбох...";
			this.cmdConnect.Click += new System.EventHandler(this.OpenDatabase);
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
			this.cmdNew.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdOpen
			// 
			this.cmdOpen.Index = 3;
			this.cmdOpen.MergeOrder = 4;
			this.cmdOpen.MergeType = System.Windows.Forms.MenuMerge.Replace;
			this.cmdOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.cmdOpen.Text = "&Нээх";
			this.cmdOpen.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdSave
			// 
			this.cmdSave.Index = 4;
			this.cmdSave.MergeOrder = 5;
			this.cmdSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.cmdSave.Text = "Ха&дгалах";
			this.cmdSave.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdClose
			// 
			this.cmdClose.Index = 5;
			this.cmdClose.MergeOrder = 7;
			this.cmdClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
			this.cmdClose.Text = "Х&аах";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdCloseAll
			// 
			this.cmdCloseAll.Index = 6;
			this.cmdCloseAll.MergeOrder = 8;
			this.cmdCloseAll.Text = "Б&үгдийг хаах";
			this.cmdCloseAll.Click += new System.EventHandler(this.cmdCloseAll_Click);
			// 
			// sep2
			// 
			this.sep2.Index = 7;
			this.sep2.MergeOrder = 9;
			this.sep2.Text = "-";
			// 
			// cmdPrint
			// 
			this.cmdPrint.Index = 8;
			this.cmdPrint.MergeOrder = 12;
			this.cmdPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.cmdPrint.Text = "&Хэвлэх...";
			this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
			// 
			// cmdPrintPreview
			// 
			this.cmdPrintPreview.Index = 9;
			this.cmdPrintPreview.MergeOrder = 13;
			this.cmdPrintPreview.Text = "Хэвлэхийн өмнө харах";
			this.cmdPrintPreview.Click += new System.EventHandler(this.cmdPrintPreview_Click);
			// 
			// sep3
			// 
			this.sep3.Index = 10;
			this.sep3.MergeOrder = 14;
			this.sep3.Text = "-";
			// 
			// cmdExit
			// 
			this.cmdExit.Index = 11;
			this.cmdExit.MergeOrder = 15;
			this.cmdExit.Text = "&Гарах";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmdUndo,
																					 this.sep4,
																					 this.cmdCut,
																					 this.cmdCopy,
																					 this.cmdPaste,
																					 this.sep5,
																					 this.cmdDelete,
																					 this.cmdClear,
																					 this.cmdSelectAll,
																					 this.sep6,
																					 this.cmdFind,
																					 this.cmdGoto});
			this.menuEdit.MergeOrder = 1;
			this.menuEdit.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuEdit.Text = "&Засах";
			// 
			// cmdUndo
			// 
			this.cmdUndo.Index = 0;
			this.cmdUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.cmdUndo.Text = "Үйл&длийг буцаах";
			this.cmdUndo.Click += new System.EventHandler(this.SendCommand);
			// 
			// sep4
			// 
			this.sep4.Index = 1;
			this.sep4.Text = "-";
			// 
			// cmdCut
			// 
			this.cmdCut.Index = 2;
			this.cmdCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.cmdCut.Text = "&Зөөх";
			this.cmdCut.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdCopy
			// 
			this.cmdCopy.Index = 3;
			this.cmdCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.cmdCopy.Text = "&Хуулах";
			this.cmdCopy.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdPaste
			// 
			this.cmdPaste.Index = 4;
			this.cmdPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.cmdPaste.Text = "&Оруулах";
			this.cmdPaste.Click += new System.EventHandler(this.SendCommand);
			// 
			// sep5
			// 
			this.sep5.Index = 5;
			this.sep5.Text = "-";
			// 
			// cmdDelete
			// 
			this.cmdDelete.Index = 6;
			this.cmdDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.cmdDelete.Text = "Ха&сах";
			this.cmdDelete.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdClear
			// 
			this.cmdClear.Index = 7;
			this.cmdClear.Shortcut = System.Windows.Forms.Shortcut.CtrlDel;
			this.cmdClear.Text = "&Цэвэрлэх";
			this.cmdClear.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdSelectAll
			// 
			this.cmdSelectAll.Index = 8;
			this.cmdSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.cmdSelectAll.Text = "&Бүгдийг сонгох";
			this.cmdSelectAll.Click += new System.EventHandler(this.SendCommand);
			// 
			// sep6
			// 
			this.sep6.Index = 9;
			this.sep6.Text = "-";
			// 
			// cmdFind
			// 
			this.cmdFind.Index = 10;
			this.cmdFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.cmdFind.Text = "&Хайлт && Солилт...";
			this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
			// 
			// cmdGoto
			// 
			this.cmdGoto.Index = 11;
			this.cmdGoto.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
			this.cmdGoto.Text = "Байрлалд &шилжих...";
			this.cmdGoto.Click += new System.EventHandler(this.SendCommand);
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmdToolbar,
																					 this.cmdStatus,
																					 this.cmdWks,
																					 this.cmdProf,
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
			this.cmdToolbar.Text = "&Хэрэгслийн мөр";
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
			// cmdProf
			// 
			this.cmdProf.Index = 3;
			this.cmdProf.Shortcut = System.Windows.Forms.Shortcut.ShiftF5;
			this.cmdProf.Text = "&Мэргэжлүүд...";
			this.cmdProf.Click += new System.EventHandler(this.cmdProf_Click);
			// 
			// cmdSummary
			// 
			this.cmdSummary.Index = 4;
			this.cmdSummary.Shortcut = System.Windows.Forms.Shortcut.ShiftF6;
			this.cmdSummary.Text = "Т&овчоо...";
			this.cmdSummary.Click += new System.EventHandler(this.cmdSummary_Click);
			// 
			// cmdQuery
			// 
			this.cmdQuery.Index = 5;
			this.cmdQuery.Shortcut = System.Windows.Forms.Shortcut.ShiftF7;
			this.cmdQuery.Text = "Асуул&га...";
			this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_Click);
			// 
			// cmdReport
			// 
			this.cmdReport.Index = 6;
			this.cmdReport.Shortcut = System.Windows.Forms.Shortcut.ShiftF8;
			this.cmdReport.Text = "&Тайлан...";
			this.cmdReport.Click += new System.EventHandler(this.cmdPrintPreview_Click);
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
			this.cmdRefresh.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdSort
			// 
			this.cmdSort.Index = 9;
			this.cmdSort.Shortcut = System.Windows.Forms.Shortcut.F6;
			this.cmdSort.Text = "&Эрэмбэлэх";
			this.cmdSort.Click += new System.EventHandler(this.SendCommand);
			// 
			// menuTools
			// 
			this.menuTools.Index = 3;
			this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.cmdOptions});
			this.menuTools.MergeOrder = 4;
			this.menuTools.Text = "&Хэрэгсэл";
			// 
			// cmdOptions
			// 
			this.cmdOptions.Index = 0;
			this.cmdOptions.Text = "&Тохиргоо...";
			this.cmdOptions.Click += new System.EventHandler(this.cmdOptions_Click);
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
			this.cmdHTile.Text = "&Хэвтээ зэрэгцүүлэх";
			this.cmdHTile.Click += new System.EventHandler(this.cmdHTile_Click);
			// 
			// cmdVTile
			// 
			this.cmdVTile.Index = 2;
			this.cmdVTile.Text = "&Босоо зэрэгцүүлэх";
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
																					 this.cmdHelp,
																					 this.cmdAbout});
			this.menuHelp.MergeOrder = 6;
			this.menuHelp.Text = "&Тусламж";
			// 
			// cmdHelp
			// 
			this.cmdHelp.Index = 0;
			this.cmdHelp.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.cmdHelp.Text = "&Тусламж";
			this.cmdHelp.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdAbout
			// 
			this.cmdAbout.Index = 1;
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
																					   this.toolProf,
																					   this.toolQuery,
																					   this.toolFind,
																					   this.toolSeparator3,
																					   this.toolGoTo,
																					   this.toolMoveFirst,
																					   this.toolMovePrev,
																					   this.toolMoveNext,
																					   this.toolMoveLast,
																					   this.toolSeparator4});
			this.toolBar.ButtonSize = new System.Drawing.Size(16, 16);
			this.toolBar.DropDownArrows = true;
			this.toolBar.ImageList = this.images;
			this.toolBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toolBar.Name = "toolBar";
			this.toolBar.ShowToolTips = true;
			this.toolBar.Size = new System.Drawing.Size(656, 25);
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
			this.toolPrintPreview.ToolTipText = "Хэвлэхийн өмнө харах";
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
			this.toolUndo.ToolTipText = "Үйлдлийг буцаах";
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
			// toolProf
			// 
			this.toolProf.ImageIndex = 12;
			this.toolProf.ToolTipText = "Мэргэжлүүд";
			// 
			// toolQuery
			// 
			this.toolQuery.ImageIndex = 13;
			this.toolQuery.ToolTipText = "Асуулга";
			// 
			// toolFind
			// 
			this.toolFind.ImageIndex = 14;
			this.toolFind.ToolTipText = "Хайлт";
			// 
			// toolSeparator3
			// 
			this.toolSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolGoTo
			// 
			this.toolGoTo.ImageIndex = 15;
			this.toolGoTo.ToolTipText = "Байрлалд шилжих";
			// 
			// toolMoveFirst
			// 
			this.toolMoveFirst.ImageIndex = 16;
			this.toolMoveFirst.ToolTipText = "Эхэнд шилжих";
			// 
			// toolMovePrev
			// 
			this.toolMovePrev.ImageIndex = 17;
			this.toolMovePrev.ToolTipText = "Урагш шилжих";
			// 
			// toolMoveNext
			// 
			this.toolMoveNext.ImageIndex = 18;
			this.toolMoveNext.ToolTipText = "Хойш шилжих";
			// 
			// toolMoveLast
			// 
			this.toolMoveLast.ImageIndex = 19;
			this.toolMoveLast.ToolTipText = "Сүүлд шилжих";
			// 
			// toolSeparator4
			// 
			this.toolSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// statusBar
			// 
			this.statusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.statusBar.Location = new System.Drawing.Point(0, 373);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.statusMain,
																						 this.statusRecord,
																						 this.statusCap,
																						 this.statusNum});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(656, 20);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 2;
			// 
			// statusMain
			// 
			this.statusMain.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusMain.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.statusMain.Width = 506;
			// 
			// statusRecord
			// 
			this.statusRecord.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusRecord.ToolTipText = "Дугаар/Нийт";
			this.statusRecord.Width = 80;
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
			// progress
			// 
			this.progress.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.progress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.progress.Location = new System.Drawing.Point(200, 376);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(256, 16);
			this.progress.TabIndex = 7;
			this.progress.Visible = false;
			// 
			// tabWks
			// 
			this.tabWks.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabWks.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.pageClass});
			this.tabWks.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabWks.ItemSize = new System.Drawing.Size(74, 18);
			this.tabWks.Location = new System.Drawing.Point(0, 25);
			this.tabWks.Name = "tabWks";
			this.tabWks.SelectedIndex = 0;
			this.tabWks.Size = new System.Drawing.Size(184, 348);
			this.tabWks.TabIndex = 9;
			// 
			// pageClass
			// 
			this.pageClass.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.treeProf});
			this.pageClass.Location = new System.Drawing.Point(4, 4);
			this.pageClass.Name = "pageClass";
			this.pageClass.Size = new System.Drawing.Size(176, 322);
			this.pageClass.TabIndex = 0;
			this.pageClass.Text = "Мэргэжлүүд";
			// 
			// treeProf
			// 
			this.treeProf.AllowDrop = true;
			this.treeProf.ContextMenu = this.contextWks;
			this.treeProf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeProf.FullRowSelect = true;
			this.treeProf.HideSelection = false;
			this.treeProf.ImageIndex = -1;
			this.treeProf.Indent = 19;
			this.treeProf.ItemHeight = 16;
			this.treeProf.LabelEdit = true;
			this.treeProf.Name = "treeProf";
			this.treeProf.SelectedImageIndex = -1;
			this.treeProf.Size = new System.Drawing.Size(176, 322);
			this.treeProf.TabIndex = 1;
			this.treeProf.Tag = "1";
			this.treeProf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tree_KeyDown);
			this.treeProf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
			this.treeProf.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
			this.treeProf.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
			this.treeProf.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_DragEnter);
			this.treeProf.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tree_ItemDrag);
			this.treeProf.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
			// 
			// contextWks
			// 
			this.contextWks.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.cmdPopNew,
																					   this.cmdPopDelete,
																					   this.menuItem8,
																					   this.cmdPopSort});
			this.contextWks.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// cmdPopNew
			// 
			this.cmdPopNew.Index = 0;
			this.cmdPopNew.Text = "&Шинэ";
			this.cmdPopNew.Click += new System.EventHandler(this.cmdPopNew_Click);
			// 
			// cmdPopDelete
			// 
			this.cmdPopDelete.Index = 1;
			this.cmdPopDelete.Text = "&Хасах";
			this.cmdPopDelete.Click += new System.EventHandler(this.cmdPopDelete_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.Text = "-";
			// 
			// cmdPopSort
			// 
			this.cmdPopSort.Index = 3;
			this.cmdPopSort.Text = "&Эрэмбэлэх";
			this.cmdPopSort.Click += new System.EventHandler(this.cmdPopSort_Click);
			// 
			// splitterWks
			// 
			this.splitterWks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.splitterWks.Location = new System.Drawing.Point(184, 25);
			this.splitterWks.Name = "splitterWks";
			this.splitterWks.Size = new System.Drawing.Size(3, 348);
			this.splitterWks.TabIndex = 10;
			this.splitterWks.TabStop = false;
			// 
			// labelPType
			// 
			this.labelPType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelPType.Location = new System.Drawing.Point(496, 5);
			this.labelPType.Name = "labelPType";
			this.labelPType.Size = new System.Drawing.Size(48, 16);
			this.labelPType.TabIndex = 12;
			this.labelPType.Text = "Хэлбэр:";
			// 
			// comboPType
			// 
			this.comboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.comboPType.ItemHeight = 13;
			this.comboPType.Items.AddRange(new object[] {
															"Зээл",
															"Буцалтгүй",
															"Малчин өрхийн",
															"Ядуу өрхийн",
															"Гуравдагч",
															"Тах"});
			this.comboPType.Location = new System.Drawing.Point(544, 2);
			this.comboPType.Name = "comboPType";
			this.comboPType.Size = new System.Drawing.Size(104, 21);
			this.comboPType.TabIndex = 13;
			this.comboPType.SelectedIndexChanged += new System.EventHandler(this.comboPType_SelectedIndexChanged);
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
																																																	 new System.Data.Common.DataColumnMapping("shortname", "shortname"),
																																																	 new System.Data.Common.DataColumnMapping("name", "name"),
																																																	 new System.Data.Common.DataColumnMapping("duration", "duration"),
																																																	 new System.Data.Common.DataColumnMapping("degree", "degree"),
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
			// daRegion
			// 
			this.daRegion.DeleteCommand = this.oleDbDeleteCommand2;
			this.daRegion.InsertCommand = this.oleDbInsertCommand2;
			this.daRegion.SelectCommand = this.oleDbSelectCommand2;
			this.daRegion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							   new System.Data.Common.DataTableMapping("Table", "Region", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("id", "id"),
																																																		 new System.Data.Common.DataColumnMapping("name", "name")})});
			this.daRegion.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM Region WHERE (id = ?)";
			this.oleDbDeleteCommand2.Connection = this.con;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Region(name) VALUES (?)";
			this.oleDbInsertCommand2.Connection = this.con;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 50, "name"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT id, name FROM Region";
			this.oleDbSelectCommand2.Connection = this.con;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE Region SET name = ? WHERE (id = ?)";
			this.oleDbUpdateCommand2.Connection = this.con;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 50, "name"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "id", System.Data.DataRowVersion.Original, null));
			// 
			// help
			// 
			this.help.HelpNamespace = "";
			// 
			// Straf
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 393);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboPType,
																		  this.labelPType,
																		  this.splitterWks,
																		  this.tabWks,
																		  this.progress,
																		  this.statusBar,
																		  this.toolBar});
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.help.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.menuMain;
			this.Name = "Straf";
			this.help.SetShowHelp(this, true);
			this.Text = "STraF_U Програм";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Straf_Closing);
			((System.ComponentModel.ISupportInitialize)(this.statusMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusRecord)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusCap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusNum)).EndInit();
			this.tabWks.ResumeLayout(false);
			this.pageClass.ResumeLayout(false);
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

		#region Үндсэн форм
		
		private void  Straf_OnExit(object sender, System.EventArgs e) {
			SerializeOption(false);
			SerializeWks(treeProf, wksFile, false);
		}
		private void  Straf_Idle(object sender, System.EventArgs e) {
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
		private void  SendKey(int key) {
			if (ActiveControl != null) {
				Win32.SendMessage(ActiveControl.Handle, 0x0100 /*WM_KEYDOWN*/, key, 1);
			}
		}
		private void  SendCommand(object source, EventArgs e) {
			SendKey((int) ((MenuItem) source).Shortcut);
		}
		public static void ShowError(string error) {
			MessageBox.Show(error, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public int ToolFlag {
			get {
				return toolFlag;
			}
			set {
				toolFlag = value;
				int d = 1;
				for (int i = 0; i < toolBar.Buttons.Count; i++, d <<= 1) {
					toolBar.Buttons[i].Enabled = ((toolFlag & d) == d ? true : false);
				}
			}
		}
		public int CommandFlag {
			get {
				return cmdFlag;
			}
			set {
				cmdFlag = value;
				int d = 1;
				for (int i = 0; i < cmds.Length; i++, d <<= 1) {
					cmds[i].Enabled = ((cmdFlag & d) == d ? true : false);
				}
			}
		}
		#endregion

		#region Файл цэс
		private bool Connect() {
			statusMain.Text = "Баазтай холбож байна...";
			Cursor.Current = Cursors.WaitCursor;
			if (opt.database != "") {
				strCon = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User ID={1};Password={2};", opt.database, opt.uid, opt.pwd);
				con.ConnectionString = strCon;
				try {
					con.Open();
					if (con.State == ConnectionState.Open) {
						logged = true;
					}
				}
				catch (Exception) {
					logged = false;
				}
				finally {
					Cursor.Current = Cursors.Default;
					statusMain.Text = "";
					con.Close();
				}
			}

			if (logged) {
				LoadData();
			}
			else {
				OpenDatabase(null, null);
			}
			return logged;
		}
		private void OpenDatabase(object sender, System.EventArgs e) {
			LoginDlg dlg = new LoginDlg();
			DialogResult result;
			int counter = 3;
			do {
				dlg.textPassword.Text = opt.pwd;
				dlg.textUser.Text = opt.uid;
				dlg.textDatabase.Text = opt.database;
				dlg.textChanged(null, null);
				result = dlg.ShowDialog();
				if (result == DialogResult.OK) {
					strCon = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;data source={0};user id={1};password={2};", dlg.textDatabase.Text, dlg.textUser.Text, dlg.textPassword.Text);
					con.ConnectionString = strCon;
					try {
						con.Open();
						if (con.State == ConnectionState.Open) {
							opt.database = dlg.textDatabase.Text;
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
					finally {
						con.Close();
					}
					counter--;
				}
			}
			while (!logged && result != DialogResult.Cancel && counter > 0);

			if (logged) {
				LoadData();
			}
		}
		private void LoadData() {
			datasetGlobal.EnforceConstraints = false;
			try {
				datasetGlobal.Clear();
				daProf.Fill(datasetGlobal, "Prof");
				daRegion.Fill(datasetGlobal, "Region");
			}
			catch (Exception) {
				MessageBox.Show("Өгөгдөл ачаалахад алдаа гарлаа.", Straf.appName);
			}
			finally {
				datasetGlobal.EnforceConstraints = true;
			}
		}
		private void cmdClose_Click(object sender, System.EventArgs e) {
			if (ActiveMdiChild != null)
				ActiveMdiChild.Close();
		}

		private void cmdCloseAll_Click(object sender, System.EventArgs e) {
			foreach (Form kid in MdiChildren)
				kid.Close();
		}
		private void cmdPrint_Click(object sender, System.EventArgs e) {
			IStrafChild child = this.ActiveMdiChild as IStrafChild;
			if (child != null) {
				if (child.GetDocument() != null) {
					printDlg.PrinterSettings = null;
					printDlg.AllowSomePages = true;
					printDlg.ShowNetwork = true;
					printDlg.AllowPrintToFile = true;
					if (printDlg.ShowDialog() == DialogResult.OK) {
						child.GetDocument().PrintToPrinter(printDlg.PrinterSettings.Copies,
							printDlg.PrinterSettings.Collate, 
							printDlg.PrinterSettings.FromPage, 
							printDlg.PrinterSettings.ToPage);
					}
				}
			}
			else {
				SendKey((int)(Keys.Control | Keys.P));
			}
		}
		private void cmdPrintPreview_Click(object sender, System.EventArgs e) {
			IStrafChild child = this.ActiveMdiChild as IStrafChild;
			if (child != null) {
				Cursor.Current = Cursors.WaitCursor;
				ShowReport();
				formReport.SetDocument(child.GetDocument());
				Cursor.Current = Cursors.Default;
			}
			else {
				ShowReport();
			}
		}
		#endregion

		#region Засах цэс
		private void cmdFind_Click(object sender, System.EventArgs e) {
			if (formFind == null || !formFind.Visible) {
				formFind = new FindDlg(this);
				formFind.Location = new Point(opt.findX, opt.findY);
				formFind.Show();
			}
			else
				formFind.Select();
		}
		#endregion

		#region Харах цэс
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
		private void cmdProf_Click(object sender, System.EventArgs e) {
			if (formProf == null || !formProf.Visible) {
				formProf = new ProfView();
				formProf.WindowState = (FormWindowState) opt.childState;
				formProf.MdiParent = this;
				formProf.Show();
			}
			else
				formProf.Select();
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
		private void ShowReport() {
			if (formReport == null || !formReport.Visible) {
				formReport = new ReportView();
				formReport.MdiParent = this;
				formReport.Show();
			}
			else
				formReport.Select();
		}
		#endregion

		#region Цонх цэс
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
		#endregion

		#region Тусламж цэс
		private void cmdAbout_Click(object sender, System.EventArgs e) {
			AboutDlg dlg = new AboutDlg();
			dlg.ShowDialog();
		}
		#endregion

		#region Хэрэгсэл
		private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			if (e.Button == toolNew)
				SendKey((int) Keys.Control | (int) Keys.N);
			else if (e.Button == toolOpen)
				SendKey((int) Keys.Control | (int) Keys.O);
			else if (e.Button == toolSave)
				SendKey((int) Keys.Control | (int) Keys.S);
			else if (e.Button == toolCut)
				SendKey((int) Keys.Control | (int) Keys.X);
			else if (e.Button == toolCopy)
				SendKey((int) Keys.Control | (int) Keys.C);
			else if (e.Button == toolPaste)
				SendKey((int) Keys.Control | (int) Keys.V);
			else if (e.Button == toolDelete)
				SendKey((int) Keys.Delete);
			else if (e.Button == toolUndo)
				SendKey((int) Keys.Control | (int) Keys.Z);
			else if (e.Button == toolPrint)
				cmdPrint_Click(sender, e);
			else if (e.Button == toolPrintPreview)
				cmdPrintPreview_Click(sender, e);
			else if (e.Button == toolRefresh)
				SendKey((int) Keys.F5);
			else if (e.Button == toolWks)
				showWks(!toolWks.Pushed);
			else if (e.Button == toolProf)
				cmdProf_Click(sender, e);
			else if (e.Button == toolQuery)
				cmdQuery_Click(sender, e);
			else if (e.Button == toolFind)
				cmdFind_Click(sender, e);
			else if (e.Button == toolGoTo)
				SendKey((int) Keys.Control | (int) Keys.G);
			else if (e.Button == toolMoveFirst)
				SendKey((int) Keys.Alt | (int) Keys.Left);
			else if (e.Button == toolMovePrev)
				SendKey((int) Keys.Alt | (int) Keys.Up);
			else if (e.Button == toolMoveNext)
				SendKey((int) Keys.Alt | (int) Keys.Down);
			else if (e.Button == toolMoveLast)
				SendKey((int) Keys.Alt | (int) Keys.Right);
		}
		private void comboPType_SelectedIndexChanged(object sender, System.EventArgs e) {
			OpenStudentForm(comboPType.SelectedIndex);
		}
		private void OpenStudentForm(int ptype) {
			if (0 <= ptype && ptype < 6) {
				if (studentForms[ptype] == null || !studentForms[ptype].Visible) {
					switch (ptype) {
						case 0 : studentForms[ptype] = new LoanView(); break;
						case 1 : studentForms[ptype] = new AdvanceView(); break;
						case 2 : studentForms[ptype] = new HerderView(); break;
						case 3 : studentForms[ptype] = new PoorView(); break;
						case 4 : studentForms[ptype] = new ThirdView(); break;
						case 5 : studentForms[ptype] = new TaxView(); break;
					}
					studentForms[ptype].MdiParent = this;
					studentForms[ptype].Show();
					OpenNode(treeProf, null);
				}
				else
					studentForms[ptype].Select();
			}
		}
		#endregion	
		
		#region Програмын тохиргоо
		private void cmdOptions_Click(object sender, System.EventArgs e) {
			OptionDlg dlg = new OptionDlg();
			dlg.textSchoolName.Text = opt.school;
			dlg.comboSchoolLevel.SelectedIndex = opt.level;
			dlg.comboSchoolHold.SelectedIndex = opt.hold;
			dlg.textDatabase.Text = opt.database;
			dlg.textUser.Text = opt.uid;
			dlg.textPwd.Text = opt.pwd;
			if (dlg.ShowDialog() == DialogResult.OK) {
				opt.school = dlg.textSchoolName.Text;
				opt.level = dlg.comboSchoolLevel.SelectedIndex;
				opt.hold = dlg.comboSchoolHold.SelectedIndex;
				opt.database = dlg.textDatabase.Text;
				opt.uid = dlg.textUser.Text;
				opt.pwd = dlg.textPwd.Text;

				optSaved = false;
			}
		}
		private void  SerializeOption(bool read) {
			if (read) {
				try {
					Microsoft.Win32.RegistryKey keySettings = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\EMIS\\STraF_U\\Settings");
					opt.school = (string)keySettings.GetValue("School");
					opt.level = (int)keySettings.GetValue("Level");
					opt.hold = (int)keySettings.GetValue("Hold");
					opt.database = (string)keySettings.GetValue("Database");
					opt.help = (string)keySettings.GetValue("Help");
					opt.uid = (string)keySettings.GetValue("Uid");
					opt.pwd = (string)keySettings.GetValue("Pwd");
					opt.mainState = (int)keySettings.GetValue("MainState");
					opt.childState = (int)keySettings.GetValue("ChildState");
					opt.findX = (int)keySettings.GetValue("FindX");
					opt.findY = (int)keySettings.GetValue("FindY");
					
					optSaved = true;
				} 
				catch (Exception) {
					cmdOptions_Click(null, null);
					optSaved = false;
				}
			}
			else {
				if (optSaved)
                    return;

				try {
					Microsoft.Win32.RegistryKey keySettings = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\EMIS\\STraF_U\\Settings", true);
					if (keySettings == null) {
						keySettings = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\EMIS\\STraF_U\\Settings");
					}
					keySettings.SetValue("School", opt.school);
					keySettings.SetValue("Level", opt.level);
					keySettings.SetValue("Hold", opt.hold);
					keySettings.SetValue("Database", opt.database);
					keySettings.SetValue("Help", opt.help);
					keySettings.SetValue("Uid", opt.uid);
					keySettings.SetValue("Pwd", opt.pwd);
					keySettings.SetValue("MainState", opt.mainState);
					keySettings.SetValue("ChildState", opt.childState);
					keySettings.SetValue("FindX", opt.findX);
					keySettings.SetValue("FindY", opt.findY);
					optSaved = true;
				}
				catch (Exception) {}
			}
		}
		#endregion

		#region Ажлын самбар дээрх үйлдлүүд
		private void  SerializeWks(TreeView tree, string filename, bool read) {
			FileStream file = null;
			if (read) {
				Cursor.Current = Cursors.WaitCursor;
				tree.BeginUpdate();
				tree.Nodes.Clear();
				try {
					file = File.OpenRead(filename);
					BinaryReader reader;
					reader = new BinaryReader(file);
					while (file.Position < file.Length) {
						TreeNode node = LoadNode(reader);
						if (node != null)
							tree.Nodes.Add(node);
					}
					//ToolFlag = 0xFEFAE3;
					//CommandFlag = 0xFEFAE3;
					wksSaved = true;
				}
				catch (Exception) {
					wksSaved = false;
					File.Create(filename);
				}
				finally {
					Cursor.Current = Cursors.Default;
					if (file != null)
						file.Close();
				}
				tree.EndUpdate();
			}
			else {
				if (wksSaved)
					return;

				try {
					file = File.OpenWrite(filename);
					BinaryWriter writer;
					writer = new BinaryWriter(file);
					foreach (TreeNode node in tree.Nodes) {
						SaveNode(node, writer);
					}
				}
				catch (Exception) {}
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
				int childCount = bin.ReadInt32();
				int i = 0;
				while (i++ < childCount) {
					TreeNode n = LoadNode(bin);
					if (n != null)
						node.Nodes.Add(n);
				}
			}
			catch (Exception) {
				node = null;
			}
			return node;
		}
		private void SaveNode(TreeNode node, BinaryWriter bout) {
			try {
				bout.Write(node.Text);
				bout.Write(node.GetNodeCount(false));
				foreach (TreeNode n in node.Nodes) {
					SaveNode(n, bout);
				}
			}
			catch (Exception) {}
		}
		private void tree_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.Control | Keys.N: 
					NewNode(sender, e);
					break;

				case Keys.Return: 
				case Keys.Control | Keys.O:
					tree_DoubleClick(sender, e);
					break;
			
				case Keys.Delete: 
					DeleteNode(sender, e);
					break;
			
				case Keys.Control | Keys.Delete: 
					ClearNodes(sender, e);
					break;

				case Keys.Control | Keys.C:
					CopyNode(sender, e);
					break;

				case Keys.Control | Keys.X:
					CutNode(sender, e);
					break;

				case Keys.Control | Keys.V:
					PasteNode(sender, e);
					break;
				
				case Keys.Control | Keys.G:
					GoToNode();
					break;

				case Keys.Alt | Keys.Left:
					MoveFirstNode();
					break;

				case Keys.Alt | Keys.Up:
					MovePrevNode();
					break;

				case Keys.Alt | Keys.Down:
					MoveNextNode();
					break;

				case Keys.Alt | Keys.Right:
					MoveLastNode();
					break;

				case Keys.F2:
					RenameNode(sender, e);
					break;

				case  Keys.F6: 
					SortNode(sender, e);
					break;
			
				case Keys.Control | Keys.Shift | Keys.S:
				case Keys.Escape: 
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
			if (tree == null) return;

			TreeNode selNode = tree.SelectedNode;
			TreeNode newNode = new TreeNode("<хоосон>");
			newNode.Tag = -1;
			if (selNode != null)
				selNode.Nodes.Add(newNode);
			else
				tree.Nodes.Add(newNode);
			tree.SelectedNode = newNode;
			tree.Sorted = false;
			wksSaved = false;
		}
		private void OpenNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;
			
			TreeNode selNode = tree.SelectedNode;
			if (selNode != null) {
				IStudentChild child = this.ActiveMdiChild as IStudentChild;
				if (child != null) {
					child.ChangeProf(selNode.Text);
				}
			}
		}
		private void tree_DoubleClick(object sender, System.EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;
			
			TreeNode selNode = tree.SelectedNode;
			if (selNode != null) {
				IStudentChild child = this.ActiveMdiChild as IStudentChild;
				if (child == null) {
					int ptype = 0;
					studentForms[ptype] = new LoanView();
					studentForms[ptype].MdiParent = this;
					studentForms[ptype].Show();
					((IStudentChild)studentForms[ptype]).ChangeProf(selNode.Text);
				}
			}
		}
		private void CopyNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			TreeNode node = tree.SelectedNode;
			if (node != null) {
				Clipboard.SetDataObject(node);
				//ToolFlag |= 0x100;
			}
		}
		private void CutNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;
			
			TreeNode node = tree.SelectedNode;
			if (node != null) {
				Clipboard.SetDataObject(node);
				node.Remove();
				wksSaved = false;
			}
		}
		private void PasteNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			IDataObject iData = Clipboard.GetDataObject();

			if (iData.GetDataPresent(typeof(TreeNode))) {
				TreeNode dropNode = (TreeNode) iData.GetData(typeof(TreeNode));
				TreeNode selNode = tree.SelectedNode;
				if (dropNode != null && dropNode != selNode) {
					TreeNode newNode = (TreeNode)dropNode.Clone();
					if (selNode == null)
						tree.Nodes.Add(newNode);
					else
						selNode.Nodes.Add(newNode);
					tree.Sorted = false;
					wksSaved = false;
				}
			}
		}
		private void tree_AfterSelect(object sender, TreeViewEventArgs e) {
			OpenNode(sender, e);
		}
		private void FindNode(object sender, string text) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			TreeNode node = tree.SelectedNode;
			while (node != null && !node.Text.StartsWith(text))
				node = node.NextVisibleNode;
			if (node != null)
				tree.SelectedNode = node;
		}
		private void GoToNode() {
			GotoDlg dlg = new GotoDlg();
			dlg.Text = "Мэргэжлийн нэр:";
			dlg.labelTitle.Text = "Мэргэжил:";
			if (dlg.ShowDialog() == DialogResult.OK) {
				FindNode(treeProf, dlg.textPos.Text);
			}
		}
		private void MoveFirstNode() {
			if (treeProf.SelectedNode.Parent != null)
				treeProf.SelectedNode = treeProf.SelectedNode.Parent.Nodes[0];
			else
				treeProf.SelectedNode = treeProf.TopNode;
		}
		private void MovePrevNode() {
			if (treeProf.SelectedNode.PrevVisibleNode != null)
				treeProf.SelectedNode = treeProf.SelectedNode.PrevVisibleNode;
		}
		private void MoveNextNode() {
			if (treeProf.SelectedNode.NextVisibleNode != null)
				treeProf.SelectedNode = treeProf.SelectedNode.NextVisibleNode;
		}
		private void MoveLastNode() {
			if (treeProf.SelectedNode.Parent != null)
				treeProf.SelectedNode = treeProf.SelectedNode.Parent.Nodes[treeProf.SelectedNode.Parent.Nodes.Count - 1];
			else
				treeProf.SelectedNode = treeProf.Nodes[treeProf.Nodes.Count - 1];
		}
		private void DeleteNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null && tree.SelectedNode != null) {
				if (MessageBox.Show("Устгах уу ?", Straf.appName, MessageBoxButtons.YesNo) == DialogResult.Yes) {
					tree.SelectedNode.Remove();
					wksSaved = false;
				}
			}
		}
		private void ClearNodes(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			if (tree.Nodes.Count > 0) {
				tree.Nodes.Clear();
				wksSaved = false;
				//ToolFlag |= 23;
			}
		}
		private void RenameNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			if (tree.SelectedNode != null) {
				tree.SelectedNode.BeginEdit();
				wksSaved = false;
			}
		}
		private void SortNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			tree.Sorted = true;
			tree.Refresh();
			wksSaved = false;
		}
		private void UnselectNode(object sender, EventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null)
				tree.SelectedNode = null;
		}
		private void tree_MouseDown(object sender, MouseEventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree == null) return;

			if (e.Button == MouseButtons.Right)
				tree.SelectedNode = tree.GetNodeAt(e.X, e.Y);
		}
		
		private void tree_ItemDrag(object sender, ItemDragEventArgs e) {
			TreeView tree = sender as TreeView;
			if (tree != null)
				tree.DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);
		}
		private void tree_DragEnter(object sender, DragEventArgs e) {
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
					tree.Sorted = false;
					wksSaved = false;
				}
			}
			else if (e.Data.GetDataPresent(DataFormats.Text)) {
				string dropText = (string)e.Data.GetData(DataFormats.Text);
				string[] lines = dropText.Split(new Char[] {'\n'});
				TreeNode selNode = tree.GetNodeAt(tree.PointToClient(new Point(e.X, e.Y)));
				TreeNodeCollection nodes;

				if (selNode != null) 
					nodes = selNode.Nodes;
				else
					nodes = tree.Nodes;

				for (int i=0; i < lines.Length; i++) {
					string line = lines[i].Trim(new Char[]{'\r'});
					if (line != "")
						nodes.Add(new TreeNode(line));
				}
				tree.Sorted = false;
				wksSaved = false;
			}
		}

		private void cmdPopNew_Click(object sender, System.EventArgs e) {
			NewNode(treeProf, null);
		}

		private void cmdPopDelete_Click(object sender, System.EventArgs e) {
			DeleteNode(treeProf, null);
		}

		private void cmdPopSort_Click(object sender, System.EventArgs e) {
			SortNode(treeProf, null);
		}
		#endregion
	}
}

