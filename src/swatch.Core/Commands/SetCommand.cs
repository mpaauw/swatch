using swatch.Core.Models;
using swatch.Core.Patterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.Commands
{
    public class SetCommand : Command<Result<string>>
    {
        private readonly string id;
        private readonly object payload;
        private readonly string key;

        public SetCommand(
            string id,
            object payload,
            string key = null)
        {
            this.id = id;
            this.payload = payload;
            this.key = (key is null) ? Guid.NewGuid().ToString() : key;
        }

        public override Result<string> Execute()
        {
            try
            {
                // retrieve file data

                // put payload at key

                // write / save file data

                throw new NotImplementedException();
            }
            catch(Exception ex)
            {
                return new Result<string>()
                {
                    IsError = true,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
