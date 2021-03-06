using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace STraF {
	/// <summary>
	/// Summary description for PermissionDlg.
	/// </summary>
	public class PermissionDlg : Form {
		internal ListView listPermission;
		private Button buttonOk;
		private ColumnHeader columnHeaderObject;
		private ColumnHeader columnHeaderSelect;
		private ColumnHeader columnHeaderUpdate;
		private ColumnHeader columnHeaderInsert;
		private ColumnHeader columnHeaderDelete;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PermissionDlg()	{
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
			if( disposing )	{
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
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PermissionDlg));
			this.listPermission = new System.Windows.Forms.ListView();
			this.columnHeaderObject = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderSelect = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderUpdate = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderInsert = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDelete = new System.Windows.Forms.ColumnHeader();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listPermission
			// 
			this.listPermission.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.listPermission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listPermission.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							 this.columnHeaderObject,
																							 this.columnHeaderSelect,
																							 this.columnHeaderUpdate,
																							 this.columnHeaderInsert,
																							 this.columnHeaderDelete});
			this.listPermission.FullRowSelect = true;
			this.listPermission.GridLines = true;
			this.listPermission.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listPermission.LabelWrap = false;
			this.listPermission.Location = new System.Drawing.Point(8, 8);
			this.listPermission.MultiSelect = false;
			this.listPermission.Name = "listPermission";
			this.listPermission.Size = new System.Drawing.Size(360, 160);
			this.listPermission.TabIndex = 0;
			this.listPermission.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderObject
			// 
			this.columnHeaderObject.Text = "Хvснэгт";
			this.columnHeaderObject.Width = 100;
			// 
			// columnHeaderSelect
			// 
			this.columnHeaderSelect.Text = "Харах";
			// 
			// columnHeaderUpdate
			// 
			this.columnHeaderUpdate.Text = "Өөрчлөх";
			// 
			// columnHeaderInsert
			// 
			this.columnHeaderInsert.Text = "Нэмэх";
			// 
			// columnHeaderDelete
			// 
			this.columnHeaderDelete.Text = "Хасах";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(288, 176);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "Ok";
			// 
			// Permission
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(378, 207);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonOk,
																		  this.listPermission});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Permission";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Хандах Зөвшөөрөл";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

