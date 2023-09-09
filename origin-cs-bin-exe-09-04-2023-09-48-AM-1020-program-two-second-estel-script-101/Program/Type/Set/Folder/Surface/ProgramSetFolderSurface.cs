using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramFolderSetSurface(String directory)
        {
            String[] arrayResult = default;

            var list = ProgramFolderSet(directory);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        } 
    }
}
