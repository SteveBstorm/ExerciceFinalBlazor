using ExerciceFinal.Models;

namespace ExerciceFinal.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts(int catId = 0);
        void AddProduct(Product p);
    }
}
