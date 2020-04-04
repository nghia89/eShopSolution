using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eShopSolution.Api.Models;
using eShopSolution.Application.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Public;

namespace eShopSolution.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(IPublicProductService publicProductService,
            IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var products = await _manageProductService.GetAll();
            return Ok(products);
        }

    }
}
