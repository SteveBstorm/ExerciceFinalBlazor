using ExerciceFinal.Models;

namespace ExerciceFinal.Services
{
    public class CategoryService : ICategoryService
    {
        private List<Category> _categoryList;
        private int _currentId;

        public CategoryService()
        {
            _categoryList = new List<Category>();
            _currentId = 0;
        }

        public List<Category> GetCategories()
        {
            return _categoryList;
        }

        public void AddCategory(string name)
        {
            _categoryList.Add(new Category
            {
                Name = name,
                Id = ++_currentId
            });
        }

        public void DeleteCategory(int id)
        {
            _categoryList.Remove(_categoryList.Where(c => c.Id == id).FirstOrDefault());
        }

    }
}
