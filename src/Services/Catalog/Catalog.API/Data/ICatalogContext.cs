namespace Catalog.API.Data;

public interface ICatalogContext
{
    IMongoCollection<Product> Products {get;}
}
