using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P225Eterna.DAL;
using P225Eterna.Models;
using P225Eterna.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class PriceingController : Controller
    {
        private readonly AppDbContext _context;

        public PriceingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            PriceingVM priceingVM = new PriceingVM
            {
                Plans = _context.Plans.Include(p => p.PlanFeatures).ThenInclude(pl => pl.FeatureItem).ToList(),
                FeatureItems = _context.FeatureItems.Include(x=>x.PlanFeatures).ThenInclude(x=>x.Plan).ToList()
            };

            return View(priceingVM);
        }
    }
}
