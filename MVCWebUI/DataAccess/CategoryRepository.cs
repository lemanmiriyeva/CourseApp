using System.Collections.Generic;
using System.Linq;
using MVCWebUI.Models.Entity;

namespace MVCWebUI.DataAccess
{
    public static class CategoryRepository
    {
        private static List<Category> _categories;

        static CategoryRepository()
        {
            _categories=new List<Category>()
            {
                new Category()
                {
                    Id = 1,Name = "Macera"
                },
                new Category()
                {
                Id = 2,Name = "Romantik"
                },
                new Category()
                {
                    Id = 3,Name = "Bilim-Kurgu"
                },
                new Category()
                {
                    Id = 4,Name = "Savaş"
                },
                new Category()
                {
                    Id = 5,Name = "Komedi"
                }
            };
        }

        public static List<Category> Categories()
        {
            return _categories;
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(m => m.Id == id);
        }
    }
}
