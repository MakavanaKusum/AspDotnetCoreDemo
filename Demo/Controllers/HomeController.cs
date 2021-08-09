using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models;
using Demo.Repository;
using Microsoft.AspNetCore.Mvc;


namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IBaseRepository _Baserepository;

        public HomeController(IBaseRepository baseRepository)
        {
            _Baserepository = baseRepository;

        }

        [HttpGet("GetCategories")]
        public List<CategoryViewModel> GetCategories()
        {
            List<CategoryViewModel> categories = _Baserepository.GetCategory();
            return categories;
        }


        [HttpPost("InsertCategory")]
        public Response InsertCategory(CategoryViewModel categoryViewModel)
        {
            Response response = _Baserepository.AddCategory(categoryViewModel);
            return response;
        }

        [HttpGet("GetCategoryById")]
        public Models.Category GetCategoryById(int ID)
        {
            return _Baserepository.GetCategoryById(ID);
        }

        [HttpPost("UpadateCategory")]
        public Response UpdateCategory(CategoryViewModel categoryViewModel)
        {
            Response response = _Baserepository.UpdateCategory(categoryViewModel);
            return response;
        }

        [HttpGet("DeleteCategory")]
        public Models.Category DeleteCategory(int ID)
        {
            return _Baserepository.Deletecategory(ID);
        }

        [HttpPost("Delete")]
        public Response Delete(int ID)
        {
            Response response = _Baserepository.Delete(ID);
            return response;
        }

        //// Product ::::::::::::::::::::::::::::::::

        [HttpGet("GetProduct")]
        public List<ProductViewModel> GetProduct()
        {
            List<ProductViewModel> products = _Baserepository.GetProduct();

            return products;
        }

        [HttpPost("InserProduct")]
        public Response InsertProduct(ProductViewModel productViewModel)
        {
            Response response = _Baserepository.AddProduct(productViewModel);
            return response;
        }

        [HttpPost("UpadateProduct")]
        public Response UpdateProduct(ProductViewModel productViewModel)
        {
            Response response = _Baserepository.UpdateProduct(productViewModel);
            return response;
        }

        [HttpGet("GetProductById")]
        public Models.Product GetProductById(int ID)
        {
            return _Baserepository.GetProductById(ID);
        }

        [HttpGet("DeleteProduct")]
        public Models.Product DeleteProduct(int ID)
        {
            return _Baserepository.DeleteProduct(ID);
        }

        [HttpPost("ProductDelete")]
        public Response ProductDelete(int ID)
        {
            Response response = _Baserepository.Delete_Product(ID);
            return response;
        }
    }
}
