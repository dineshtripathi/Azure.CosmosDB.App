using System;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.AzureDataFactory.Interfaces;

namespace Azure.CosmosDB.Net.AzureDataFactory.Implementation
{
    public class AzureDbDataFactory : IProvideDataFactory
    {
        private readonly ISqlDataFactoryInitialize _sqlDataFactoryInitialize;

        public AzureDbDataFactory(ISqlDataFactoryInitialize sqlDataFactoryInitialize)
        {
            _sqlDataFactoryInitialize = sqlDataFactoryInitialize;
        }
        public async Task<int> Initialize()
        {
            var appId=_sqlDataFactoryInitialize.ApplicationId;
            return await Task.FromResult(Convert.ToInt32(appId)).ConfigureAwait(false);
        }
    }
}