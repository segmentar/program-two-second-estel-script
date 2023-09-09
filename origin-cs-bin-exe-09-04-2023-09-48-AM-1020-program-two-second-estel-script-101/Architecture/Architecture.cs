using Core;

namespace Core
{
    using System;

    using System.Text;

    internal static class Architecture
    {
        internal static String Extension;

        internal static Encoding StringCodec;

        static Architecture()
        {
            Extension = "Sample";

            StringCodec = Encoding.Default;

            return;
        }
    }
}
