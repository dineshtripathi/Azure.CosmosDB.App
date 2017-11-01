using System;
using System.Linq.Expressions;
using Azure.CosmosDB.Net.EntityModel;
using Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface;
using Azure.CosmosDB.Net.FluentInterfaces.CRUDOperation;

namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation
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