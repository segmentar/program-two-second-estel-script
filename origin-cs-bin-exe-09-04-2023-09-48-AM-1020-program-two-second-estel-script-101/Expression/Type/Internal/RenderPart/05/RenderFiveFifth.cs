using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static MemoryStream RenderFiveFifth(Int32 address_ORDINAL_TABLE)
        {
            MemoryStream memoryStreamResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            RenderSixSixth(address_ORDINAL_TABLE, memoryStream);

            memoryStreamResult = memoryStream;

            return memoryStreamResult;
        }
    }
}
