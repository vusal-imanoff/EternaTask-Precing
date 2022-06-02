using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P225Eterna.DAL;
using P225Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<TeamMember> teamMembers = _context.TeamMembers.Include(t=>t.Position).ToList();

            return View(teamMembers);
        }
    }
}
