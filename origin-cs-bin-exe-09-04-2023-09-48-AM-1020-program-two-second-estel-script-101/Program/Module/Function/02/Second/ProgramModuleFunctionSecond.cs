using Core;

namespace Core
{
	using System;

	public partial class ProgramModuleFunctionSecond
	{
		public String[] FileArray;

		public String[] FolderArray;

		public ProgramModuleFunctionSecond(String[] fileArray, String[] folderArray)
		{
			this.FileArray = fileArray;

			this.FolderArray = folderArray;

			return;
		}

		~ProgramModuleFunctionSecond()
		{
			return;
		}
	}
}