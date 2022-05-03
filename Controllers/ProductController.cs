using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ApplicationDbContext dbContext;
        public ProductController()
        {
            dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var products = dbContext.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.category = dbContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Title, decimal Price, int Quantity,string Descr, int CategoryId)
        {
            var cat = dbContext.Categories.SingleOrDefault(e => e.Id == CategoryId);
            Products product = new Products()
            {
                Title = Title,
                Price = Price,
                Quantity = Quantity,
                Descr = Descr,
                Category = cat
            };
            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}