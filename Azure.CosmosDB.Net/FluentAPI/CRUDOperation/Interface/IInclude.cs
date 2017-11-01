namespace Azure.CosmosDB.Net.FluentInterfaces.CRUDOperation
{
    public interface IInclude
    {
        IPage Page(int pageSize, int pageNumber);
    }
}