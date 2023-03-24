using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            // Add some default categories

            categories = new List<Category>()
            {
                new Category { CategoriesId= 1, Name = "Beverage", Description = "Beverage" },
                new Category { CategoriesId= 2, Name = "Bakery", Description = "Bakery"},
                new Category { CategoriesId= 3, Name = "Meat", Description = "Meat"},
                new Category{ CategoriesId= 4,Name = "Indian Food", Description = "Snack"}
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoriesId);
                category.CategoriesId = maxId + 1;
            }
            else
            {
                category.CategoriesId = 1;
            }
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoriesId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoriesId == categoryId);
        }

        public void deleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId)); 
        }
    }
}