using System;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IUpsertOperation<in TOfBaseType> where TOfBaseType : BaseEntity
    {
        Task Upsert(TOfBaseType upsertData,Action<string,bool> log);
        Task<TOut> Upsert<TOut>(TOfBaseType upsertData,Action<string,bool> log);

    }
}