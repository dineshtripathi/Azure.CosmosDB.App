using Azure.CosmosDB.Net.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public interface IWhereOperation<T> where T : BaseEntity
    {
        IOrderBy Orderby(Expression<Func<BaseEntity, bool>> predicate);
        IOrderbyDescending OrderbyDescending(Expression<Func<BaseEntity,bool>> predicate);
        IOrderbyAscending OrderbyAscending(Expression<Func<BaseEntity, bool>> predicate);

    }
}