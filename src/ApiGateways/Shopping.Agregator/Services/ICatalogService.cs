using Shopping.Agregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Shopping.Agregator.Services
{
    public interface ICatalogService 
    {
        Task<IEnumerable<CatalogModel>> GetCatalog();
        Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category);
        Task<CatalogModel> GetCatalog(string id);
    }
}