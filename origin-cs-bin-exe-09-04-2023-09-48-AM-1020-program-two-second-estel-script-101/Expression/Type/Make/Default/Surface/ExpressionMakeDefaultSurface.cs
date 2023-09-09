using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public static Expression MakeExpressionDefaultSurface(String stringIdentity, Object objectIdentity, ArrayList arrayList)
        {
            Expression expressionResult = default;

            expressionResult = MakeExpressionDefault(stringIdentity, objectIdentity, arrayList, ExpressionPolicy.ExpressionDebugPolicy);

            return expressionResult;
        }
    }
}
