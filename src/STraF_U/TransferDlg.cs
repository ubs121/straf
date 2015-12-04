using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace STraF_U {
	/// <summary>
	/// Summary description for Transfer.
	/// </summary>
	public class TransferDlg : Form {
		private Label label1;
		private Label label3;
		private Label label2;
		public TextBox textSize;
		private Button buttonOk;
		private Button buttonCancel;
		public DateTimePicker dateDate;
		public ComboBox comboDesc;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TransferDlg() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			comboDesc.SelectedIndex = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TransferDlg));
			this.label1 = new System.Windows.Forms.Label();
			this.textSize = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.dateDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.comboDesc = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Хэмжээ:";
			// 
			// textSize
			// 
			this.textSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSize.Location = new System.Drawing.Point(104, 8);
			this.textSize.Name = "textSize";
			this.textSize.Size = new System.Drawing.Size(152, 20);
			this.textSize.TabIndex = 1;
			this.textSize.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Огноо:";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(88, 112);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 6;
			this.buttonOk.Text = "&Ok";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(176, 112);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "&Cancel";
			// 
			// dateDate
			// 
			this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateDate.Location = new System.Drawing.Point(104, 72);
			this.dateDate.Name = "dateDate";
			this.dateDate.ShowUpDown = true;
			this.dateDate.Size = new System.Drawing.Size(152, 20);
			this.dateDate.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Зориулалт:";
			// 
			// comboDesc
			// 
			this.comboDesc.Items.AddRange(new object[] {
														   "сургалтын төлбөр",
														   "тэтгэлэг",
														   "замын зардал"});
			this.comboDesc.Location = new System.Drawing.Point(104, 40);
			this.comboDesc.Name = "comboDesc";
			this.comboDesc.Size = new System.Drawing.Size(152, 21);
			this.comboDesc.TabIndex = 3;
			// 
			// TransferDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(274, 151);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dateDate,
																		  this.label3,
																		  this.comboDesc,
																		  this.label2,
																		  this.textSize,
																		  this.label1,
																		  this.buttonCancel,
																		  this.buttonOk});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TransferDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Шилжүүлгэ";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
