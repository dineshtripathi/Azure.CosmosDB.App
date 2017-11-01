using System.Threading.Tasks;

namespace Azure.CosmosDB.Net.FluentAPI.Partitioning
{
    public interface ICosmosGeoPartitioning
    {
        Task<bool> CreateGeoPartition(string geoBuilder);
    }
}