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
        private readonly ICategoryRepository _categoryRepository;
        private readonly IChatRepositories _chatRepository;




        public HomeController(IProductRepository productRepository,ICategoryRepository categoryRepository, IChatRepositories chatRepositories)
        {
            _productRepository= productRepository;
            _categoryRepository = categoryRepository;
            _chatRepository = chatRepositories;

        }

        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProduct;
            return View(productListViewModel);

        }
     
        public IActionResult Chat()
        {
            var chatViewModel = new ChatViewModel();
            chatViewModel.News = _chatRepository.GetNews;
            return View(chatViewModel);

        }

    }
}


//=================================================
/*
public class ChatController
{

    private readonly IChatRepositories _chatRepository;

    public ChatController(IChatRepositories chatRepositories)
    {
        _chatRepository = chatRepositories;

    }

    public IActionResult Index()
    {
        var chatViewModel = new ChatViewModel();
        chatViewModel.News = _chatRepository.GetNews;
        return View(chatViewModel);

    }
}
*/