﻿using System.Collections.Generic;

namespace Overloaded_Methods
{
    public class SortCardsByValueThenSuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value < y.Value)
                return -1;
            if (x.Value > y.Value)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            return 0;
        }
    }
}