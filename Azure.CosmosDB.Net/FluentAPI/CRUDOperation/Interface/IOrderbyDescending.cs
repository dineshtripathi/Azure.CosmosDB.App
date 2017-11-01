namespace Azure.CosmosDB.Net.FluentInterfaces.CRUDOperation
{
    public interface IOrderbyDescending
    {
        IPage Page(int pageSize, int pageNumber);
    }
}