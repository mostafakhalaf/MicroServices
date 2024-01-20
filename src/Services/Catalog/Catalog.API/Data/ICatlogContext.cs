using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatlogContext
    {
        IMongoCollection<Product> Products {  get; }
    }
}
