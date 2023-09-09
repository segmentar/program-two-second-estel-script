using Core;

namespace Core
{
	using System;

	public partial class ProgramModuleFunctionFirst
	{
		public String CurrentFile;

		public String CurrentDirectory;

		public String WorkingDirectory;

		public ProgramModuleFunctionFirst(String currentFile, String currentDirectory, String workingDirectory)
        {
			this.CurrentFile = currentFile;

			this.CurrentDirectory = currentDirectory;

			this.WorkingDirectory = workingDirectory;

            return;
        }

        ~ProgramModuleFunctionFirst()
		{
			return;
		}
	}
}