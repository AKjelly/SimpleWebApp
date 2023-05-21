using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Data;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository _productRepository;

        public HomeController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }

        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //[HttpPost]
        //public IActionResult AddProduct(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productRepository.AddProduct(product);
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}

//        public IActionResult EditProduct(int id)
//        {
//            var product = _productRepository.GetProductById(id)
//;
//            if (product == null)
//            {
//                return NotFound();
//            }
//            return View(product);
//        }

        //[HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = _productRepository.GetProductById(id)
;
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            _productRepository.DeleteProduct(product.Id);
            return RedirectToAction("Index");
        }
    }
}
