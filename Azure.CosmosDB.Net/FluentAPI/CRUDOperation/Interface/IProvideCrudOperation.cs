using System;
using System.Linq.Expressions;
using Azure.CosmosDB.Net.EntityModel;
using Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface;

namespace Azure.CosmosDB.Net.FluentInterfaces.CRUDOperation
{
    public interface IProvideCrudOperation
    {
        IWhereOperation<BaseEntity> Where(Expression<Func<BaseEntity, bool>> predicate);
        IDeleteOperation Delete(Expression<Func<BaseEntity, bool>> predicate);
    }
}