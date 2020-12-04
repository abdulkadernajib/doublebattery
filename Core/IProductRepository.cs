using System.Threading.Tasks;
using doublebattery.Core.Models;
using doublebattery.Models;

namespace doublebattery.Core
{
    public interface IProductRepository
    {
        Task<Product> GetProduct(int id, bool includeRelated = true);

        void Add(Product product);
        void Delete(Product product);
        Task<Product> GetProducts(Filter filter);
    }
}