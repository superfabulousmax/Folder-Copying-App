namespace FileCopying
{
	partial class CopyingPopup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPopupOk = new System.Windows.Forms.Button();
			this.lblOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPopupOk
			// 
			this.btnPopupOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnPopupOk.Location = new System.Drawing.Point(334, 348);
			this.btnPopupOk.Name = "btnPopupOk";
			this.btnPopupOk.Size = new System.Drawing.Size(75, 23);
			this.btnPopupOk.TabIndex = 0;
			this.btnPopupOk.Text = "Ok";
			this.btnPopupOk.UseVisualStyleBackColor = true;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(51, 34);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(39, 13);
			this.lblOutput.TabIndex = 1;
			this.lblOutput.Text = "Output";
			// 
			// CopyingPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnPopupOk);
			this.Name = "CopyingPopup";
			this.Text = "CopyingPopup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPopupOk;
		public System.Windows.Forms.Label lblOutput;
	}
}