using System;
using System.Linq.Expressions;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IDeleteOperation
    {
        IDeleteOperation Delete(Expression<Func<BaseEntity, bool>> predicate);
    }
}