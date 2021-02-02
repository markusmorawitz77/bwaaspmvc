using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository PieRepository;
        private readonly ICategoryRepository CategoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            PieRepository = pieRepository;
            CategoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(PieRepository.AllPies);
        }
    }
}
