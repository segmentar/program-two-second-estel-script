using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct FormBinaryData
    {
        public String File;

        public Stream Stream;

        public Boolean EndianFormat;

        public Int32 StringCodec;

        public Int32 ChunkSize;

        public Int32 StartBoundary;

        public Int32 HeaderAddress;

        public Int32 ContentAddress;

        public Int32 LocalLineAddress;

        public Int32 GlobalLineAddress;

        public Boolean IsDebug;
    }
}
