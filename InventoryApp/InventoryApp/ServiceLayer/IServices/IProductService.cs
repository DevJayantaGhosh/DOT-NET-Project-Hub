using InventoryApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.ServiceLayer.IServices
{
    public interface IProductService
    {
        ProductRequestDTO SaveProduct(ProductRequestDTO productRequestDTO);
        ProductResponseListDTO GetAllProducts();
    }
}
