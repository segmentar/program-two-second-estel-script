using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial class Expression
    { 
        public static Byte[] RenderOneFirst(IList expression_ARRAY_LIST)
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            memoryStream = RenderTwoSecond(expression_ARRAY_LIST);

            arrayResult = memoryStream.ToArray();

            memoryStream.Close();

            memoryStream.Dispose();

            return arrayResult;
        }
    }
}
