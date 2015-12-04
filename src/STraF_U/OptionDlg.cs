using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace STraF_U {
	/// <summary>
	/// Summary description for Option.
	/// </summary>
	public class OptionDlg : Form {
		private Label labelUser;
		private Label labelPassword;
		private Button buttonCancel;
		private Button buttonOk;
		public TextBox textPwd;
		public TextBox textUser;
		private Label label1;
		public TextBox textDatabase;
		private Panel panelFoot;
		private TabControl tabOption;
		private TabPage pageAccount;
		private TabPage pageSchool;
		private Label label2;
		private Label label3;
		private Label label4;
		public TextBox textSchoolName;
		public System.Windows.Forms.ComboBox comboSchoolLevel;
		public System.Windows.Forms.ComboBox comboSchoolHold;
		private Button buttonBrowse;
		private OpenFileDialog openDlg;
		private System.Windows.Forms.ImageList images;
		private System.ComponentModel.IContainer components = null;

		public OptionDlg() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OptionDlg));
			this.panelFoot = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.tabOption = new System.Windows.Forms.TabControl();
			this.pageSchool = new System.Windows.Forms.TabPage();
			this.comboSchoolHold = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboSchoolLevel = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textSchoolName = new System.Windows.Forms.TextBox();
			this.pageAccount = new System.Windows.Forms.TabPage();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textDatabase = new System.Windows.Forms.TextBox();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textPwd = new System.Windows.Forms.TextBox();
			this.textUser = new System.Windows.Forms.TextBox();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.openDlg = new System.Windows.Forms.OpenFileDialog();
			this.panelFoot.SuspendLayout();
			this.tabOption.SuspendLayout();
			this.pageSchool.SuspendLayout();
			this.pageAccount.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelFoot
			// 
			this.panelFoot.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.buttonCancel,
																					this.buttonOk});
			this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFoot.Location = new System.Drawing.Point(0, 170);
			this.panelFoot.Name = "panelFoot";
			this.panelFoot.Size = new System.Drawing.Size(306, 40);
			this.panelFoot.TabIndex = 1;
			this.panelFoot.Text = "panel1";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(218, 8);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(136, 8);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "Ok";
			// 
			// tabOption
			// 
			this.tabOption.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.pageSchool,
																					this.pageAccount});
			this.tabOption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabOption.ImageList = this.images;
			this.tabOption.Multiline = true;
			this.tabOption.Name = "tabOption";
			this.tabOption.SelectedIndex = 0;
			this.tabOption.Size = new System.Drawing.Size(306, 170);
			this.tabOption.TabIndex = 0;
			this.tabOption.Text = "tabControl1";
			// 
			// pageSchool
			// 
			this.pageSchool.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.comboSchoolHold,
																					 this.label4,
																					 this.comboSchoolLevel,
																					 this.label3,
																					 this.label2,
																					 this.textSchoolName});
			this.pageSchool.ImageIndex = 0;
			this.pageSchool.Location = new System.Drawing.Point(4, 23);
			this.pageSchool.Name = "pageSchool";
			this.pageSchool.Size = new System.Drawing.Size(298, 143);
			this.pageSchool.TabIndex = 1;
			this.pageSchool.Text = "Сургууль";
			// 
			// comboSchoolHold
			// 
			this.comboSchoolHold.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.comboSchoolHold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSchoolHold.Items.AddRange(new object[] {
																 "төрийн",
																 "хувийн"});
			this.comboSchoolHold.Location = new System.Drawing.Point(112, 80);
			this.comboSchoolHold.Name = "comboSchoolHold";
			this.comboSchoolHold.Size = new System.Drawing.Size(168, 21);
			this.comboSchoolHold.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Өмчийн хэлбэр:";
			// 
			// comboSchoolLevel
			// 
			this.comboSchoolLevel.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.comboSchoolLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSchoolLevel.Items.AddRange(new object[] {
																  "их сургууль",
																  "дээд сургууль",
																  "коллеж",
																  "МСҮТ"});
			this.comboSchoolLevel.Location = new System.Drawing.Point(112, 48);
			this.comboSchoolLevel.Name = "comboSchoolLevel";
			this.comboSchoolLevel.Size = new System.Drawing.Size(168, 21);
			this.comboSchoolLevel.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Хэв шинж:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Сургуулийн нэр:";
			// 
			// textSchoolName
			// 
			this.textSchoolName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textSchoolName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSchoolName.Location = new System.Drawing.Point(112, 16);
			this.textSchoolName.Name = "textSchoolName";
			this.textSchoolName.Size = new System.Drawing.Size(168, 20);
			this.textSchoolName.TabIndex = 1;
			this.textSchoolName.Text = "";
			// 
			// pageAccount
			// 
			this.pageAccount.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.buttonBrowse,
																					  this.label1,
																					  this.textDatabase,
																					  this.labelUser,
																					  this.labelPassword,
																					  this.textPwd,
																					  this.textUser});
			this.pageAccount.ImageIndex = 1;
			this.pageAccount.Location = new System.Drawing.Point(4, 23);
			this.pageAccount.Name = "pageAccount";
			this.pageAccount.Size = new System.Drawing.Size(298, 143);
			this.pageAccount.TabIndex = 0;
			this.pageAccount.Text = "Нэвтрэх эрх";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowse.Location = new System.Drawing.Point(216, 112);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(64, 23);
			this.buttonBrowse.TabIndex = 6;
			this.buttonBrowse.Text = "Browse...";
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Бааз файл:";
			// 
			// textDatabase
			// 
			this.textDatabase.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDatabase.Location = new System.Drawing.Point(88, 80);
			this.textDatabase.Name = "textDatabase";
			this.textDatabase.Size = new System.Drawing.Size(192, 20);
			this.textDatabase.TabIndex = 5;
			this.textDatabase.Text = "";
			// 
			// labelUser
			// 
			this.labelUser.Location = new System.Drawing.Point(8, 16);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(64, 23);
			this.labelUser.TabIndex = 0;
			this.labelUser.Text = "Хэрэглэгч:";
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(8, 48);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(64, 23);
			this.labelPassword.TabIndex = 2;
			this.labelPassword.Text = "Нууц үг:";
			// 
			// textPwd
			// 
			this.textPwd.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPwd.Location = new System.Drawing.Point(88, 48);
			this.textPwd.Name = "textPwd";
			this.textPwd.PasswordChar = '*';
			this.textPwd.Size = new System.Drawing.Size(192, 20);
			this.textPwd.TabIndex = 3;
			this.textPwd.Text = "";
			// 
			// textUser
			// 
			this.textUser.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUser.Location = new System.Drawing.Point(88, 16);
			this.textUser.Name = "textUser";
			this.textUser.Size = new System.Drawing.Size(192, 20);
			this.textUser.TabIndex = 1;
			this.textUser.Text = "";
			// 
			// images
			// 
			this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.images.ImageSize = new System.Drawing.Size(16, 16);
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// openDlg
			// 
			this.openDlg.DefaultExt = "mdb";
			this.openDlg.Filter = "Access áààç (*.mdb)|*.mdb";
			this.openDlg.Title = "Áààç ôàéë";
			// 
			// OptionDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(306, 210);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabOption,
																		  this.panelFoot});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Тохиргоо";
			this.panelFoot.ResumeLayout(false);
			this.tabOption.ResumeLayout(false);
			this.pageSchool.ResumeLayout(false);
			this.pageAccount.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonBrowse_Click(object sender, System.EventArgs e) {
			if (openDlg.ShowDialog() == DialogResult.OK) {
				textDatabase.Text = openDlg.FileName;
			}
		}
	}
}
