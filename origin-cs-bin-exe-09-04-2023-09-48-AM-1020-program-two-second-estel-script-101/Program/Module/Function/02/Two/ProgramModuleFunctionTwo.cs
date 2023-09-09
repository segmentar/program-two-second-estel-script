using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
		{
			String[] directoryArray, fileArray;

            directoryArray = Program.ProgramFolderSetSurface(module.First.CurrentDirectory);

			fileArray = Program.ProgramFileSetSurface(directoryArray, Architecture.Extension);

			ProgramModuleFunctionSecond second;

			second = new ProgramModuleFunctionSecond(fileArray, directoryArray);

			module.Second = second;

			return module;
		}
	}
}