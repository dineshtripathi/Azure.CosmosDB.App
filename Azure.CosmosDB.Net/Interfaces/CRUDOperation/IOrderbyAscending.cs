namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public interface IOrderbyAscending
    {
        IPage Page(int pageSize, int pageNumber);
    }
}