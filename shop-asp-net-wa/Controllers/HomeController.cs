using Microsoft.AspNetCore.Mvc;
using shop_asp_net_wa.Models;
using shop_asp_net_wa.ViewModels;

namespace shop_asp_net_wa.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);

            return View(homeViewModel);
        }
    }
}
