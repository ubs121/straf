using System;
using System.Windows.Forms;

namespace STraF_U {
    public class AboutDlg : Form {
		internal System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textAbout;
		private System.Windows.Forms.Button buttonOk;

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
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(272, 168);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(76, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			// 
			// textAbout
			// 
			this.textAbout.BackColor = System.Drawing.SystemColors.Info;
			this.textAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAbout.Enabled = false;
			this.textAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textAbout.ForeColor = System.Drawing.SystemColors.Highlight;
			this.textAbout.Location = new System.Drawing.Point(8, 8);
			this.textAbout.Multiline = true;
			this.textAbout.Name = "textAbout";
			this.textAbout.ReadOnly = true;
			this.textAbout.Size = new System.Drawing.Size(352, 152);
			this.textAbout.TabIndex = 1;
			this.textAbout.Text = "\tБСШУЯ-ны Сургалтын Төрийн Сангийн\r\n\tМэдээллийн системийн их, дээд сургуулиудад\r\n" +
				"\tашиглагдах STraF_U Програм.\r\n\r\n\tХувилбар 1.0.\r\n\r\n\tCopyright (c) 2003  EMIS Grou" +
				"p.";
			// 
			// AboutDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(370, 199);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textAbout,
																		  this.buttonOk});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Програмын тухай";
			this.ResumeLayout(false);

		}

		#endregion

		
	}
}