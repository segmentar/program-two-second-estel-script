using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static void RenderSixSixth(Int32 address_ORDINAL_TABLE, MemoryStream memoryStream)
        {
            BinaryWriter binaryWriter;

            using (binaryWriter = new BinaryWriter(memoryStream, Architecture.StringCodec, true))
            {
                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return;
        }
    }
}
