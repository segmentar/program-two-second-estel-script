using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class FormBinarySequence
    {
        public FormBinary Result { get; set; } = default;

        public FormBinarySequence(String file, Boolean debug)
        {
            Debug(file, debug);

            Boolean endianFormat;

            Int32 stringCodec, chunkSize, startBoundary;

            Int32 headerAddress, contentAddress, localLineAddress, globalLineAddress;

            FileStream fileStream;

            fileStream = File.OpenRead(file);

            BinaryReader binaryReader;

            using (binaryReader = new BinaryReader(fileStream, Encoding.Default, true))
            {
                endianFormat = binaryReader.ReadBoolean();

                stringCodec = binaryReader.ReadInt32();

                chunkSize = binaryReader.ReadInt32();

                startBoundary = binaryReader.ReadInt32();

                headerAddress = binaryReader.ReadInt32();

                contentAddress = binaryReader.ReadInt32();

                localLineAddress = binaryReader.ReadInt32();

                globalLineAddress = binaryReader.ReadInt32();

                binaryReader.Close();

                binaryReader.Dispose();
            }

            this.Result = new FormBinary(file, fileStream, endianFormat, stringCodec, chunkSize, startBoundary, headerAddress, contentAddress, localLineAddress, globalLineAddress, debug);

            return;
        }

        ~FormBinarySequence()
        {
            return;
        }
    }
}
