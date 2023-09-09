using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Object> ExpressionUnsortSet(IEnumerable enumerable)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            foreach (Object objectItem in enumerable)
            {
                if (objectItem is Expression)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(objectItem);

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}
