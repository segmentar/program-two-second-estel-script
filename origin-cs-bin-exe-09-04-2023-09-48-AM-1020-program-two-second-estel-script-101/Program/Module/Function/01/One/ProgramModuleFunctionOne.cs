using Core;

namespace Core
{
	using System;

    using System.IO;

    public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
		{
			var tuple = Program.ForgeCurrentTuple__FILE_DIRECTORY();

			String workingDirectory;

			workingDirectory = module.Program.WorkingDirectory(tuple.Item2);

			if (Directory.Exists(workingDirectory) is false)
			{
				DirectoryInfo directoryInfo;

				directoryInfo = Directory.CreateDirectory(workingDirectory);

				workingDirectory = directoryInfo.FullName;
			}
			else
				"false".ToString();

			ProgramModuleFunctionFirst first;

			first = new ProgramModuleFunctionFirst(tuple.Item1, tuple.Item2, workingDirectory);

			module.First = first;

			return module;
		}
	}
}