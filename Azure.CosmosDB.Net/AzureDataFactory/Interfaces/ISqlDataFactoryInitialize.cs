using System.Runtime.Serialization;

namespace Azure.CosmosDB.Net.AzureDataFactory.Interfaces
{
    public interface ISqlDataFactoryInitialize : IFactoryBaseInitialize
    {
        [DataMember]string AzureDbConnectionString { get;  }
        [DataMember]string AzureDbTableName { get;  }
        [DataMember]string AzureDbDataSetName { get;  }
    }
}