using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace STraF_U {
	/// <summary>
	/// Summary description for FilterDlg.
	/// </summary>
	public class FilterDlg : Form {
		private int state;
		private CheckBox checkGrade;
		private CheckBox checkLeft;
		private CheckBox checkAbsent;
		private CheckBox checkAvl;
		private CheckBox checkNew;
		private Button buttonCancel;
		private Button buttonOk;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FilterDlg(int state) {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.state = state;
			CheckBox[] cs = new CheckBox[] {checkNew, checkAvl, checkAbsent, checkLeft, checkGrade};
			int[] ss = new int[] {1, 2, 4, 8, 16};
			for (int i=0; i < ss.Length; i++) {
				if ((state & ss[i]) == ss[i])
					cs[i].Checked = true;
				else
					cs[i].Checked = false;
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.checkGrade = new System.Windows.Forms.CheckBox();
			this.checkLeft = new System.Windows.Forms.CheckBox();
			this.checkAbsent = new System.Windows.Forms.CheckBox();
			this.checkAvl = new System.Windows.Forms.CheckBox();
			this.checkNew = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.buttonCancel.Location = new System.Drawing.Point(128, 136);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.buttonOk.Location = new System.Drawing.Point(40, 136);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 5;
			this.buttonOk.Text = "Ok";
			// 
			// checkGrade
			// 
			this.checkGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkGrade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.checkGrade.Location = new System.Drawing.Point(16, 104);
			this.checkGrade.Name = "checkGrade";
			this.checkGrade.Size = new System.Drawing.Size(120, 24);
			this.checkGrade.TabIndex = 4;
			this.checkGrade.Tag = "16";
			this.checkGrade.Text = "Төгссөн";
			this.checkGrade.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
			// 
			// checkLeft
			// 
			this.checkLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.checkLeft.Location = new System.Drawing.Point(16, 80);
			this.checkLeft.Name = "checkLeft";
			this.checkLeft.Size = new System.Drawing.Size(184, 24);
			this.checkLeft.TabIndex = 3;
			this.checkLeft.Tag = "8";
			this.checkLeft.Text = "Сургуулиа орхисон, цуцалсан";
			this.checkLeft.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
			// 
			// checkAbsent
			// 
			this.checkAbsent.Checked = true;
			this.checkAbsent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkAbsent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.checkAbsent.Location = new System.Drawing.Point(16, 56);
			this.checkAbsent.Name = "checkAbsent";
			this.checkAbsent.Size = new System.Drawing.Size(96, 24);
			this.checkAbsent.TabIndex = 2;
			this.checkAbsent.Tag = "4";
			this.checkAbsent.Text = "Чөлөөтэй";
			this.checkAbsent.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
			// 
			// checkAvl
			// 
			this.checkAvl.Checked = true;
			this.checkAvl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkAvl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.checkAvl.Location = new System.Drawing.Point(16, 32);
			this.checkAvl.Name = "checkAvl";
			this.checkAvl.Size = new System.Drawing.Size(88, 24);
			this.checkAvl.TabIndex = 1;
			this.checkAvl.Tag = "2";
			this.checkAvl.Text = "Сурч байгаа";
			this.checkAvl.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
			// 
			// checkNew
			// 
			this.checkNew.Checked = true;
			this.checkNew.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.checkNew.Location = new System.Drawing.Point(16, 8);
			this.checkNew.Name = "checkNew";
			this.checkNew.Size = new System.Drawing.Size(80, 24);
			this.checkNew.TabIndex = 0;
			this.checkNew.Tag = "1";
			this.checkNew.Text = "Шинэ";
			this.checkNew.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
			// 
			// FilterDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(234, 176);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonCancel,
																		  this.buttonOk,
																		  this.checkGrade,
																		  this.checkLeft,
																		  this.checkAbsent,
																		  this.checkAvl,
																		  this.checkNew});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FilterDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Оюутнуудыг төлвөөр ялгаж харах";
			this.ResumeLayout(false);

		}
		#endregion
		
		private void checkFilter_CheckedChanged(object sender, System.EventArgs e) {
			CheckBox check = sender as CheckBox;
			if (check != null) {
				int s;
				try {
					s = Convert.ToInt32(check.Tag);
					if (check.Checked) 
						state |= s;
					else 
						state &= ~s;
				}
				catch (Exception) {}
			}
		}
		public int State {
			get {
				return state;
			}
			set {
				state = value;
			}
		}
	}
}
