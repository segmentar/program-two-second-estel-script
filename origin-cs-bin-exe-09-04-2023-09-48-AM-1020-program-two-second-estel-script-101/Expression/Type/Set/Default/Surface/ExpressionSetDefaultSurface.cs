using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression[] ExpressionDefaultSetSurface(FormBinary[] formBinaryArray, String workingDirectory)
        {
            Expression[] arrayResult = default;

            var list = ExpressionDefaultSet(formBinaryArray, workingDirectory);

            Expression[] expressionArray;

            expressionArray = new Expression[list.Count];

            list.CopyTo(expressionArray, 0);

            arrayResult = expressionArray;

            return arrayResult;
        }
    }
}
