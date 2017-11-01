using Azure.CosmosDB.Net.AzureDataFactory.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Azure.CosmosDB.Net.AzureDataFactory.Implementation
{
    public class BlobDataFactoryInitialize : IBlobDataFactoryInitialize
    {
        private readonly IConfiguration _config;

        public BlobDataFactoryInitialize(IConfiguration config)
        {
            _config = config;
        }

        string IFactoryBaseInitialize.Region => "Europe";
        string IFactoryBaseInitialize.DataFactoryName => "hello";
        string IFactoryBaseInitialize.StorageKey { get; }
        DataFactoryManagementClient IFactoryBaseInitialize.FactoryManagementClient { get;  }
        string IFactoryBaseInitialize.StorageAccount { get;  }
        string IFactoryBaseInitialize.StorageLinkedAccount { get;  }
        string IFactoryBaseInitialize.PipelineName { get;  }
        string IFactoryBaseInitialize.TenantId { get;  }
        string IFactoryBaseInitialize.SubscriptionId { get;  }
        string IFactoryBaseInitialize.ResourceGroup { get;  }
        string IFactoryBaseInitialize.ApplicationId { get;  }
        string IBlobDataFactoryInitialize.BlobDatasetName { get;  }
        string IBlobDataFactoryInitialize.InputBlobPath { get;  }
        string IBlobDataFactoryInitialize.OutputBlobPath { get;  }
    }
}