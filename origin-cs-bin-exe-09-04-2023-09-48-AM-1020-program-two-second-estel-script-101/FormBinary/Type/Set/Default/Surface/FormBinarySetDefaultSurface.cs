using Core;

namespace Core
{
    using System;

    public partial class FormBinary
    {
        public static FormBinary[] FormBinaryDefaultSetSurface(String[] fileArray)
        {
            FormBinary[] formBinaryResult = default;

            var list = FormBinaryDefaultSet(fileArray);

            FormBinary[] formBinaryArray;

            formBinaryArray = new FormBinary[list.Count];

            list.CopyTo(formBinaryArray, 0);

            formBinaryResult = formBinaryArray;

            return formBinaryResult;
        }
    }
}
