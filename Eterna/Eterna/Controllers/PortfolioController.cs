using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private EternaDbContext _context;   
       public PortfolioController (EternaDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel 
            {
                Products = _context.Products.ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(vm);
        }

       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}