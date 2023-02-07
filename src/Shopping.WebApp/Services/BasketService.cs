using Shopping.WebApp.Extensions;
using Shopping.WebApp.Models;

namespace Shopping.WebApp.Services;

public class BasketService : IBasketService
{
    private readonly HttpClient _client;

    public BasketService(HttpClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public async Task CheckoutBasket(BasketChackoutModel model)
    {
        var response = await _client.PostAsJson($"/Basket/Checkout", model);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Something went wrong when calling api.");
        }
    }

    public async Task<BasketModel> UpdateBasket(BasketModel model)
    {
        var response = await _client.PostAsJson($"/Basket", model);
        if (response.IsSuccessStatusCode)
            return await response.ReadContentAs<BasketModel>();
        else
        {
            throw new Exception("Something went wrong when calling api.");
        }
    }

    public async Task<BasketModel> GetBasket(string userName)
    {
        var response = await _client.GetAsync($"/Basket/{userName}");
        return await response.ReadContentAs<BasketModel>();
    }
}