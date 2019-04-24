using Amazon.DynamoDBv2;
using swatch.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.DataAccess
{
    public class AwsDynamoDbDataProvider : DataProvider
    {
        private readonly AmazonDynamoDBClient client;
        private readonly AwsDynamoDbCredentials credentials;

        public AwsDynamoDbDataProvider()
        {
            this.configuration = new AwsDynamoDbConfiguration();
            this.client = new AmazonDynamoDBClient(this.credentials);
        }

        public override string Create<T>(T payload)
        {
            throw new NotImplementedException();
        }

        public override string Delete<T>(string key)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(string key)
        {
            throw new NotImplementedException();
        }

        public override string Update<T>(string key, T payload)
        {
            throw new NotImplementedException();
        }
    }
}
