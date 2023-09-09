using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class FormBinary
    {
        public static String ForgeContent(FormBinaryData data)
        {
            String stringResult = default;

            BinaryReader binaryReader;

            using (binaryReader = new BinaryReader(data.Stream, Encoding.GetEncoding(data.StringCodec), true))
            {
                binaryReader.BaseStream.Seek(data.ContentAddress, SeekOrigin.Begin);

                stringResult = binaryReader.ReadString();

                binaryReader.Close();

                binaryReader.Dispose();
            }

            return stringResult;
        }
    }
}
