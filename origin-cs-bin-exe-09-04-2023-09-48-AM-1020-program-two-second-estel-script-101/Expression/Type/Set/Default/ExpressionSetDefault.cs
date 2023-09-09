using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Expression> ExpressionDefaultSet(FormBinary[] formBinaryArray, String workingDirectory)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            foreach (FormBinary formBinary in formBinaryArray)
            {
                var array = FormBinary.FormBinaryGlobalLineTupleSetSurface(formBinary);

                Expression expression;

                expression = MakeExpressionRoot();

                foreach (var tuple in array)
                {
                    expression.Lock(tuple.Item4);

                    expression.Unlock(tuple.Item3);

                    expression.Engage(tuple.Item5);

                    expression.Release();

                    continue;
                }

                collectionResult.Add(expression);

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
