using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal void SetupSetting()
        {
            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), "Setting");

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                return;
            }
            else
                "false".ToString();

            var text = File.ReadAllText(path_FILE_filename_with_extension);

            var split_INITIAL = text.Split(new String[] { "\n" }, StringSplitOptions.None);

            foreach (String stringItem in split_INITIAL)
            {
                var format = stringItem.Trim();

                var split_SUBSEQUENT = format.Split();

                Boolean hasLength;

                hasLength = (split_SUBSEQUENT.Length > 0) is true;

                if (hasLength is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var left = split_SUBSEQUENT[0];

                var right = split_SUBSEQUENT[split_SUBSEQUENT.Length - 1];

                Boolean isExtension;

                isExtension = (left == nameof(Architecture.Extension)) is true;

                if (isExtension is true)
                {
                    Architecture.Extension = right;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
