using ExerciceFinal.Models;

namespace ExerciceFinal.Services
{
    public interface ICategoryService
    {
        void AddCategory(string name);
        void DeleteCategory(int id);
        List<Category> GetCategories();
    }
}