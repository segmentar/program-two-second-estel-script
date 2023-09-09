using Core;

namespace Core
{
	using System;

    public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleDefault()
		{
			Program program;

			program = Program.MakeProgramDefaultSurface();

			program.SetupSetting();

			program.SetupConsole();

			ProgramModule module;

			module = new ProgramModule();

			module.Program = program;

			module = ProgramModuleFunctionOne(module);

			module = ProgramModuleFunctionTwo(module);

			module = ProgramModuleFunctionThree(module);

			Console.Clear();

			Console.Out.WriteLine(module.First.WorkingDirectory);

			Console.In.ReadLine();

			module.Third.Expression.Render(module.First.WorkingDirectory, "program");

			return module;
		}
	}
}