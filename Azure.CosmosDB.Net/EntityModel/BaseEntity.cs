using System;
using Newtonsoft.Json;

namespace Azure.CosmosDB.Net.EntityModel
{
    public abstract class BaseEntity
    {
        private static int _count = 1;
        [JsonProperty("Id")]
        public string DocumentId { get; set; }
        [JsonProperty("DatabaseId")]
        public string DatabaseId { get; set; }
        [JsonProperty("CollectionId")]
        public string CollectionId { get; set; }
        [JsonProperty("AddedAt")]
        public DateTime AddedAt { get; set; }
        [JsonProperty("UpdateCount")]
        public static int UpdatedRecordsForTimes => _count++;
    }
}
