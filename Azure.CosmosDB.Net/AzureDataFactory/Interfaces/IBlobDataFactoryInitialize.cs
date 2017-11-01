using System.Runtime.Serialization;

namespace Azure.CosmosDB.Net.AzureDataFactory.Interfaces
{
    public interface IBlobDataFactoryInitialize :IFactoryBaseInitialize
    {
        [DataMember]string BlobDatasetName { get;  } 
        [DataMember]string InputBlobPath { get;  }
        [DataMember]string OutputBlobPath { get;  }
    }
}