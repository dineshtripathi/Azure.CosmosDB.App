using System;
using System.Linq.Expressions;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IProvideCrudOperation
    {
        IWhereOperation<BaseEntity> Where(Expression<Func<BaseEntity, bool>> predicate);
        IDeleteOperation Delete(Expression<Func<BaseEntity, bool>> predicate);
    }
}