using ExerciceFinal.Models;

namespace ExerciceFinal.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _productList;
        private int _currentId;

        private readonly ICategoryService _categoryService;
        public ProductService(ICategoryService categoryService)
        {
            _currentId = 0;
            _productList = new List<Product>();
            _categoryService = categoryService;
        }

        public IEnumerable<Product> GetProducts(int catId = 0) 
        { 
            if(catId >= 0) return _productList.Where(x => x.CategoryId == catId);
            return _productList;
        }

        public void AddProduct(Product p)
        {
            p.Id = ++_currentId;
            _productList.Add(p);
        }
    }
}
