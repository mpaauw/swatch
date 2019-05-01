using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.Patterns
{
    public interface ICommandHandler
    {
        TOutput ExecuteCommand<TOutput>(Command<TOutput> command);
    }
}
