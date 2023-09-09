using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Expression> ExpressionSortSet(IEnumerable enumerable)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            foreach (Object objectItem in enumerable)
            {
                if ((objectItem is Expression) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(objectItem as Expression);

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
