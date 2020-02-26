// Copyright (c) 2020 Allan Mobley. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Cosmos;

namespace Azure.Functions.Cosmos.Extension
{
    internal class DefaultCosmosServiceFactory : ICosmosServiceFactory
    {
        public ICosmosService CreateService(string connectionString, CosmosClientOptions cosmosClientOptions)
        {
            return new CosmosService(connectionString, cosmosClientOptions);
        }
    }
}