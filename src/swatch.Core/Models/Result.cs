using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.Models
{
    public class Result<T>

    {
        public T Value { get; set; }

        public bool IsError { get; set; }

        public string ErrorMessage { get; set; }
    }
}
