using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class FormBinary
    {
        public static Tuple<Int32, String[]> ForgeGlobalLineTuple(FormBinaryData data)
        {
            Tuple<Int32, String[]> tupleResult = default;

            Int32 length;

            String[] stringArray;

            BinaryReader binaryReader;

            using (binaryReader = new BinaryReader(data.Stream, Encoding.GetEncoding(data.StringCodec), true))
            {
                binaryReader.BaseStream.Seek(data.GlobalLineAddress, SeekOrigin.Begin);

                length = binaryReader.ReadInt32();

                stringArray = new String[length];

                var indexer = 0;

                do
                {
                    Boolean shouldStop;

                    shouldStop = (indexer == length) is true;

                    if (shouldStop is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var ordinal = (indexer + 1);

                    binaryReader.BaseStream.Seek(data.GlobalLineAddress + (data.ChunkSize * ordinal), SeekOrigin.Begin);

                    stringArray[indexer] = binaryReader.ReadString();

                    indexer = indexer + 1;

                    continue;

                } while (true);

                binaryReader.Close();

                binaryReader.Dispose();
            }

            Tuple<Int32, String[]> tuple;

            tuple = new Tuple<Int32, String[]>(length, stringArray);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
