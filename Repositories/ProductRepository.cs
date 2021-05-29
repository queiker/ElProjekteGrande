using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace El_Projekte_Grande.Models
{
    // klasa ktora implementuje interface IProduct
    public class ProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Product> GetAllProduct => new List<Product>
        {
            new Product{ProductId =1,Name="Zloty",Price =3.99M,Description="Waluta RP", Category = _categoryRepository.GetAllCategories.ToList()[0],IsInStock = true,IsOnSale = true},
            new Product{ProductId =2,Name="Zloto",Price =5.99M,Description="Lorem ipsum dolor sit amet . ", Category = _categoryRepository.GetAllCategories.ToList()[1],IsInStock = true,IsOnSale = true},
            new Product{ProductId =3,Name="PKO BP",Price =6.99M,Description="Lorem ipsum dolor sit amet . ", Category = _categoryRepository.GetAllCategories.ToList()[2],IsInStock = true,IsOnSale = true},
            new Product{ProductId =3,Name="Bit Coin",Price =6.99M,Description="Lorem ipsum dolor sit amet .", Category = _categoryRepository.GetAllCategories.ToList()[3],IsInStock = true,IsOnSale = true},
            
          
        };

        public Product GetProductById(int productId)
        {
            return GetAllProduct.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}