using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REVISE.Models;

namespace API_REVISE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        
        private readonly ApplicationDbContext applicationDb;
            public ProductController(ApplicationDbContext applicationDb)
            {
                this.applicationDb = applicationDb;
            }
            [HttpGet]
            public IActionResult Get()
            {
                var products = applicationDb.Products.ToList();

                return Ok(products);


            }
            [HttpPost]
            public IActionResult Post(Product products)
            {
                applicationDb.Products.Add(products);
                applicationDb.SaveChanges();
                return Ok(new { ok = true, message = "product created successfully...." });
            }
        
    }
}
