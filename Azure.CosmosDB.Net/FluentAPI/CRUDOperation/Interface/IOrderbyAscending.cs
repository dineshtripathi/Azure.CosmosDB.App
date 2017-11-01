namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IOrderbyAscending
    {
        IPage Page(int pageSize, int pageNumber);
    }
}