using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CopyingApi;
using System.ComponentModel;
using System.Diagnostics;

namespace FileCopying
{
	public partial class MainForm : Form
	{
		public string source = "";
		public string target = "";
		private Copy copyApi;
		private BackgroundWorker worker = new BackgroundWorker();

		// ensure thread-safe calls to windows forms
		delegate void SetOutput(object sender, OutputEventArgs args);
		delegate void WorkHandler(object sender, DoWorkEventArgs e);

		public MainForm()
		{
			copyApi = new Copy();
			copyApi.DisplayCopy += WriteToOutput;
			InitializeComponent();
			worker.ProgressChanged += new ProgressChangedEventHandler(progressChangedHandler);
			worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(runCompletedHandler);
			worker.DoWork += new DoWorkEventHandler(doWorkHandler);
			worker.WorkerReportsProgress = true;
		}



		private void doWorkHandler(object sender, DoWorkEventArgs e)
		{
			if(btnCopy.InvokeRequired)
			{
				var safeThread = new WorkHandler(doWorkHandler);
				btnCopy.Invoke(safeThread, sender, e);
			}
			else
			{
				btnCopy.Enabled = false;
			}
			CopyFiles();
		}

		private void runCompletedHandler(object sender, RunWorkerCompletedEventArgs e)
		{
			btnCopy.Enabled = true;
		}

		private void progressChangedHandler(object sender, ProgressChangedEventArgs e)
		{
			Console.WriteLine("Progress changed");
		}

		private void btnSourceDir_Click(object sender, EventArgs e)
		{
			source = GetFolder("Choose source folder");
			linkLabelSource.Text = source;
		}

		private void btnTarget_Click(object sender, EventArgs e)
		{
			target = GetFolder("Choose target folder");
			linkLabelTarget.Text = target;
		}

		private string GetFolder(string message = "")
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				dialog.Description = message;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					return dialog.SelectedPath;
				}
			}
			return string.Empty;
		}

		private async void btnCopy_Click(object sender, EventArgs e)
		{
			Console.WriteLine($"Copy {source} to {target}");
			if (target == "" || source == "")
			{
				lblInfo.Text = ErrorMessage.EMPTY_FOLDER;
				lblInfo.ForeColor = Color.Red;
			}
			else if (target == source)
			{
				lblInfo.Text = ErrorMessage.SAME_FOLDER;
				lblInfo.ForeColor = Color.Red;
			}
			else
			{
				// since using a file dialog, it should return valid folder paths
				// but always good incase the implementation changes to have
				// edge case checks
				if(Directory.Exists(target) == false ||
					Directory.Exists(source) == false)
				{
					lblInfo.Text = ErrorMessage.INVAILD_PATH;
					lblInfo.ForeColor = Color.Red;
				}
				else
				{
					richTextBoxOutput.Text = "";
					lblInfo.Text = $"Copying {source} to {target}";
					lblInfo.ForeColor = Color.Green;
					worker.RunWorkerAsync();
				}
			}
		}

		private void WriteToOutput(object sender, OutputEventArgs args)
		{
			if(richTextBoxOutput.InvokeRequired)
			{
				var safeThread = new SetOutput(WriteToOutput);
				richTextBoxOutput.Invoke(safeThread, sender, args);
			}
			else
			{
				var message = $"Copied {args.source} to {args.target}";
				richTextBoxOutput.Text += $"{message}\n";
			}
		}

		private void CopyFiles()
		{
			copyApi.Run(source, target);
		}

		private void linkLabelTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("explorer.exe", target);
		}

		private void linkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("explorer.exe", source);
		}
	}
}
