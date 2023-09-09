using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial class Expression
    {
        public static MemoryStream RenderTwoSecond(IList expression_ARRAY_LIST)
        {
            MemoryStream memoryStreamResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            RenderThreeThird(expression_ARRAY_LIST, memoryStream);

            memoryStreamResult = memoryStream;

            return memoryStreamResult;
        }
    }
}
