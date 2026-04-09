using Microsoft.AspNetCore.Mvc;
using MyRdsApp.Data;
using MyRdsApp.Models;

namespace MyRdsApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Products.ToList());
    }

    [HttpPost]
    public IActionResult Post(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
        return Ok(product);
    }
}