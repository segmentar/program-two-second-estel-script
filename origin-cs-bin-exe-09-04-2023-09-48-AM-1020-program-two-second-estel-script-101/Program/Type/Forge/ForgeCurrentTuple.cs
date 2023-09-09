using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal partial class Program
    {
        internal static Tuple<String, String> ForgeCurrentTuple__FILE_DIRECTORY()
        {
            Tuple<String, String> tupleResult = default;

            var path_FILE_filename_with_extension__CURRENT = Assembly.GetEntryAssembly().Location;

            var path_DIRECTORY_full_name__CURRENT = Path.GetDirectoryName(path_FILE_filename_with_extension__CURRENT);

            Tuple<String, String> currentTuple;

            currentTuple = new Tuple<String, String>(path_FILE_filename_with_extension__CURRENT, path_DIRECTORY_full_name__CURRENT);

            tupleResult = currentTuple;

            return tupleResult;
        }
    }
}
