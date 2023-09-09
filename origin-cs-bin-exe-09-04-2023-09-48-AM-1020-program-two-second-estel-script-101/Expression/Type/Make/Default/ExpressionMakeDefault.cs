using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public static Expression MakeExpressionDefault(String stringIdentity, Object objectIdentity, ArrayList arrayList, Boolean debug)
        {
            Expression expressionResult = default;

            var result = new ExpressionSequence(stringIdentity, objectIdentity, arrayList, debug).Result;

            ExpressionPolicy.ExpressionArrayList.Add(result);

            expressionResult = result;

            return expressionResult;
        }
    }
}
