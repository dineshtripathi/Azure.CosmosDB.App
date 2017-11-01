namespace Azure.CosmosDB.Net.Interfaces.CRUDOperation
{
    public interface IInclude
    {
        IPage Page(int pageSize, int pageNumber);
    }
}