using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Repository
{
   public interface IBaseRepository
    {
        List<CategoryViewModel> GetCategory();

        Response AddCategory(CategoryViewModel categoryviewmodel);

        Response UpdateCategory(CategoryViewModel categoryViewModel);

        Models.Category GetCategoryById(int ID);

        Models.Category Deletecategory(int ID);

        Response Delete(int ID);


        // Product
        List<ProductViewModel> GetProduct();

        Response AddProduct(ProductViewModel productViewModel);

        Response UpdateProduct(ProductViewModel productViewModel);

        Models.Product GetProductById(int ID);

        Models.Product DeleteProduct(int ID);

        Response Delete_Product(int ID);

    }
}
