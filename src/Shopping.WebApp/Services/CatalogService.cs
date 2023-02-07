using Shopping.WebApp.Extensions;
using Shopping.WebApp.Models;

namespace Shopping.WebApp.Services;

public class CatalogService : ICatalogService
{
    private readonly HttpClient _client;

    public CatalogService(HttpClient client)
    {
        _client = client ?? throw new ArgumentException(nameof(client));
    }
    public async Task<CatalogModel> CreateCatalog(CatalogModel model)
    {
        var response = await _client.PostAsJson($"/Catalog", model);
        if (response.IsSuccessStatusCode)
            return await response.ReadContentAs<CatalogModel>();
        else
        {
            throw new Exception ("Something went wrong when calling api");
        }    
    }

    public async Task<CatalogModel> GetCatalog(string id)
    {
        var response = await _client.GetAsync("/Catalog/{id}");
        return await response.ReadContentAs<CatalogModel>();
    }

    public async Task<IEnumerable<CatalogModel>> GetCatalog()
    {
        var response = await _client.GetAsync("/Catalog");
        return await response.ReadContentAs<List<CatalogModel>>();
    }

    public async Task<IEnumerable<CatalogModel>> GetrGatalogByCatagory(string catagory)
    {
         var response = await _client.GetAsync("/Catalog/GetProductByCaatalog/{catalog}");
        return await response.ReadContentAs<List<CatalogModel>>();
    }
}