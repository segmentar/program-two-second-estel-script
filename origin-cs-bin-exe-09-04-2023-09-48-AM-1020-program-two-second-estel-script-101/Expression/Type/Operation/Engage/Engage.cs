using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Engage(Object objectItem)
        {
            LastLock.ObjectIdentity = objectItem;

            return;
        }
    }
}
