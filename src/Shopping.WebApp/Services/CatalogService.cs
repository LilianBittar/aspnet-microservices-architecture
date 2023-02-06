using Shopping.WebApp.Models;

namespace Shopping.WebApp.Services;

public class CatalogService : ICatalogService
{
    private readonly HttpClient _client;

    public CatalogService(HttpClient client)
    {
        _client = client ?? throw new ArgumentException(nameof(client));
    }
    public Task<CatalogModel> CreateCatalog(CatalogModel model)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CatalogModel>> GetCatalog()
    {
        var response =  await _client.GetAsync("/api/v1/Catalog");
        //return await response.ReadContentAs<List<CatalogModel>>();
    }

    public Task<CatalogModel> GetCatalog(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CatalogModel>> GetrGatalogByCatagory(string catagory)
    {
        throw new NotImplementedException();
    }
}