using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace El_Projekte_Grande.Models
{
    public interface IProductRepository
    {

        public IEnumerable<Product> GetAllProduct { get; }
        Product GetProductById(int productId);
    }
}
  