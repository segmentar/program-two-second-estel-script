using Core;

namespace Core
{
	using System;

	internal partial class ProgramSequence
	{
		internal Program Result { get; set; } = default;

		internal ProgramSequence(Boolean debug)
		{
			Debug(debug);

			Program program;

			program = new Program(debug);

			this.Result = program;

			return;
		}

		~ProgramSequence()
		{
			return;
		}
	}
}