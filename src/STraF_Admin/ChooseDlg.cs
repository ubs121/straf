using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace STraF {
	/// <summary>
	/// Summary description for ChooseDlg.
	/// </summary>
	public class ChooseDlg : Form {
		private Label labelClass;
		public ComboBox comboProf;
		private Label labelCourse;
		private Button buttonCancel;
		private Button buttonOk;
		public System.Windows.Forms.TextBox textCourse;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChooseDlg() {
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
			this.labelClass = new System.Windows.Forms.Label();
			this.comboProf = new System.Windows.Forms.ComboBox();
			this.labelCourse = new System.Windows.Forms.Label();
			this.textCourse = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelClass
			// 
			this.labelClass.Location = new System.Drawing.Point(8, 8);
			this.labelClass.Name = "labelClass";
			this.labelClass.Size = new System.Drawing.Size(60, 23);
			this.labelClass.TabIndex = 8;
			this.labelClass.Text = "Мэргэжил:";
			// 
			// comboProf
			// 
			this.comboProf.Location = new System.Drawing.Point(80, 8);
			this.comboProf.Name = "comboProf";
			this.comboProf.Size = new System.Drawing.Size(145, 21);
			this.comboProf.TabIndex = 9;
			// 
			// labelCourse
			// 
			this.labelCourse.Location = new System.Drawing.Point(8, 40);
			this.labelCourse.Name = "labelCourse";
			this.labelCourse.Size = new System.Drawing.Size(60, 23);
			this.labelCourse.TabIndex = 10;
			this.labelCourse.Text = "Курс:";
			// 
			// textCourse
			// 
			this.textCourse.Location = new System.Drawing.Point(80, 40);
			this.textCourse.Name = "textCourse";
			this.textCourse.Size = new System.Drawing.Size(145, 20);
			this.textCourse.TabIndex = 11;
			this.textCourse.Text = "";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(152, 72);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 15;
			this.buttonCancel.Text = "&Cancel";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(64, 72);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 14;
			this.buttonOk.Text = "&Ok";
			// 
			// Choose
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(240, 111);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.labelClass,
																		  this.comboProf,
																		  this.labelCourse,
																		  this.textCourse,
																		  this.buttonCancel,
																		  this.buttonOk});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Choose";
			this.ShowInTaskbar = false;
			this.Text = "Сонгох";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

