using Core;

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public Expression Result { get; set; } = default;

        public ExpressionSimple()
        {
            return;
        }

        ~ExpressionSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Collections;

    public partial class ExpressionSimple
    {
        public ExpressionSimple(String stringIdentity, Object objectIdentity, params Object[] objectArray)
        {
            Boolean isObjectArrayDefault;

            isObjectArrayDefault = false;

            isObjectArrayDefault = isObjectArrayDefault || (objectArray == null) is true;

            isObjectArrayDefault = isObjectArrayDefault || (objectArray == default) is true;

            if (isObjectArrayDefault is true)
            {
                var array_OBJECT = new Object[0];

                objectArray = array_OBJECT;
            }
            else
                "false".ToString();

            ArrayList arrayList;

            arrayList = new ArrayList(Expression.ExpressionChildSetSurface(objectArray));

            Expression expression;

            expression = Expression.MakeExpressionDefaultSurface(stringIdentity, objectIdentity, arrayList);

            this.Result = expression;

            return;
        }
    }
}
