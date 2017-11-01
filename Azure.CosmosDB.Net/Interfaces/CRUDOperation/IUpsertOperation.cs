using System;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.EntityModel;

namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public interface IUpsertOperation<in TOfBaseType> where TOfBaseType : BaseEntity
    {
        Task Upsert(TOfBaseType upsertData,Action<string,bool> log);
        Task Upsert<TOut>(TOfBaseType upsertData,Action<string,bool> log, out TOut output);

    }
}