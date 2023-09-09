using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Unlock(String stringIdentity)
        {
            IView(LastLock);

            LastLock = LastLock.ILock(stringIdentity);

            return;
        }
    }
}
