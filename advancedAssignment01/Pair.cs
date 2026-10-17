using System;
using System.Collections.Generic;
using System.Text;

namespace advancedAssignment01
{
    internal class Pair<TKey, TValue>
    {
        #region What are multiple type parameters?

        //using more than one generic type placeholder in class/method

        #endregion

        public TKey Key;
        public TValue Value;

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
