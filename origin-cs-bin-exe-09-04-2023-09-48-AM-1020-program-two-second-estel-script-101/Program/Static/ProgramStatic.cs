using Core;

namespace Core
{
	using System;

    using System.IO;

    internal partial class Program
	{
		internal static String[] ArgumentArray;

		internal static void Main(params String[] array_ARGUMENT)
		{
			ArgumentArray = array_ARGUMENT;

			Bundle();

			return;
		}

		internal static void Procedure()
		{
            Free();

            ProgramPolicy.ProgramDebugPolicy = true;

			ProgramPolicy.ProgramInfoPolicy = true;

			FormBinaryPolicy.FormBinaryDebugPolicy = true;

			FormBinaryPolicy.FormBinaryInfoPolicy = true;

			ExpressionPolicy.ExpressionDebugPolicy = true;

			ExpressionPolicy.ExpressionInfoPolicy = true;

			return;
		}

		internal static void Manual()
		{
			ProgramModule programModule = ProgramModule.ProgramModuleDefault();

			Console.Clear();

			Console.Out.WriteLine($"{nameof(programModule.Second.FileArray)}: {programModule.Second.FileArray.Length}");

			Console.Out.WriteLine($"{nameof(programModule.Second.FolderArray)}: {programModule.Second.FolderArray.Length}");

			Console.Out.WriteLine($"{nameof(programModule.Third.FormBinaryArray)}: {programModule.Third.FormBinaryArray.Length}");

			Console.Out.WriteLine(Console.Out.NewLine);

			Console.Out.WriteLine(nameof(programModule.Second.FileArray));

			Console.Out.WriteLine($"{String.Join('\n'.ToString(), programModule.Second.FileArray)}");

			Console.Out.WriteLine(nameof(programModule.Second.FolderArray));

			Console.Out.WriteLine($"{String.Join('\n'.ToString(), programModule.Second.FolderArray)}");

			Console.Out.WriteLine(nameof(programModule.Third.FormBinaryArray));

			Console.Out.WriteLine($"{String.Join('\n'.ToString(), (Object[])(programModule.Third.FormBinaryArray as Array))}");

			Console.In.ReadLine();

			return;
		}

		internal static void Raise()
		{
			if (ProgramPolicy.ProgramInfoPolicy is true)
			{
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-ProgramInfo", ProgramPolicy.ProgramArrayList.ToArray());
            }
            else
				"false".ToString();

			if (FormBinaryPolicy.FormBinaryInfoPolicy is true)
			{
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-FormBinaryInfo", FormBinaryPolicy.FormBinaryArrayList.ToArray());
            }
            else
				"false".ToString();

			if (ExpressionPolicy.ExpressionInfoPolicy is true)
			{
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-ExpressionInfo", ExpressionPolicy.ExpressionArrayList.ToArray());
            }
            else
				"false".ToString();

            Explorer(Directory.GetCurrentDirectory(), 1);

            return;
		}

		internal static void Bundle()
		{

#if DEBUG
			Procedure();
#endif

			Manual();

#if DEBUG
			Raise();
#endif

			return;
		}

		static Program()
		{
			return;
		}
	}
}