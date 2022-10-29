using Men_Collection.Models;
using Men_Collection.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoApplicationWeb_A.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormHandlerController : Controller
    {

        JsonProductFile ProductService;
        public FormHandlerController(JsonProductFile productService)
        {
            this.ProductService = productService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Product obj = new Product();
            obj.book_id = id;
            obj.name = name;
            obj.image = image;
            IEnumerable<Product> productData = ProductService.getProductsData();
            List<Product> listOfProducts = productData.ToList();
            listOfProducts.Add(obj);
            return JsonSerializer.Serialize<List<Product>>(listOfProducts);
        }
    }
}
