using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void IView(Expression expression)
        {
            ViewLinkedList.AddFirst(expression);

            return;
        }
    }
}
