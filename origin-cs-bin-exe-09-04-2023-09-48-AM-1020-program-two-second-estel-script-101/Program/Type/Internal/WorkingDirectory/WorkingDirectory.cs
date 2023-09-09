using Core;

namespace Core
{
	using System;

    using System.IO;

    internal partial class Program
	{
		internal String WorkingDirectory(String currentDirectory)
		{
			String stringResult = default;

			var path_DIRECTORY_full_name__WORKING_DIRECTORY = Path.Combine(currentDirectory, WorkingDirectoryName());

			stringResult = path_DIRECTORY_full_name__WORKING_DIRECTORY;

			return stringResult;
		}
	}
}