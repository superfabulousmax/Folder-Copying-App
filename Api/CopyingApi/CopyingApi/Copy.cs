using System;
using System.IO;
using static CopyingApi.OutputEventHandler;

namespace CopyingApi
{
	public class OutputEventArgs : EventArgs
	{
		public string target;
		public string source;
	}

	public class Copy
	{
		public event DisplayHandler DisplayCopy;

		public Copy()
		{
		}

		public void Run(string source, string target)
		{
			RunCopyProcess(source, target);
		}

		/// <summary>
		/// Recursively copy source to target
		/// </summary>
		private void RunCopyProcess(string source, string target)
		{
			try
			{
				var sourceInfo = new DirectoryInfo(source);
				var sourceDirs = sourceInfo.GetDirectories();
				var sourceFiles = sourceInfo.GetFiles();
				if (Directory.Exists(target) == false)
				{
					Directory.CreateDirectory(target);
				}
				foreach(var file in sourceFiles)
				{

					var destination = Path.Combine(target, file.Name);
					file.CopyTo(destination, true);
					var args = $"Copied {file.FullName} to {destination}";
					OnFileCopied(new OutputEventArgs { source = file.FullName, target = destination });
				}

				foreach (var dir in sourceDirs)
				{
					// recurse for sub directories
					RunCopyProcess(dir.FullName, Path.Combine(target, dir.Name));
				}
			}
			catch(DirectoryNotFoundException e)
			{
				Console.WriteLine(e.Message);
			}
		}

		protected virtual void OnFileCopied(OutputEventArgs e)
		{
			DisplayCopy?.Invoke(this, e);
		}
	}
}
