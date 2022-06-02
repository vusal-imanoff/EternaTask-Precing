using Microsoft.AspNetCore.Mvc;
using P225Eterna.DAL;
using P225Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();

            return View(services);
        }
    }
}
