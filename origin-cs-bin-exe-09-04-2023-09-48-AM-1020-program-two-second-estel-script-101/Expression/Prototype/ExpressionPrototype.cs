using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public Expression(String stringIdentity, Object objectIdentity, ArrayList arrayList, Boolean debug)
        {
            this.StringIdentity = stringIdentity;

            this.ObjectIdentity = objectIdentity;

            this.ArrayList = arrayList;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
