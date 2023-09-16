using Shopping.Agregator.Models;
using System.Threading.Tasks;
namespace Shopping.Agregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}