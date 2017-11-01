namespace Azure.CosmosDB.Net.FluentInterfaces.CRUDOperation
{
    public interface IOrderbyAscending
    {
        IPage Page(int pageSize, int pageNumber);
    }
}