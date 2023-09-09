using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Expression) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StringIdentity) + ':' + ' ' + StringIdentity,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{ArrayList.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectIdentity) + ':',
                String.Empty + ObjectIdentity,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ArrayList) + ':',
                String.Empty + "<hidden>",
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ForgeExpressionString) + ':',
                String.Empty + ForgeExpressionString(this, 1)
            });
        }
    }
}
