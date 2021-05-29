using El_Projekte_Grande.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using El_Projekte_Grande.ViewModels;

namespace El_Projekte_Grande.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository; 
        private readonly ICategoryRepository _categoryCategory;

        public HomeController(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            _productRepository= productRepository;
            _categoryCategory = categoryRepository;
        }

        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProduct;
            return View(productListViewModel);

        }

   
    }
}
