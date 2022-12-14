using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "All-fruits" },
                new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "Cheesy" },
                new Category { CategoryId = 3, CategoryName = "Seasonal pies", Description = "Get in" }
            };
    }
}