using swatch.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.DataAccess
{
    public abstract class DataProvider : IDataProvider
    {
        protected readonly IDataProviderConfiguration configuration;

        public abstract string Create<T>(T payload);

        public abstract string Delete<T>(string key);

        public abstract T Retrieve<T>(string key);

        public abstract string Update<T>(string key, T payload);
    }
}
