using Core;

namespace Core
{
    using System;
    public partial class FormBinarySequence
    {
        public static void Debug(String file, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormBinary) + ' ' + "::" + ' ' + nameof(FormBinarySequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(file) + ':' + ' ' + file,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            Program.Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Debug}-FormBinaryDebug", descriptor);

            return;
        }
    }
}
