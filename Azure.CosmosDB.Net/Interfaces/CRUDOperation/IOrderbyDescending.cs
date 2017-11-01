namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public interface IOrderbyDescending
    {
        IPage Page(int pageSize, int pageNumber);
    }
}