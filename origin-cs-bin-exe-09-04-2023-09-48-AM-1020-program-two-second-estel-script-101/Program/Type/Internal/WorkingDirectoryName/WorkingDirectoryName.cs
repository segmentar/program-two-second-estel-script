using Core;

namespace Core
{
	using System;

    internal partial class Program
	{
		internal String WorkingDirectoryName()
		{
			String stringResult = default;

			var name = $"{Immutable.WorkingDirectoryName}-{Immutable.ProgramName}-{Immutable.WorkingDirectoryIdentity}";

			var lower = name.ToLower();

			stringResult = lower;

			return stringResult;
		}
	}
}