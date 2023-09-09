using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Lock(String stringIdentity)
        {
            IView(this);

            LastLock = ILock(stringIdentity);

            return;
        }
    }
}
