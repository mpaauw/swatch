using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.Patterns
{
    public class CommandHandler : ICommandHandler
    {
        public TOutput ExecuteCommand<TOutput>(Command<TOutput> command)
        {
            return command.Execute();
        }
    }
}
