using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.Patterns
{
    public abstract class Command<TOutput>
    {
        public abstract TOutput Execute();
    }
}
