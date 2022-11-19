using HouseHoldItems.Models;
using HouseHoldItems.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace HouseHoldItems.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHouseholdItems _householdItems;

        public HomeController(ILogger<HomeController> logger, IHouseholdItems householdItems)
        {
            _logger = logger;
            this._householdItems = householdItems;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = _householdItems.GetAllProducts();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Products product)
        {
            //Creating an instance of productcreate view model
            //View model are used to pass data from controller to a view
            ProductCreateViewModel productCreateViewModel = new ProductCreateViewModel();
            if (ModelState.IsValid)
            {
                Products newProduct = _householdItems.AddProduct(product);
                return RedirectToAction("index");
            }
            return View(productCreateViewModel);
        }
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            Products product = _householdItems.GetProductbyId(id);
            if (product == null)
            {
                return View("NotFound");
            }
            return View(product);


        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Products product = _householdItems.GetProductbyId(id);
            if (product == null)
            {
                return View("NotFound");
            }
            ProductEditViewModel productEditViewModel = new ProductEditViewModel()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                ProductCategory = product.ProductCategory,
                ImgUrl = product.ImgUrl,
                Cost = product.Cost
            };
            return View(productEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(ProductEditViewModel product)
        {
            if (ModelState.IsValid)
            {
                Products prod = _householdItems.GetProductbyId(product.ProductId);
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.ProductCategory = product.ProductCategory;
                prod.ImgUrl = product.ImgUrl;
                prod.Cost = product.Cost;

                Products p =_householdItems.Update(prod);
                return RedirectToAction("index");
            }
            return View(product);


        }
        public IActionResult Delete(int id)
        {
            Products products = _householdItems.DeleteProduct(id);
            if (products == null)
            {
                return View("NotFound");
            }
            return RedirectToAction("index");
        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
