using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContextcs
    {
        IMongoCollection<Product> Products { get; }
    }
}
