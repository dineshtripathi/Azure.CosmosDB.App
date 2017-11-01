using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.CosmosDB.Net.FluentAPI.CRUDOperation;
using Azure.CosmosDB.Net.FluentInterfaces.CRUDOperation;

namespace Azure.CosmosDB.App.Console.TestFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            IProvideCrudOperation ope = new ProvideCrudOperation();
            ope.Where(x => x.DatabaseId == "guid").OrderbyAscending(x => x.CollectionId.Contains("2")).Page(10, 0)
                .Execute();
        }
    }
}
