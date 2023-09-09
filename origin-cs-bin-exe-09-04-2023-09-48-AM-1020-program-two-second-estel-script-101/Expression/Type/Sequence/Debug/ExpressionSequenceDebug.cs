using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ExpressionSequence
    {
        public static void Debug(String stringIdentity, Object objectIdentity, ArrayList arrayList, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(ExpressionSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(stringIdentity) + ':' + ' ' + stringIdentity,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(objectIdentity) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(arrayList) + ':' + ' ' + ". . ." + ' ' + $"<{arrayList.Count}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(objectIdentity) + ':',
                String.Empty + objectIdentity,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(arrayList) + ':',
                String.Empty + String.Join('\n'.ToString(), arrayList.ToArray())
            });

            Program.Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Debug}-ExpressionDebug", descriptor);

            return;
        }
    }
}
