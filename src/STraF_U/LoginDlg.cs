using System;
using System.Windows.Forms;

namespace STraF_U {
	public class LoginDlg : Form {
		private Label labelServer;
		private Label labelUser;
		private Label labelPassword;
		private PictureBox pictureKey;
		private Button buttonCancel;
		private Button buttonOk;
		internal System.Windows.Forms.TextBox textUser;
		public System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		public System.Windows.Forms.TextBox textDatabase;
		internal CheckBox checkPassRemember;
		internal System.ComponentModel.Container components = null;

		public LoginDlg() : base() {
			InitializeComponent();
		}
		
		/// <summary> Login overrides dispose so it can clean up the
		/// component list.
		/// </summary>
		protected  override void  Dispose(bool disposing) {
			base.Dispose(true);
			if (disposing)
				if (components != null)
					components.Dispose();
		}
		
		public virtual void  textChanged(object source, System.EventArgs e)	{
			if (textDatabase.Text != "")
				buttonOk.Enabled = true;
			else
				buttonOk.Enabled = false;
		}
		
		#region Windows Form Designer generated code
		private void  InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LoginDlg));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelServer = new System.Windows.Forms.Label();
			this.textDatabase = new System.Windows.Forms.TextBox();
			this.labelUser = new System.Windows.Forms.Label();
			this.textUser = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.pictureKey = new System.Windows.Forms.PictureBox();
			this.checkPassRemember = new System.Windows.Forms.CheckBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(256, 72);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(64, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			// 
			// labelServer
			// 
			this.labelServer.Location = new System.Drawing.Point(8, 8);
			this.labelServer.Name = "labelServer";
			this.labelServer.Size = new System.Drawing.Size(64, 23);
			this.labelServer.TabIndex = 0;
			this.labelServer.Text = "Бааз файл:";
			// 
			// textDatabase
			// 
			this.textDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDatabase.Location = new System.Drawing.Point(80, 8);
			this.textDatabase.Name = "textDatabase";
			this.textDatabase.Size = new System.Drawing.Size(168, 20);
			this.textDatabase.TabIndex = 1;
			this.textDatabase.Text = "";
			// 
			// labelUser
			// 
			this.labelUser.Location = new System.Drawing.Point(8, 40);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(64, 23);
			this.labelUser.TabIndex = 2;
			this.labelUser.Text = "Хэрэглэгч:";
			// 
			// textUser
			// 
			this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUser.Location = new System.Drawing.Point(80, 40);
			this.textUser.Name = "textUser";
			this.textUser.Size = new System.Drawing.Size(128, 20);
			this.textUser.TabIndex = 3;
			this.textUser.Text = "";
			this.textUser.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(9, 72);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(63, 23);
			this.labelPassword.TabIndex = 4;
			this.labelPassword.Text = "Нууц үг:";
			// 
			// textPassword
			// 
			this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPassword.Location = new System.Drawing.Point(80, 72);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(128, 20);
			this.textPassword.TabIndex = 5;
			this.textPassword.Text = "";
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Enabled = false;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(256, 40);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(64, 23);
			this.buttonOk.TabIndex = 7;
			this.buttonOk.Text = "Ok";
			// 
			// pictureKey
			// 
			this.pictureKey.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureKey.Image")));
			this.pictureKey.Location = new System.Drawing.Point(216, 64);
			this.pictureKey.Name = "pictureKey";
			this.pictureKey.Size = new System.Drawing.Size(32, 32);
			this.pictureKey.TabIndex = 9;
			this.pictureKey.TabStop = false;
			this.pictureKey.Text = "pictureBox1";
			// 
			// checkPassRemember
			// 
			this.checkPassRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkPassRemember.Location = new System.Drawing.Point(80, 104);
			this.checkPassRemember.Name = "checkPassRemember";
			this.checkPassRemember.Size = new System.Drawing.Size(112, 23);
			this.checkPassRemember.TabIndex = 6;
			this.checkPassRemember.Text = "Нууц үгийг санах";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowse.Location = new System.Drawing.Point(256, 8);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(64, 23);
			this.buttonBrowse.TabIndex = 9;
			this.buttonBrowse.Text = "&Browse...";
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// dlgOpen
			// 
			this.dlgOpen.DefaultExt = "mdb";
			this.dlgOpen.Filter = "Access ôàéëóóä (*.mdb) | *.mdb";
			this.dlgOpen.Title = "Áààç ôàéë";
			// 
			// LoginDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(330, 135);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonBrowse,
																		  this.textUser,
																		  this.checkPassRemember,
																		  this.pictureKey,
																		  this.buttonOk,
																		  this.textPassword,
																		  this.labelPassword,
																		  this.labelUser,
																		  this.textDatabase,
																		  this.labelServer,
																		  this.buttonCancel});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Нэвтрэх эрх";
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonBrowse_Click(object sender, System.EventArgs e) {
			if (dlgOpen.ShowDialog() == DialogResult.OK) {
				textDatabase.Text = dlgOpen.FileName;
			}
		}
	}
}