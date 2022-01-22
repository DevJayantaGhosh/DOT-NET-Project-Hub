using InventoryApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.ServiceLayer
{
    public interface ICategoryService
    {
        public CategoryResponseDTO SaveCategory(CategoryRequestDTO categoryRequestDTO);
        public CategoryResponseListDTO GetAllCategory();
        public CategoryResponseDTO GatCategoryByName(CategoryRequestDTO categoryRequestDTO);
       // public CategoryResponseDTO PageCategory(CategoryRequestDTO categoryRequestDTO);
    }
}
