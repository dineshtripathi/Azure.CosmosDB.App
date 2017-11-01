using System.Linq;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IExecute
    {
        Task<IQueryable<BaseEntity>> Execute();
    }
}