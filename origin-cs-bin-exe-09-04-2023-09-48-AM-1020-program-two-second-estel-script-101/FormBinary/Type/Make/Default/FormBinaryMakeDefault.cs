using Core;

namespace Core
{
    using System;

    public partial class FormBinary
    {
        public static FormBinary MakeFormBinaryDefault(String file, Boolean debug)
        {
            FormBinary formBinaryResult = default;

            var result = new FormBinarySequence(file, debug).Result;

            FormBinaryPolicy.FormBinaryArrayList.Add(result);

            formBinaryResult = result;

            return formBinaryResult;
        }
    }
}
