using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty,
                String.Empty + '\t' + $"This is `{Immutable.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + "Write file extension to look for" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + nameof(Architecture.Extension) + ':' + ' ' + Architecture.Extension,
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });

            stringResult = descriptor;

            return stringResult;
        }
    }
}
