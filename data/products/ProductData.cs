using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProductsApi.Models;

namespace ProductsApi.data.products
{
    public class ProductData : IProductData
    {
        private string _productsJsonPath = @"data/products/products.json";
        private readonly IPathProvider _pathProvider;

        public ProductData(IPathProvider pathProvider)
        {
            _pathProvider = pathProvider;
        }

        public IEnumerable<ProductItem> GetProducts()
        {
            using (StreamReader products = File.OpenText(_pathProvider.MapPath(_productsJsonPath)))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (IEnumerable<ProductItem>)serializer.Deserialize(products, typeof(IEnumerable<ProductItem>));
            }
        }
    }
}