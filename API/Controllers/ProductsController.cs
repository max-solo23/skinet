using System;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IGenericRepository<Product> repository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts(
        string? brand, string? type, string? sort)
    {
        var specification = new ProductSpecification(brand, type, sort);

        var products = await repository.ListAsync(specification);

        return Ok(products);
    }
    
    [HttpGet("{id:int}")] // api/products/2

        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await repository.GetByIdAsync(id);

            return product == null ? NotFound() : product;
        }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        repository.Add(product);
        
        if(await repository.SaveAllAsync())
        {
            return CreatedAtAction("GetProduct", 
                                    new {id = product.Id}, 
                                    product);
        }

        return BadRequest("Problem creating product.");
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateProduct(int id, Product product)
    {
        if (product.Id != id || !ProductExists(id))
            return BadRequest("Product ID mismatch or product not found.");
        
        repository.Update(product);

        if(await repository.SaveAllAsync())
        {
            return NoContent();
        }
        
        return BadRequest("Probelm updating the product.");
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        var product = await repository.GetByIdAsync(id);
        
        if (product == null) return NotFound();

        repository.Remove(product);

        if(await repository.SaveAllAsync())
        {
            return NoContent();
        }
        
        return BadRequest("Problem deleting the product.");
    }

    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<string>>> GetBrands()
    {
        var specification = new BrandListSpecification();

        return Ok(await repository.ListAsync(specification));
    }

    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<string>>> GetTypes()
    {
        var specification = new TypeListSpecification();

        return Ok(await repository.ListAsync(specification));
    }

    private bool ProductExists(int id)
    {
        return repository.Exists(id);
    }
}
