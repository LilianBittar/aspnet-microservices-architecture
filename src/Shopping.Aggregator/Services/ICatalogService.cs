using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services;

public interface ICatalogeService 
{
    Task<IEnumerable<CatalogModel>> GetCatalog();
    Task<IEnumerable<CatalogModel>> GetrGatalogByCatagory(string catagory);
    Task<CatalogModel> GetCatalog(string id);
}
