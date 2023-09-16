using Shopping.Agregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Shopping.Agregator.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}