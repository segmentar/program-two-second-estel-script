using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Render(String path, params Object[] objectArray)
        {
            var dash = Convert.ToChar(45);

            var split = path.Split(dash);

            var path_NAME_directory = String.Empty;

            foreach (String stringItem in split)
            {
                path_NAME_directory = Path.Combine(path_NAME_directory, stringItem);

                continue;
            }

            var path_directory_with_count = (path_NAME_directory + ' ' + objectArray.Length);

            var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), path_directory_with_count);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var zeroth = -1;

            foreach (Object objectItem in objectArray)
            {
                zeroth = zeroth + 1;

                Boolean isDefault;

                isDefault = (objectItem == default) is true;

                if (isDefault is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var ordinal = (zeroth + 1);

                var last = split[split.Length - 1];

                var path_NAME_file = last + '-' + ordinal + '-' + objectArray.Length;

                var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, path_NAME_file);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

                if (File.Exists(path_FILE_filename_with_extension) is false)
                {
                    StreamWriter streamWriter;

                    using (streamWriter = File.CreateText(path_FILE_filename_with_extension))
                    {
                        String stringItem;

                        stringItem = objectItem.ToString();

                        streamWriter.WriteLine(stringItem);

                        streamWriter.Flush();

                        streamWriter.Close();

                        streamWriter.Dispose();
                    }
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }

    }
}
