using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace STraF {
	/// <summary>
	/// Summary description for Find.
	/// </summary>
	public class FindDlg : Form {
		private Form parent;
		private ToolBarButton toolNew;
		private ToolBarButton toolWholeWord;
		private ToolBarButton toolRegular;
		private ToolBar toolbarFind;
		private ImageList imageTool;
		private Button buttonReplaceAll;
		private Button buttonReplace;
		private Button buttonFind;
		private TextBox textReplace;
		private TextBox textFind;
		private System.Windows.Forms.ToolBarButton toolBack;
		private System.ComponentModel.IContainer components;

		public FindDlg(Form parent) :  base() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.parent = parent;
			NewSearch();
		}

		protected override CreateParams CreateParams {
			get {
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x00000008; // WS_EX_TOPMOST
				return cp;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FindDlg));
			this.toolWholeWord = new System.Windows.Forms.ToolBarButton();
			this.toolRegular = new System.Windows.Forms.ToolBarButton();
			this.toolNew = new System.Windows.Forms.ToolBarButton();
			this.toolbarFind = new System.Windows.Forms.ToolBar();
			this.toolBack = new System.Windows.Forms.ToolBarButton();
			this.imageTool = new System.Windows.Forms.ImageList(this.components);
			this.textReplace = new System.Windows.Forms.TextBox();
			this.textFind = new System.Windows.Forms.TextBox();
			this.buttonReplaceAll = new System.Windows.Forms.Button();
			this.buttonReplace = new System.Windows.Forms.Button();
			this.buttonFind = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// toolWholeWord
			// 
			this.toolWholeWord.ImageIndex = 1;
			this.toolWholeWord.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolWholeWord.ToolTipText = "Бvтэн vгээр";
			// 
			// toolRegular
			// 
			this.toolRegular.ImageIndex = 2;
			this.toolRegular.Pushed = true;
			this.toolRegular.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolRegular.ToolTipText = "Ердийн";
			// 
			// toolNew
			// 
			this.toolNew.ImageIndex = 0;
			this.toolNew.ToolTipText = "Шинэ хайлт";
			// 
			// toolbarFind
			// 
			this.toolbarFind.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolbarFind.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						   this.toolNew,
																						   this.toolWholeWord,
																						   this.toolRegular,
																						   this.toolBack});
			this.toolbarFind.ButtonSize = new System.Drawing.Size(16, 16);
			this.toolbarFind.DropDownArrows = true;
			this.toolbarFind.ImageList = this.imageTool;
			this.toolbarFind.Name = "toolbarFind";
			this.toolbarFind.ShowToolTips = true;
			this.toolbarFind.Size = new System.Drawing.Size(296, 25);
			this.toolbarFind.TabIndex = 5;
			this.toolbarFind.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolbarFind_ButtonClick);
			// 
			// toolBack
			// 
			this.toolBack.ImageIndex = 3;
			this.toolBack.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBack.ToolTipText = "Буцах чиглэлд хайх";
			// 
			// imageTool
			// 
			this.imageTool.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageTool.ImageSize = new System.Drawing.Size(16, 16);
			this.imageTool.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTool.ImageStream")));
			this.imageTool.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// textReplace
			// 
			this.textReplace.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textReplace.Location = new System.Drawing.Point(88, 64);
			this.textReplace.Name = "textReplace";
			this.textReplace.Size = new System.Drawing.Size(192, 20);
			this.textReplace.TabIndex = 12;
			this.textReplace.Text = "";
			this.textReplace.TextChanged += new System.EventHandler(this.textReplace_TextChanged);
			this.textReplace.Enter += new System.EventHandler(this.textReplace_Enter);
			// 
			// textFind
			// 
			this.textFind.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textFind.Location = new System.Drawing.Point(88, 32);
			this.textFind.Name = "textFind";
			this.textFind.Size = new System.Drawing.Size(192, 20);
			this.textFind.TabIndex = 10;
			this.textFind.Text = "";
			this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
			this.textFind.Enter += new System.EventHandler(this.textFind_Enter);
			// 
			// buttonReplaceAll
			// 
			this.buttonReplaceAll.Enabled = false;
			this.buttonReplaceAll.Location = new System.Drawing.Point(8, 96);
			this.buttonReplaceAll.Name = "buttonReplaceAll";
			this.buttonReplaceAll.Size = new System.Drawing.Size(96, 23);
			this.buttonReplaceAll.TabIndex = 13;
			this.buttonReplaceAll.Text = "&Бvгдийг Солих";
			this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
			// 
			// buttonReplace
			// 
			this.buttonReplace.Enabled = false;
			this.buttonReplace.Location = new System.Drawing.Point(8, 64);
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Size = new System.Drawing.Size(64, 23);
			this.buttonReplace.TabIndex = 11;
			this.buttonReplace.Text = "&Солих";
			this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
			// 
			// buttonFind
			// 
			this.buttonFind.Enabled = false;
			this.buttonFind.Location = new System.Drawing.Point(8, 32);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(64, 23);
			this.buttonFind.TabIndex = 9;
			this.buttonFind.Text = "&Хайх";
			this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
			// 
			// Find
			// 
			this.AcceptButton = this.buttonFind;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 133);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textReplace,
																		  this.textFind,
																		  this.buttonReplaceAll,
																		  this.buttonReplace,
																		  this.buttonFind,
																		  this.toolbarFind});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Find";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Хайх";
			this.ResumeLayout(false);

		}
		#endregion

		private void  NewSearch() {
			textFind.Text = "";
			textReplace.Text = "";
		}

		private void textFind_Enter(object sender, System.EventArgs e) {
			AcceptButton = buttonFind;
		}

		private void textReplace_Enter(object sender, System.EventArgs e) {
			AcceptButton = buttonReplace;
		}

		private void textReplace_TextChanged(object sender, System.EventArgs e) {
			if (textReplace.Text == "") {
				buttonReplace.Enabled = false;
				buttonReplaceAll.Enabled = false;
			}
			else {
				buttonReplace.Enabled = true;
				buttonReplaceAll.Enabled = true;
			}
		}

		private void textFind_TextChanged(object sender, System.EventArgs e) {
			if (textFind.Text == "")
				buttonFind.Enabled = false;
			else
				buttonFind.Enabled = true;
		}
		private void toolbarFind_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			if (e.Button == toolNew)
				NewSearch();
			else if (e.Button == toolWholeWord) {
				toolRegular.Pushed = !toolWholeWord.Pushed;
			}
			else if (e.Button == toolRegular) {
				toolWholeWord.Pushed = !toolRegular.Pushed;
			}
		}
		private void buttonFind_Click(object sender, System.EventArgs e) {
			if (parent != null) {
				IStrafChild child = parent.ActiveMdiChild as IStrafChild;
				if (child != null)
					child.Find(textFind.Text, toolRegular.Pushed, toolBack.Pushed);
			}
		}

		private void buttonReplace_Click(object sender, System.EventArgs e) {
			if (parent != null) {
				IStrafChild child = parent.ActiveMdiChild as IStrafChild;
				if (child != null)
					child.Replace(textFind.Text, textReplace.Text, toolRegular.Pushed, toolBack.Pushed);
			}
		}

		private void buttonReplaceAll_Click(object sender, System.EventArgs e) {
		
		}
	}
}

