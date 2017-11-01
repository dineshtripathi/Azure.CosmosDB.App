using System.ComponentModel;
using System.Runtime.Serialization;

namespace Azure.CosmosDB.Net.AzureDataFactory.Interfaces
{
    [Description("Should only contains contract properties getter and should be private setter not a method")]
    public interface IFactoryBaseInitialize
    {
        [DataMember]string Region { get;  }
        [DataMember]string DataFactoryName { get;  }
        [DataMember]string StorageKey { get;  }
        [DataMember]DataFactoryManagementClient FactoryManagementClient { get;  }
        [DataMember]string StorageAccount { get;  }
        [DataMember]string StorageLinkedAccount { get;  }
        [DataMember]string PipelineName { get;  }
        [DataMember]string TenantId { get;  }
        [DataMember]string SubscriptionId { get;  }
        [DataMember]string ResourceGroup { get;  }
        [DataMember]string ApplicationId { get;  }
    }
}