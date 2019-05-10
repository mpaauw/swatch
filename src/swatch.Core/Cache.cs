using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core
{
    public class Cache<TKey, TValue> : ICache<TKey, TValue>
    {
        



        public TValue Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Set(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public TValue Delete(TKey key)
        {
            throw new NotImplementedException();
        }
    }
}
