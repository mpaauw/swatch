using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core
{
    public interface ICache<TKey, TValue>
    {
        TValue Get(TKey key);

        void Set(TKey key, TValue value);

        TValue Delete(TKey key);
    }
}
