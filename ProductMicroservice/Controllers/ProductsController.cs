using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Model;
using ProductMicroservice.Services.Interface;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductsController(IProductService _productService)
        {
            productService = _productService;
        }
        [HttpGet]
        public IEnumerable<Product> ProductList()
        {
           Product product = new Product();
            product.ProductDescription = "a";
            product.ProductName = "a";
            product.ProductPrice = 2;
            product.ProductId = 2;
            product.ProductStock = 2;
            return (IEnumerable<Product>)product;

        }
    }
}
