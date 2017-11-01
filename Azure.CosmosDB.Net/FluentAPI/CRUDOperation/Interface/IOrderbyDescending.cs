namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IOrderbyDescending
    {
        IPage Page(int pageSize, int pageNumber);
    }
}