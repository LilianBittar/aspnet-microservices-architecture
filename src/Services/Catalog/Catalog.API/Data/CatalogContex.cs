using Catalog.API.Entities;
using MongoDB.Driver;

namespace  Catalog.API.Data;

public class CatalogContext : ICatalogContext
{
    public IMongoCollection<Product> Products { get; }

    IMongoCollection<Product> ICatalogContext.Products => throw new NotImplementedException();

    public CatalogContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
        var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

        Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);

       CatalogContextSeed.SeedData(Products);
    }

}
