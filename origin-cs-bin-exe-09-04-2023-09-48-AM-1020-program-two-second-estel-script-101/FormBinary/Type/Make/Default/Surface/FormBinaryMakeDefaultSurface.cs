using Core;

namespace Core
{
    using System;

    public partial class FormBinary
    {
        public static FormBinary MakeFormBinaryDefaultSurface(String file)
        {
            FormBinary formBinaryResult = default;

            formBinaryResult = MakeFormBinaryDefault(file, FormBinaryPolicy.FormBinaryDebugPolicy);

            return formBinaryResult;
        }
    }
}
