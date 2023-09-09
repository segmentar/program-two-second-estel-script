using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ExpressionSequence
    {
        public Expression Result { get; set; } = default;

        public ExpressionSequence(String stringIdentity, Object objectIdentity, ArrayList arrayList, Boolean debug)
        {
            Boolean isStringIdentityDefault;

            isStringIdentityDefault = false;

            isStringIdentityDefault = isStringIdentityDefault || (stringIdentity == null) is true;

            isStringIdentityDefault = isStringIdentityDefault || (stringIdentity == default) is true;

            Boolean isObjectIdentityDefault;

            isObjectIdentityDefault = false;

            isObjectIdentityDefault = isObjectIdentityDefault || (objectIdentity == null) is true;

            isObjectIdentityDefault = isObjectIdentityDefault || (objectIdentity == default) is true;

            Boolean isArrayListDefault;

            isArrayListDefault = false;

            isArrayListDefault = isArrayListDefault || (arrayList == null) is true;

            isArrayListDefault = isArrayListDefault || (arrayList == default) is true;

            if (isStringIdentityDefault is true)
            {
                String stringItem;

                stringItem = String.Empty;

                stringIdentity = stringItem;
            }
            else
                "false".ToString();

            if (isObjectIdentityDefault is true)
            {
                Object objectItem;

                objectItem = String.Empty;

                objectIdentity = objectItem;
            }
            else
                "false".ToString();

            if (isArrayListDefault is true)
            {
                ArrayList arrayListItem;

                arrayListItem = new ArrayList();

                arrayList = arrayListItem;
            }
            else
                "false".ToString();

            Debug(stringIdentity, objectIdentity, arrayList, debug);

            Expression expression;

            expression = new Expression(stringIdentity, objectIdentity, arrayList, debug);

            this.Result = expression;

            return;
        }

        ~ExpressionSequence()
        {
            return;
        }
    }
}
