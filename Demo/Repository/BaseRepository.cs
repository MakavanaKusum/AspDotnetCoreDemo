using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Repository
{
    public class BaseRepository : IBaseRepository
    {
        public List<CategoryViewModel> GetCategory()
        {
            List<CategoryViewModel> categoryList = new List<CategoryViewModel>();
            using (DemoContext demoContext = new DemoContext())
            {
                List<Category> Category = demoContext.Category.ToList();
                foreach (Category categories in Category)
                {
                    CategoryViewModel categoryViewModel = new CategoryViewModel()
                    {
                        CategoryId = categories.CategoryId,
                        CategoryName = categories.CategoryName,
                        Description = categories.Description,
                        IsActive = categories.IsActive,

                    };
                    categoryList.Add(categoryViewModel);
                }
            };
            return categoryList;
        }

        public Response AddCategory(CategoryViewModel categoryviewmodel)
        {
            Response response = new Response();
            try
            {
                using (DemoContext demoContext = new DemoContext())
                {
                    Category categories = new Category()
                    {
                        CategoryId = categoryviewmodel.CategoryId,
                        CategoryName = categoryviewmodel.CategoryName,
                        Description = categoryviewmodel.Description,
                        IsActive = categoryviewmodel.IsActive,

                    };
                    demoContext.Add(categories);
                    demoContext.SaveChanges();
                }
                response.IsSuccess = true;
                response.Message = "data Inserted";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Category GetCategoryById(int ID)
        {
            Models.Category category = new Models.Category();
            using (DemoContext demoContext = new DemoContext())
            {
                category = demoContext.Category.Find(ID);
            };
            return category;
        }

        public Response UpdateCategory(CategoryViewModel categoryViewModel)
        {
            Response response = new Response();
            try
            {
                using (DemoContext demoContext = new DemoContext())
                {
                    Category categories = new Category()
                    {
                        CategoryId = categoryViewModel.CategoryId,
                        CategoryName = categoryViewModel.CategoryName,
                        Description = categoryViewModel.Description,
                        IsActive = categoryViewModel.IsActive,

                    };
                    demoContext.Entry(categories).State = EntityState.Modified;
                    demoContext.SaveChanges();
                }
                response.IsSuccess = true;
                response.Message = "data Updated";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response Delete(int ID)
        {
            Response response = new Response();
            try
            {
                using (DemoContext demoContext = new DemoContext())
                {
                    Models.Category category = demoContext.Category.Find(ID);
                    demoContext.Category.Remove(category);
                    demoContext.SaveChanges();

                }
                response.IsSuccess = true;
                response.Message = "data Delete";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Category Deletecategory(int ID)
        {
            Models.Category category = new Models.Category();
            using (DemoContext demoContext = new DemoContext())
            {
                category = demoContext.Category.Find(ID);
                demoContext.Category.Remove(category);
                demoContext.SaveChanges();
            }
            return category;
        }




        //Product ::::::::::::::::::

        public List<ProductViewModel> GetProduct()
        {
            List<ProductViewModel> ProductList = new List<ProductViewModel>();
            using (DemoContext demoContext = new DemoContext())
            {
                List<Product> products = demoContext.Product.ToList();
                foreach (Product product in products)
                {
                    ProductViewModel productViewModel = new ProductViewModel()
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        Cost = product.Cost,
                        Description = product.Description,
                        IsActive=product.IsActive

                    };
                    ProductList.Add(productViewModel);
                }
            };
            return ProductList;
        }


        public Response AddProduct(ProductViewModel productViewModel)
        {
            Response response = new Response();
            try
            {
                using (DemoContext demoContext = new DemoContext())
                {
                    Product product = new Product()
                    {
                        ProductId = productViewModel.ProductId,
                        ProductName = productViewModel.ProductName,
                        Cost = productViewModel.Cost,
                        Description=productViewModel.Description,
                        IsActive = productViewModel.IsActive,

                    };
                    demoContext.Add(product);
                    demoContext.SaveChanges();
                }
                response.IsSuccess = true;
                response.Message = "data Inserted";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }



        public Product GetProductById(int ID)
        {
            Models.Product product = new Models.Product();
            using (DemoContext demoContext = new DemoContext())
            {
                product = demoContext.Product.Find(ID);
            };
            return product;
        }


        public Response UpdateProduct(ProductViewModel productViewModel)
        {
            Response response = new Response();
            try
            {
                using (DemoContext demoContext = new DemoContext())
                {
                    Product product = new Product()
                    {
                        ProductId = productViewModel.ProductId,
                        ProductName = productViewModel.ProductName,
                        Cost = productViewModel.Cost,
                        Description=productViewModel.Description,
                        IsActive = productViewModel.IsActive,

                    };
                    demoContext.Entry(product).State = EntityState.Modified;
                    demoContext.SaveChanges();
                }
                response.IsSuccess = true;
                response.Message = "data Updated";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response Delete_Product(int ID)
        {
            Response response = new Response();
            try
            {
                using (DemoContext demoContext = new DemoContext())
                {
                    Models.Product product = demoContext.Product.Find(ID);
                    demoContext.Product.Remove(product);
                    demoContext.SaveChanges();
                }
                response.IsSuccess = true;
                response.Message = "data Delete";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Product DeleteProduct(int ID)
        {
            Models.Product product = new Models.Product();
            using (DemoContext demoContext = new DemoContext())
            {
                product = demoContext.Product.Find(ID);
                demoContext.Product.Remove(product);
                demoContext.SaveChanges();
            }
            return product;
        }


    }
}
