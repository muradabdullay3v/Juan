using JuanFronttoEnd.DAL;
using JuanFronttoEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Controllers
{
    public class ShopController : Controller
    {
        public AppDbContext _context { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ShopViewModel shop = new ShopViewModel
            {
                Categories = _context.Categories.Where(c => !c.isDeleted).ToList(),
                Products = _context.Products.Where(c => !c.isDeleted).Where(c => !c.isNew).ToList(),
                ProductImages = _context.ProductImages.ToList(),
                Colors = _context.Colors.Where(c => !c.isDeleted).ToList(),
                Sizes = _context.Sizes.Where(c => !c.isDeleted).ToList(),
            };
            return View(shop);
        }

    }
}
