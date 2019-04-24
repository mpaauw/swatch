using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using swatch.Core.Common;
using System;

namespace swatch.Core.Configuration
{
    public class AwsDynamoDbConfiguration : IDataProviderConfiguration
    {
        protected readonly AmazonDynamoDBConfig configuration;

        public AwsDynamoDbConfiguration()
        {
            this.configuration = new AmazonDynamoDBConfig();
            this.configuration.RegionEndpoint = RegionEndpoint.USWest2;
            this.configuration.ServiceURL = Environment.GetEnvironmentVariable(Constants.AwsDynamoDbServiceUrlKey);
        }
    }
}
