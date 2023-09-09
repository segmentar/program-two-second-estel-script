using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramFileSetSurface(String[] directoryArray, String extension)
        {
            String[] arrayResult = default;

            var list = ProgramFileSet(directoryArray, extension);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        } 
    }
}
