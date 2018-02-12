using System.Collections.Generic;
using ProductsApi.Models;

namespace ProductsApi.data.products
{
    public interface IProductData
    {
        IEnumerable<ProductItem> GetProducts();
    }
}