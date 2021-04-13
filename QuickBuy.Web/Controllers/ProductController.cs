using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repository.Repositories;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.GetAll());
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            try
            {
                _productRepository.add(product);
                return Created("api/product", product);
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}