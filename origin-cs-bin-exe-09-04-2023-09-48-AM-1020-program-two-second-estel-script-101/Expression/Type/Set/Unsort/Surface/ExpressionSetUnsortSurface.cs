using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public static Object[] ExpressionUnsortSetSurface(IEnumerable enumerable)
        {
            Object[] arrayResult = default;

            var list = ExpressionUnsortSet(enumerable);

            Object[] objectArray;

            objectArray = new Object[list.Count];

            list.CopyTo(objectArray, 0);

            arrayResult = objectArray;

            return arrayResult;
        }
    }
}
