using System.Threading.Tasks;
using Azure.CosmosDB.Net.AzureDataFactory.Interfaces;

namespace Azure.CosmosDB.Net.AzureDataFactory.Implementation
{
    public class BlobDataFactory : IProvideDataFactory
    {
        private readonly IBlobDataFactoryInitialize _blobDataFactoryInitialize;

        public BlobDataFactory(IBlobDataFactoryInitialize blobDataFactoryInitialize)
        {
            _blobDataFactoryInitialize = blobDataFactoryInitialize;
        }
        public async Task<int> Initialize()
        {
            return await Task.FromResult(0);
        }
    }
}