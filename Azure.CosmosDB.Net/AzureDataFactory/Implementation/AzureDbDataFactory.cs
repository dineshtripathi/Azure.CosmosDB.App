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
            return await Task.FromResult(0);
        }
    }
}