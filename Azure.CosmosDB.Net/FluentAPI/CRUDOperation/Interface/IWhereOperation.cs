using System;
using System.Linq.Expressions;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IWhereOperation<T> where T : BaseEntity
    {
        IOrderBy Orderby(Expression<Func<BaseEntity, bool>> predicate);
        IOrderbyDescending OrderbyDescending(Expression<Func<BaseEntity,bool>> predicate);
        IOrderbyAscending OrderbyAscending(Expression<Func<BaseEntity, bool>> predicate);

    }
}