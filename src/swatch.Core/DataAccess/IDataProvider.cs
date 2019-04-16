using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.DataAccess
{
    public interface IDataProvider
    {
        T Retrieve<T>(string key);

        string Create<T>(T payload);

        string Update<T>(string key, T payload);

        string Delete<T>(string key);
    }
}
