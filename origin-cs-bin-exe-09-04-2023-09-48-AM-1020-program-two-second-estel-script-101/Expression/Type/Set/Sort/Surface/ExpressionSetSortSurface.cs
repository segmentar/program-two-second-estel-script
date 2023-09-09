using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public static Expression[] ExpressionSortSetSurface(IEnumerable enumerable)
        {
            Expression[] arrayResult = default;

            var list = ExpressionSortSet(enumerable);

            Expression[] expressionArray;

            expressionArray = new Expression[list.Count];

            list.CopyTo(expressionArray, 0);

            arrayResult = expressionArray;

            return arrayResult;
        }
    }
}
