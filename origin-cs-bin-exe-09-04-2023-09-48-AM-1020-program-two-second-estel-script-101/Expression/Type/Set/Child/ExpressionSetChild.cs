using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Expression> ExpressionChildSet(params Object[] objectArray)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            foreach (Object objectItem in ExpressionUnsortSetSurface(objectArray))
            {
                String stringIdentity;

                stringIdentity = objectItem.ToString();

                Expression expression;

                expression = MakeExpressionDefaultSurface(stringIdentity, default, default);

                collectionResult.Add(expression);

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
