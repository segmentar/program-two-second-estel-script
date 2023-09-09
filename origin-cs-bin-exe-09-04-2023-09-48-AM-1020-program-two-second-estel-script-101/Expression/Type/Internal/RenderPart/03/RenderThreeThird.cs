using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial class Expression
    {
        public static BinaryWriter RenderThreeThird(IList expression_ARRAY_LIST, MemoryStream memoryStream)
        {
            BinaryWriter binaryWriterResult = default;

            BinaryWriter binaryWriter;

            using (binaryWriter = new BinaryWriter(memoryStream, Architecture.StringCodec, true))
            {
                var ordinal = 1;

                foreach (Expression expression in ExpressionSortSetSurface(expression_ARRAY_LIST))
                {
                    var indexer = ordinal - 1;

                    binaryWriter.BaseStream.Seek(((ordinal - 1) * (16 * indexer)), SeekOrigin.Begin);

                    binaryWriter.Write(expression.StringIdentity);

                    binaryWriter.BaseStream.Seek(((ordinal - 1) * (32 * indexer)), SeekOrigin.Begin);

                    binaryWriter.Write((expression.ArrayList[0] as Expression).StringIdentity);

                    ordinal = ordinal + 1;

                    continue;
                }

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            binaryWriterResult = binaryWriter;

            return binaryWriterResult;
        }
    }
}
