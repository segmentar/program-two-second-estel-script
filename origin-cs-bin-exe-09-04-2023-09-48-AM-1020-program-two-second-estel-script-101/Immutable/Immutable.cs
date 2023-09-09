using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class Immutable
    {
        internal static String SettingName;

        internal static String ProgramName;

        internal static String WorkingDirectoryName;

        internal static String WorkingDirectoryIdentity;

        static Immutable()
        {
            SettingName = "Setting";

            ProgramName = Assembly.GetEntryAssembly().GetName().Name;

            WorkingDirectoryName = "Working Directory";

            WorkingDirectoryIdentity = Path.GetRandomFileName();

            return;
        }
    }
}
