using Amazon.Runtime;
using swatch.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace swatch.Core.Configuration
{
    public class AwsDynamoDbCredentials : AWSCredentials
    {
        public override ImmutableCredentials GetCredentials()
        {
            return new ImmutableCredentials(
                Environment.GetEnvironmentVariable(Constants.AwsAccessKeyIdKey),
                Environment.GetEnvironmentVariable(Constants.AwsSecretKeyKey),
                null);
        }
    }
}
