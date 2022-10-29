using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Men_Collection.Models;
using Men_Collection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Men_Collection.Pages
{
    public class StoreModel : PageModel
    {
        JsonProductFile ProductService;
        public IEnumerable<Product> Products;

        public StoreModel(JsonProductFile productService)
        {
            this.ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.getProductsData();
        }
    }
}
