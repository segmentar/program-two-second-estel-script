using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Release()
        {
            IView(ViewLinkedList.Last.Value);

            return;
        }
    }
}
