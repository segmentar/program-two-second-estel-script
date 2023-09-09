using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class FormBinary
    {
        public FormBinary
(
String file,
Stream stream,
Boolean endianFormat,
Int32 stringCodec,
Int32 chunkSize, 
Int32 startBoundary, 
Int32 headerAddress,
Int32 contentAddress,
Int32 localLineAddress, 
Int32 globalLineAddress,
Boolean debug
)
        {
            FormBinaryData data;

            data = new FormBinaryData();

            data.File = file;

            data.Stream = stream;

            data.EndianFormat = endianFormat;

            data.StringCodec = stringCodec;

            data.ChunkSize = chunkSize;

            data.StartBoundary = startBoundary;

            data.HeaderAddress = headerAddress;

            data.ContentAddress = contentAddress;

            data.LocalLineAddress = localLineAddress;

            data.GlobalLineAddress = globalLineAddress;

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            this.Data = data;

            return;
        }
    }
}
