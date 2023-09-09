using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionCombine(Expression[] expressionArray)
        {
            Expression expressionResult = default;

            Expression expression;

            expression = MakeExpressionRoot();

            foreach (Expression expressionItem in expressionArray)
            {
                foreach (var item_EXPRESSION in expressionItem.ArrayList)
                {
                    expression.ArrayList.Add(item_EXPRESSION);

                    continue;
                }
                
                continue;
            }

            expressionResult = expression;

            return expressionResult;
        }
    }
}
