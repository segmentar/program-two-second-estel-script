using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression[] ExpressionChildSetSurface(params Object[] objectArray)
        {
            Expression[] arrayResult = default;

            var list = ExpressionChildSet(objectArray);

            Expression[] expressionArray;

            expressionArray = new Expression[list.Count];

            list.CopyTo(expressionArray, 0);

            arrayResult = expressionArray;

            return arrayResult;
        }
    }
}
