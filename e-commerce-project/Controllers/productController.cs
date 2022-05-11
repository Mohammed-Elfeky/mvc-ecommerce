using Microsoft.AspNetCore.Mvc;
using e_commerce_project.Repos;
using System.Collections.Generic;
using e_commerce_project.Models;
namespace e_commerce_project.Controllers
{
    public class ShowProductController : Controller
    {
        IProductRepo productRepo;
        public ShowProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        
        public IActionResult Products()
        {
            List<Product> products=productRepo.GetAll();
            return View(products);
        }

        public IActionResult getProductById(int id)
        {
            Product product=productRepo.FindById(id);
            return View(product);
        }


        public IActionResult search(string name)
        {
            List<Product> products = productRepo.searchByName(name);
            return Json(products);
        }

    }
}
