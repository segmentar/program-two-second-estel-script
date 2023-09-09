using Core;

namespace Core
{
    using System;

    public partial class FormBinary
    {
        public static Tuple<String, Int32, String, String, Object>[] FormBinaryGlobalLineTupleSetSurface(FormBinary formBinary)
        {
            Tuple<String, Int32, String, String, Object>[] arrayResult = default;

            var list = FormBinaryGlobalLineTupleSet(formBinary);

            Tuple<String, Int32, String, String, Object>[] tupleArray;

            tupleArray = new Tuple<String, Int32, String, String, Object>[list.Count];

            list.CopyTo(tupleArray, 0);

            arrayResult = tupleArray;

            return arrayResult;
        }
    }
}
