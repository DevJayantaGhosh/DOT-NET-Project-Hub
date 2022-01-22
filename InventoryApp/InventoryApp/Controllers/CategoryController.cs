using InventoryApp.DTO;
using InventoryApp.Models;
using InventoryApp.ServiceLayer;
using InventoryApp.ServiceLayer.ServicesImpl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _CategoryService)
        {
            this.categoryService = _CategoryService;
        }
        public IActionResult Index()
        {
            CategoryResponseListDTO responseCategorylist = new CategoryResponseListDTO();
            try
            {
                responseCategorylist = categoryService.GetAllCategory();
            }
            catch (Exception e)
            {

                return NotFound();
            }
           
            return View(responseCategorylist);
        }


        
        public IActionResult SaveCategory()
        {
            CategoryRequestDTO categoryRequestDTO = new CategoryRequestDTO();
            return View(categoryRequestDTO);
        }

        [HttpPost]
        public IActionResult SaveCategory(CategoryRequestDTO categoryRequestDTO)
        {
            CategoryResponseDTO responseCategory= new CategoryResponseDTO();
            if(ModelState.IsValid)
            {
                try
                {
                    responseCategory = categoryService.SaveCategory(categoryRequestDTO);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {

                    return NotFound();
                }
            }
        

            return View();
        }
    }
}
