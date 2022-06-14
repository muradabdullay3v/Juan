using JuanFronttoEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Areas.JuanAdmin.Controllers
{
    [Area("JuanAdmin")]
    public class SlideController : Controller
    {
        private AppDbContext _context { get; }
        public SlideController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Slides);
        }

    }
}
