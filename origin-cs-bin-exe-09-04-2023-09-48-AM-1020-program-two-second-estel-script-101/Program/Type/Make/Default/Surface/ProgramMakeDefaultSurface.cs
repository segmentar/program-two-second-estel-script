using Core;

namespace Core
{
	using System;

	internal partial class Program
	{
		internal static Program MakeProgramDefaultSurface()
		{
			Program programResult = default;

			programResult = MakeProgramDefault(ProgramPolicy.ProgramDebugPolicy);

			return programResult;
		}
	}
}