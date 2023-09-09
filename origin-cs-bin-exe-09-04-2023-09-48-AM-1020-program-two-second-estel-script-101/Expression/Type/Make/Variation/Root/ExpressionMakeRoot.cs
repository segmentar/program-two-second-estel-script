using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionRoot()
        {
            Expression expressionResult;

            Expression expression;

            expression = new ExpressionSimple("root", default, default).Result;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
