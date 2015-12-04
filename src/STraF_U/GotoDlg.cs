using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace STraF_U {
	/// <summary>
	/// Summary description for GotoDlg.
	/// </summary>
	public class GotoDlg : System.Windows.Forms.Form {
		internal System.Windows.Forms.TextBox textPos;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Label labelTitle;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GotoDlg() {
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.textPos = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(8, 8);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(192, 23);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Байрлал:";
			// 
			// textPos
			// 
			this.textPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPos.Location = new System.Drawing.Point(8, 32);
			this.textPos.Name = "textPos";
			this.textPos.Size = new System.Drawing.Size(192, 20);
			this.textPos.TabIndex = 1;
			this.textPos.Text = "";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(64, 64);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(64, 22);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Ok";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(136, 64);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(64, 22);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			// 
			// GotoDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(218, 98);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonCancel,
																		  this.buttonOk,
																		  this.textPos,
																		  this.labelTitle});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GotoDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Байрлалд шилжих";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
