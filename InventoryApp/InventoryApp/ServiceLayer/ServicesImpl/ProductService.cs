using InventoryApp.DTO;
using InventoryApp.Models;
using InventoryApp.ServiceLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.ServiceLayer.ServicesImpl
{
    public class ProductService : IProductService
    {
        private readonly AppDBContext appDBContest;
        public ProductService(AppDBContext appDB)
        {
            this.appDBContest = appDB;
        }

        public ProductResponseListDTO GetAllProducts()
        {
            ProductResponseListDTO productResponseListDTO = new ProductResponseListDTO();
            try
            {
                productResponseListDTO.Products= appDBContest.Products.ToList();
                productResponseListDTO.Message = "Received";
                return productResponseListDTO;
            }
            catch (Exception e)
            {


                productResponseListDTO.Message = e.Message;
                return productResponseListDTO;
            }
        }

        public ProductRequestDTO SaveProduct(ProductRequestDTO productRequestDTO)
        {
            Product p = new Product();
            p.ProdName = productRequestDTO.Product.ProdName;
            p.ProdPrice = productRequestDTO.Product.ProdPrice;
            p.RefCategory = productRequestDTO.Product.RefCategory;
            p.CreatedBy = "ProdAdmin";
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            try
            {
               
                this.appDBContest.Add(p);
               var result= appDBContest.SaveChangesAsync();
                if (result.IsCompleted == true)
                {
                    productRequestDTO.Message = result.Result.ToString();
                    productRequestDTO.SatatusCode = (int) System.Net.HttpStatusCode.OK;
                    return productRequestDTO;
                }
                else
                {
                    productRequestDTO.Message = result.Result.ToString();
                    productRequestDTO.SatatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                    return productRequestDTO;
                }

            }
            catch (Exception e)
            {

                productRequestDTO.Message = e.Message;
                productRequestDTO.SatatusCode = (int)System.Net.HttpStatusCode.ExpectationFailed;
                return productRequestDTO;
            }
        }
    }
}
