namespace FileCopying
{
	partial class MainForm
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
			this.lblSourceDir = new System.Windows.Forms.Label();
			this.btnSourceDir = new System.Windows.Forms.Button();
			this.lblTargetDir = new System.Windows.Forms.Label();
			this.btnTarget = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.linkLabelSource = new System.Windows.Forms.LinkLabel();
			this.linkLabelTarget = new System.Windows.Forms.LinkLabel();
			this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lblSourceDir
			// 
			this.lblSourceDir.AutoSize = true;
			this.lblSourceDir.Location = new System.Drawing.Point(52, 22);
			this.lblSourceDir.Name = "lblSourceDir";
			this.lblSourceDir.Size = new System.Drawing.Size(96, 13);
			this.lblSourceDir.TabIndex = 0;
			this.lblSourceDir.Text = "Choose Source Dir";
			// 
			// btnSourceDir
			// 
			this.btnSourceDir.Location = new System.Drawing.Point(176, 17);
			this.btnSourceDir.Name = "btnSourceDir";
			this.btnSourceDir.Size = new System.Drawing.Size(75, 23);
			this.btnSourceDir.TabIndex = 1;
			this.btnSourceDir.Text = "Source";
			this.btnSourceDir.UseVisualStyleBackColor = true;
			this.btnSourceDir.Click += new System.EventHandler(this.btnSourceDir_Click);
			// 
			// lblTargetDir
			// 
			this.lblTargetDir.AutoSize = true;
			this.lblTargetDir.Location = new System.Drawing.Point(52, 64);
			this.lblTargetDir.Name = "lblTargetDir";
			this.lblTargetDir.Size = new System.Drawing.Size(93, 13);
			this.lblTargetDir.TabIndex = 2;
			this.lblTargetDir.Text = "Choose Target Dir";
			// 
			// btnTarget
			// 
			this.btnTarget.Location = new System.Drawing.Point(176, 59);
			this.btnTarget.Name = "btnTarget";
			this.btnTarget.Size = new System.Drawing.Size(75, 23);
			this.btnTarget.TabIndex = 3;
			this.btnTarget.Text = "Target";
			this.btnTarget.UseVisualStyleBackColor = true;
			this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(666, 339);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 4;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(49, 344);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(181, 13);
			this.lblInfo.TabIndex = 5;
			this.lblInfo.Text = "Select to copy source to target folder";
			// 
			// linkLabelSource
			// 
			this.linkLabelSource.AutoSize = true;
			this.linkLabelSource.Location = new System.Drawing.Point(278, 22);
			this.linkLabelSource.Name = "linkLabelSource";
			this.linkLabelSource.Size = new System.Drawing.Size(39, 13);
			this.linkLabelSource.TabIndex = 6;
			this.linkLabelSource.TabStop = true;
			this.linkLabelSource.Text = "source";
			this.linkLabelSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSource_LinkClicked);
			// 
			// linkLabelTarget
			// 
			this.linkLabelTarget.AutoSize = true;
			this.linkLabelTarget.Location = new System.Drawing.Point(278, 64);
			this.linkLabelTarget.Name = "linkLabelTarget";
			this.linkLabelTarget.Size = new System.Drawing.Size(34, 13);
			this.linkLabelTarget.TabIndex = 7;
			this.linkLabelTarget.TabStop = true;
			this.linkLabelTarget.Text = "target";
			this.linkLabelTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTarget_LinkClicked);
			// 
			// richTextBoxOutput
			// 
			this.richTextBoxOutput.Location = new System.Drawing.Point(52, 104);
			this.richTextBoxOutput.Name = "richTextBoxOutput";
			this.richTextBoxOutput.ReadOnly = true;
			this.richTextBoxOutput.Size = new System.Drawing.Size(689, 219);
			this.richTextBoxOutput.TabIndex = 8;
			this.richTextBoxOutput.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBoxOutput);
			this.Controls.Add(this.linkLabelTarget);
			this.Controls.Add(this.linkLabelSource);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnTarget);
			this.Controls.Add(this.lblTargetDir);
			this.Controls.Add(this.btnSourceDir);
			this.Controls.Add(this.lblSourceDir);
			this.Name = "MainForm";
			this.Text = "Sinead\'s Folder Copying App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSourceDir;
		private System.Windows.Forms.Button btnSourceDir;
		private System.Windows.Forms.Label lblTargetDir;
		private System.Windows.Forms.Button btnTarget;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.LinkLabel linkLabelSource;
		private System.Windows.Forms.LinkLabel linkLabelTarget;
		private System.Windows.Forms.RichTextBox richTextBoxOutput;
	}
}

