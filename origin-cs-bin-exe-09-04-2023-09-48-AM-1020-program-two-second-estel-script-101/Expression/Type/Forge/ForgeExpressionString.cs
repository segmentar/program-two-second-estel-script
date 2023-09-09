using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static String ForgeExpressionString(Expression expression, Int32 layer)
        {
            String stringResult = default;

            String stringItem;

            stringItem = new String('>', layer);

            var descriptor_INITIAL = String.Empty;

            descriptor_INITIAL = descriptor_INITIAL + stringItem;

            descriptor_INITIAL = descriptor_INITIAL + ' ';

            descriptor_INITIAL = descriptor_INITIAL + expression.StringIdentity;

            descriptor_INITIAL = descriptor_INITIAL + '\n';

            var next = (layer + 1);

            foreach (Object objectItem in ExpressionSortSetSurface(expression.ArrayList))
            { 
                var descriptor_SUBSEQUENT = ForgeExpressionString(objectItem as Expression, next);

                descriptor_INITIAL = descriptor_INITIAL + descriptor_SUBSEQUENT;

                continue;
            }

            stringResult = descriptor_INITIAL;

            return stringResult;
        }
    }
}
