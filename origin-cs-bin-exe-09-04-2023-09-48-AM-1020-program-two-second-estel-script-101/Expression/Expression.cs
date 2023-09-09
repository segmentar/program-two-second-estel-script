using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static Expression LastLock;

        public static LinkedList<Expression> ViewLinkedList = new LinkedList<Expression>();

        public Expression()
        {
            return;
        }

        ~Expression()
        {
            return;
        }
    }
}
