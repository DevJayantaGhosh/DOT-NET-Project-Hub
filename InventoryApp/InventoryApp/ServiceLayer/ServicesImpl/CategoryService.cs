using InventoryApp.DTO;
using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace InventoryApp.ServiceLayer.ServicesImpl
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDBContext appDBContext;
      
     
        public CategoryService(AppDBContext _appDB)
        {
            this.appDBContext = _appDB;
        }

        public CategoryResponseDTO GatCategoryByName(CategoryRequestDTO categoryRequestDTO)
        {
            throw new NotImplementedException();
        }

        public CategoryResponseListDTO GetAllCategory()
        {
            CategoryResponseListDTO responseCategorylist = new CategoryResponseListDTO();
            try
            {
                responseCategorylist.Categorys= appDBContext.Categories.ToList();

                responseCategorylist.Message = "";
                responseCategorylist.StatusCode = 0;
                if (responseCategorylist.Categorys.Count>0)
                {
                    responseCategorylist.Message = "Received---";
                    responseCategorylist.StatusCode = (int) HttpStatusCode.OK;
                 
                    return responseCategorylist;
                }
                else
                {
                  
                    return responseCategorylist;
                }



            }
            catch (Exception e)
            {

                throw new Exception("Something Went Wrong !!");
            }
        }

        public CategoryResponseDTO SaveCategory(CategoryRequestDTO categoryRequestDTO)
        {
            Category category = new Category();
            category.CategoryName = categoryRequestDTO.CategoryName;
            category.CreatedBy = "Admin";
            category.CreatedDate = DateTime.Now;
            category.ModifiedDate = DateTime.Now;

            CategoryResponseDTO responseCategory = new CategoryResponseDTO();

            try
            {
                appDBContext.Add(category);
                var result = appDBContext.SaveChangesAsync();
                
                    responseCategory.Message = "Saved---"+result.Result.ToString();
                    responseCategory.StatusCode = result.Result;
                    responseCategory.Category = category;
                    return responseCategory;
                
                
              


            }
            catch (Exception e)
            {

                responseCategory.Message = "Not Saved---";
                responseCategory.StatusCode = (int) HttpStatusCode.BadRequest;
                responseCategory.Category = category;
                return responseCategory;
            }




        }
    }
}
