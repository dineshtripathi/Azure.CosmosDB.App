using System.Threading.Tasks;

namespace Azure.CosmosDB.Net.AzureDataFactory.Interfaces
{
    public interface IProvideDataFactory
    {
        Task<int> Initialize();
    }
}