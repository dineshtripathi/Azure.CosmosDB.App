using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public class ProvideCrudOperation : IProvideCrudOperation
    {
        public  IWhereOperation<BaseEntity> Where(Expression<Func<BaseEntity, bool>> predicate)
        {
            return null;
        }

        public  IDeleteOperation Delete(Expression<Func<BaseEntity, bool>> predicate)
        {
            return null;
        }
    }
}