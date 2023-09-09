using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Free()
        {
            foreach (String stringItem in Enum.GetNames(typeof(ProgramCode.ObservableDirectory)))
            {
                var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), stringItem);

                if (Directory.Exists(path_DIRECTORY_full_name) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                Directory.Delete(path_DIRECTORY_full_name, true);

                continue;
            }

            return;
        }
    }
}
