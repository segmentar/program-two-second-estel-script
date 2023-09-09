using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void View(Boolean last)
        {
            if (last)
            {
                IView(LastLock);
            }
            else
            {
                IView(this);
            }

            return;
        }
    }
}
