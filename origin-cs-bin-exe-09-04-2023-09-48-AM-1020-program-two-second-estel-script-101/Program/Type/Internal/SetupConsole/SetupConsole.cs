using Core;

namespace Core
{
	using System;

	internal partial class Program
	{
		internal void SetupConsole()
		{
			Console.BackgroundColor = ConsoleColor.Blue;

			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.Clear();

			do
			{
				ConsoleReposition(true);

				Console.Clear();

				Console.Out.WriteLine(ConsoleDescriptor());

				ConsoleReposition(false);

				var line = Console.In.ReadLine();

				var split = line.Split();

				var lower = line.ToLower();

				Boolean hasLength, isEscape;

				hasLength = (split.Length > 0) is true;

				isEscape = (lower == "escape") is true;

				if (hasLength is true)
				{
					var first = split[0];

					var last = split[split.Length - 1];

					Boolean isExtension;

					isExtension = (first == nameof(Architecture.Extension)) is true;

					if (isExtension is true)
					{
						Architecture.Extension = last;
					}
					else
						"false".ToString();
				}
				else
					"false".ToString();

				if (isEscape is true)
				{
					Console.Clear();

					break;
				}
				else
					"false".ToString();

				continue;

			} while (true);

			return;
		}
	}
}