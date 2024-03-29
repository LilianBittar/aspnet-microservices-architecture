using Shopping.WebApp.Models;

namespace Shopping.WebApp.Services;

public interface IBasketService
{
    Task<BasketModel> GetBasket(string userName);
    Task<BasketModel> UpdateBasket(BasketModel model);
    Task CheckoutBasket(BasketChackoutModel model);
}
