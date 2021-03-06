using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace STraF {
	/// <summary>
	/// Summary description for OptionDlg.
	/// </summary>
	public class OptionDlg : Form {
		private Panel panel1;
		private TabControl tabControl1;
		private TabPage tabPage2;
		private Label labelUser;
		private Label labelPassword;
		internal ToolTip toolTip;
		private Button buttonCancel;
		private Button buttonOk;
		private Button buttonChangePwd;
		private System.Data.SqlClient.SqlConnection con;
		private System.Data.SqlClient.SqlCommand cmd;
		public TextBox textPwd;
		public TextBox textUser;
		private System.ComponentModel.IContainer components;

		public OptionDlg() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			if (Straf.logged) {
				try {
					con.ConnectionString = Straf.strCon;
					con.Open();
				}
				catch (Exception) {
					MessageBox.Show("Сервер рvv холбогдож чадахгvй байна", Straf.appName);
				}
			}
			else {
				buttonChangePwd.Enabled = false;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textPwd = new System.Windows.Forms.TextBox();
			this.textUser = new System.Windows.Forms.TextBox();
			this.buttonChangePwd = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.con = new System.Data.SqlClient.SqlConnection();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.buttonCancel,
																				 this.buttonOk});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 141);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 40);
			this.panel1.TabIndex = 3;
			this.panel1.Text = "panel1";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(168, 8);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(86, 8);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "Ok";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage2});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(256, 141);
			this.tabControl1.TabIndex = 2;
			this.tabControl1.Text = "tabControl1";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.labelUser,
																				   this.labelPassword,
																				   this.textPwd,
																				   this.textUser,
																				   this.buttonChangePwd});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(248, 115);
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "Хандах эрх";
			// 
			// labelUser
			// 
			this.labelUser.Location = new System.Drawing.Point(16, 16);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(60, 23);
			this.labelUser.TabIndex = 0;
			this.labelUser.Text = "Хэрэглэгч:";
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(16, 48);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(60, 23);
			this.labelPassword.TabIndex = 2;
			this.labelPassword.Text = "Нууц vг:";
			// 
			// textPwd
			// 
			this.textPwd.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPwd.Location = new System.Drawing.Point(96, 48);
			this.textPwd.Name = "textPwd";
			this.textPwd.PasswordChar = '*';
			this.textPwd.Size = new System.Drawing.Size(137, 20);
			this.textPwd.TabIndex = 3;
			this.textPwd.Text = "";
			this.toolTip.SetToolTip(this.textPwd, "Нууц vг");
			// 
			// textUser
			// 
			this.textUser.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUser.Location = new System.Drawing.Point(96, 16);
			this.textUser.Name = "textUser";
			this.textUser.ReadOnly = true;
			this.textUser.Size = new System.Drawing.Size(137, 20);
			this.textUser.TabIndex = 1;
			this.textUser.Text = "";
			this.toolTip.SetToolTip(this.textUser, "ӨС руу хандах эрх");
			// 
			// buttonChangePwd
			// 
			this.buttonChangePwd.Location = new System.Drawing.Point(152, 80);
			this.buttonChangePwd.Name = "buttonChangePwd";
			this.buttonChangePwd.TabIndex = 4;
			this.buttonChangePwd.Text = "&Солих";
			this.buttonChangePwd.Click += new System.EventHandler(this.buttonChangePwd_Click);
			// 
			// con
			// 
			this.con.ConnectionString = "data source=onolt;initial catalog=STraF;password=ub;persist security info=True;us" +
				"er id=sa;workstation id=ONOLT;packet size=4096";
			// 
			// cmd
			// 
			this.cmd.Connection = this.con;
			// 
			// Option
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(256, 181);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1,
																		  this.panel1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Option";
			this.Text = "Тохиргоо";
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonChangePwd_Click(object sender, System.EventArgs e) {
			try {
				cmd.CommandText = "exec sp_password '" + Straf.opt.pwd + "', '" + textPwd.Text + "', '" + Straf.opt.uid + "'";
				cmd.ExecuteNonQuery();
				Straf.opt.pwd = textPwd.Text;
				Straf.strCon = string.Format("persist security info=True;initial catalog=STraF;packet size=4096;data source={0};workstation id={0};user id={1};password={2}", Straf.opt.server, Straf.opt.uid, Straf.opt.pwd);
				MessageBox.Show("Амжилттай солигдлоо", Straf.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex) {
				MessageBox.Show("Нууц vг солигдоогvй \n" + ex.ToString(), Straf.appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

	}
}

