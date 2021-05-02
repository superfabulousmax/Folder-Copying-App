using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopying
{
	public static class ErrorMessage
	{
		public static readonly string EMPTY_FOLDER = "Please select both a target and source folder";
		public static readonly string SAME_FOLDER = "Please make sure that target and source are different folders";
		public static readonly string INVAILD_PATH = "Folder does not exist";
		public static readonly string SAME_PATH = "Please make sure source and target folders are different";
	}
}
