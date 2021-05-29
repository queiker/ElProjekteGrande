using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace El_Projekte_Grande.Models
{
    // klasa ktora implementuje interface Icategory
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId =1,CategoryName="Waluta",Description="Lorem ipsum"},
            new Category{CategoryId =2,CategoryName="Kruszec",Description="Lorem ipsum"},
            new Category{CategoryId =3,CategoryName="Akcje",Description="Lorem ipsum"},
            new Category{CategoryId =4,CategoryName="Krypto Waluta",Description="Lorem ipsum"},
        };
    }
}