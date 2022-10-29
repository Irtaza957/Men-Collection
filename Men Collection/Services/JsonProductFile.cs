using Men_Collection.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Men_Collection.Services
{
    public class JsonProductFile
    {
        public IWebHostEnvironment WebHostEnvironment;

        public JsonProductFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;

        }
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json");
            }
        }
        public IEnumerable<Product> getProductsData()
        {
            using (var file_stream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Product[]>(file_stream.ReadToEnd());
            }
        }
    }
}
