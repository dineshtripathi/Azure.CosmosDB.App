using System.Runtime.Serialization;
using Azure.CosmosDB.Net.AzureDataFactory.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Azure.CosmosDB.Net.AzureDataFactory.Implementation
{
    public class AzureDbFactoryInitialize : ISqlDataFactoryInitialize
    {
        private IConfiguration Config { get;  }
        private RootObject Robject { get; }

        public AzureDbFactoryInitialize(IConfiguration config)
        {
            Config = config;
            Robject = config.Get<RootObject>();
        }

        [DataMember]string IFactoryBaseInitialize.Region
        {
            get
            {
                return Robject.FactoryType.Find(x => x.Type == "StorageBlobFactory")?.Region;
            } 
        }
        [DataMember]string IFactoryBaseInitialize.DataFactoryName { get; }
        [DataMember]string IFactoryBaseInitialize.StorageKey { get; }
        [DataMember]DataFactoryManagementClient IFactoryBaseInitialize.FactoryManagementClient { get; }
        [DataMember]string IFactoryBaseInitialize.StorageAccount { get; }
        [DataMember]string IFactoryBaseInitialize.StorageLinkedAccount { get; }
        [DataMember]string IFactoryBaseInitialize.PipelineName { get; }
        [DataMember]string IFactoryBaseInitialize.TenantId { get; }
        [DataMember]string IFactoryBaseInitialize.SubscriptionId { get; }
        [DataMember]string IFactoryBaseInitialize.ResourceGroup { get; }
        [DataMember]string IFactoryBaseInitialize.ApplicationId { get; }
        [DataMember]string ISqlDataFactoryInitialize.AzureDbConnectionString { get; }
        [DataMember]string ISqlDataFactoryInitialize.AzureDbTableName { get; }
        [DataMember]string ISqlDataFactoryInitialize.AzureDbDataSetName { get; }
    }
}