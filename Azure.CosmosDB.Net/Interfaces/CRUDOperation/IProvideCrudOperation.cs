using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public interface IProvideCrudOperation
    {
        IWhereOperation<BaseEntity> Where(Expression<Func<BaseEntity, bool>> predicate);
        IDeleteOperation Delete(Expression<Func<BaseEntity, bool>> predicate);
    }
}