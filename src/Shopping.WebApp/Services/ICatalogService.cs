using Shopping.WebApp.Models;

namespace Shopping.WebApp.Services;

public interface ICatalogService
{
    Task<IEnumerable<CatalogModel>> GetCatalog();
    Task<IEnumerable<CatalogModel>> GetrGatalogByCatagory(string catagory);
    Task<CatalogModel> GetCatalog(string id);
    Task<CatalogModel> CreateCatalog(CatalogModel model);
}
