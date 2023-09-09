using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public void Render(String workingDirectory, String componentName)
        {
            var path_DIRECTORY_full_name = Path.Combine(workingDirectory, componentName);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, componentName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "bin");

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                Byte[] nameTableByteArray, ordinalTableByteArray;

                nameTableByteArray = RenderOneFirst(ArrayList);

                Int32 addressOfOrdinalTable;

                addressOfOrdinalTable = nameTableByteArray.Length;

                ordinalTableByteArray = RenderFourFourth(addressOfOrdinalTable);

                FileStream fileStream;

                using (fileStream = File.Create(path_FILE_filename_with_extension))
                {
                    fileStream.Write(nameTableByteArray, 0, nameTableByteArray.Length);                  

                    fileStream.Flush();

                    fileStream.Close();

                    fileStream.Dispose();
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
