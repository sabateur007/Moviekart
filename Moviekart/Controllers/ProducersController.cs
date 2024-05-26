﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moviekart.Data;

namespace Moviekart.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
                _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllProducers = await _context.Producers.ToListAsync();
            return View(AllProducers);
        }
    }
}
