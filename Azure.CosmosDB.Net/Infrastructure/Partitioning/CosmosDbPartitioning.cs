using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.FluentAPI.Partitioning;

namespace Azure.CosmosDB.Net.Infrastructure.Partitioning
{
    public class CosmosDbPartitioning: ICosmosGeoPartitioning
    {
        public async Task<bool> CreateGeoPartition(string geoBuilder)
        {
            return await Task.FromResult(true).ConfigureAwait(false);
        }
    }
}
