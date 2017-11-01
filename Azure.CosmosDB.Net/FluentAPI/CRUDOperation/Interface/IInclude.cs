namespace Azure.CosmosDB.Net.FluentAPI.CRUDOperation.Interface
{
    public interface IInclude
    {
        IPage Page(int pageSize, int pageNumber);
    }
}