using Core;

namespace Core
{
    using System;

    public partial struct FormBinaryData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(FormBinary) + ' ' + "::" + ' ' + nameof(FormBinaryData) + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(File) + ':' + ' ' + File,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Stream) + ':' + ' ' + Stream,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(EndianFormat) + ':' + ' ' + EndianFormat,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(StringCodec) + ':' + ' ' + StringCodec,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ChunkSize) + ':' + ' ' + ChunkSize,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(StartBoundary) + ':' + ' ' + StartBoundary,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(HeaderAddress) + ':' + ' ' + HeaderAddress,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(ContentAddress) + ':' + ' ' + ContentAddress,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(LocalLineAddress) + ':' + ' ' + LocalLineAddress,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(GlobalLineAddress) + ':' + ' ' + GlobalLineAddress,
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FormBinary.ForgeHeaderTuple) + ':',
                String.Empty + String.Join('\n'.ToString(), FormBinary.ForgeHeaderTuple(this).Item2),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FormBinary.ForgeContent) + ':',
                String.Empty + FormBinary.ForgeContent(this),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(FormBinary.ForgeLocalLineTuple) + ':',
                String.Empty + FormBinary.ForgeLocalLineTuple(this).Item1,
                String.Empty + String.Join('\n'.ToString(), FormBinary.ForgeLocalLineTuple(this).Item2),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(FormBinary.ForgeGlobalLineTuple) + ':',
                String.Empty + FormBinary.ForgeGlobalLineTuple(this).Item1,
                String.Empty + String.Join('\n'.ToString(), FormBinary.ForgeGlobalLineTuple(this).Item2)
            });
        }
    }
}
