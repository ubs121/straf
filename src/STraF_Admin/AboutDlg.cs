using System;
using System.Windows.Forms;

namespace STraF {
    public class AboutDlg : Form {
		internal System.ComponentModel.Container components = null;
		private TextBox textAbout;
		private Button buttonOk;

		public AboutDlg() : base() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		
		protected  override void  Dispose(bool disposing) {
			base.Dispose(true);
			if (disposing)
				if (components != null)
					components.Dispose();
		}
				
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>

		private void  InitializeComponent() {
			this.buttonOk = new System.Windows.Forms.Button();
			this.textAbout = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(168, 120);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(76, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			// 
			// textAbout
			// 
			this.textAbout.Location = new System.Drawing.Point(8, 8);
			this.textAbout.Multiline = true;
			this.textAbout.Name = "textAbout";
			this.textAbout.ReadOnly = true;
			this.textAbout.Size = new System.Drawing.Size(248, 104);
			this.textAbout.TabIndex = 1;
			this.textAbout.Text = "Энэхvv програм нь Сургалтын Төрийн Сангийн\r\nvйл ажиллагаанд зориулагдав.\r\n\r\n(c) 2" +
				"002 он. EIMS групп.";
			// 
			// AboutDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(266, 151);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textAbout,
																		  this.buttonOk});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Програмын тухай";
			this.ResumeLayout(false);

		}

		#endregion
	}
}

