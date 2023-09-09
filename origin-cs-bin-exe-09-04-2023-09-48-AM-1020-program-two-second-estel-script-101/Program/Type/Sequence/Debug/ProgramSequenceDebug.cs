using Core;

namespace Core
{
	using System;

	internal partial class ProgramSequence
	{
		internal static void Debug(Boolean debug)
		{
			if (debug is false)
			{
				return;
			}
			else
				"false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Program) + ' ' + "::" + ' ' + nameof(ProgramSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

			Program.Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Debug}-ProgramDebug", descriptor);
            
			return;
		}
	}
}