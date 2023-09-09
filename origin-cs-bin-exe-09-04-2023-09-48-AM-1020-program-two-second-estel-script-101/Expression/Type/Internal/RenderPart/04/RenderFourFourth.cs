using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static Byte[] RenderFourFourth(Int32 address_ORDINAL_TABLE)
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            memoryStream = RenderFiveFifth(address_ORDINAL_TABLE);

            arrayResult = memoryStream.ToArray();

            memoryStream.Close();

            memoryStream.Dispose();

            return arrayResult;
        }
    }
}
