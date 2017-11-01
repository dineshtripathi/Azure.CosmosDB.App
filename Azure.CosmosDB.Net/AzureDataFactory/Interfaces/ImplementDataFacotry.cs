using Azure.CosmosDB.Net.AzureDataFactory.Implementation;
using Microsoft.Extensions.Configuration;

namespace Azure.CosmosDB.Net.AzureDataFactory.Interfaces
{
    public class ImplementDataFacotry
    {
        private readonly IConfiguration _config;

        public ImplementDataFacotry(IConfiguration config)
        {
            _config = config;
        }
        public  void Initialize()
        {
           
            IProvideDataFactory dataFactory = new BlobDataFactory(new BlobDataFactoryInitialize(_config));
        }
    }
}