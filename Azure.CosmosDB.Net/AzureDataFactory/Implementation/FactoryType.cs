using System.Collections.Generic;

namespace Azure.CosmosDB.Net.AzureDataFactory.Implementation
{
    public class FactoryType
    {
        public string Type { get; set; }
        public string Region { get; set; }
        public string InputBlobPath { get; set; }
        public string OutputBlobPath { get; set; }
        public List<ConnectionString> ConnectionString { get; set; }
    }
}