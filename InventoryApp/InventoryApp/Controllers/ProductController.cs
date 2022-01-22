using InventoryApp.DTO;
using InventoryApp.Models;
using InventoryApp.ServiceLayer.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly Models.AppDBContext appDBContest;
        public ProductController(IProductService _IProductService, AppDBContext appDB)
        {
            this.productService = _IProductService;
            this.appDBContest = appDB;
        }

   
     
        public IActionResult Index()
        {
            ProductResponseListDTO productResponseListDTO = new ProductResponseListDTO();
            productResponseListDTO = this.productService.GetAllProducts();
            return View(productResponseListDTO);
        }



        public IActionResult SaveProd()
        {
            List<Category> categories = appDBContest.Categories.ToList();
            SelectList selectListItems = new SelectList(categories, "CategoryNo", "CategoryName");
            ViewBag.DropdownData = selectListItems;
            ProductRequestDTO ProductRequestDTO = new ProductRequestDTO();


            return View(ProductRequestDTO);
        }



        [HttpPost]
        public IActionResult SaveProd(ProductRequestDTO productRequestDTO)
        {
           
            //get Parent Category
            int catID = productRequestDTO.Product.CategoryRefNo;
            Category category = this.appDBContest.Categories.Find(catID);

            //Add category to the Product
            Product p = new Product();
            p.ProdName = productRequestDTO.Product.ProdName;
            p.ProdPrice = productRequestDTO.Product.ProdPrice;
            p.CreatedBy = "Jayanta";
            p.CreatedDate = DateTime.Now;// when u use parent to update then not set it
            p.ModifiedDate = DateTime.Now;


            //p.RefCategory = category;         //////Add parent to the child and save child                            
            //this.appDBContest.Add(p);//save child
            //appDBContest.SaveChanges();

            /////====================Parent should be added OneTime  next time update====================//////
            List<Product> listp = new List<Product>();
            listp.Add(p);
            category.Products = listp;   ///// add child to parent                        
            this.appDBContest.Update(category);//Update parent
            this.appDBContest.SaveChanges();




            return RedirectToAction("Index");
        }
    }
}
