using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.data.products;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductData _productData;

        public ProductController(IProductData productData)
        {
            _productData = productData;
        }
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {            
            return Json(_productData.GetProducts());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return Json(_productData.GetProducts().SingleOrDefault(p => p.productId == id));
        }
    }
}
