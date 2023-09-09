using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression ILock(String stringIdentity)
        {
            Expression expressionResult = default;

            Expression expression;

            expression = new ExpressionSimple(stringIdentity, default, default).Result;

            ViewLinkedList.First.Value.ArrayList.Add(expression);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
