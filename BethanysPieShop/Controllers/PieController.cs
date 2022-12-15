using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository,
                                ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel listViewModel = new PiesListViewModel();
            listViewModel.Pies = _pieRepository.AllPies;
            listViewModel.CurrentCategory = "Cheese Cakes";
            return View(listViewModel);
        }
    }
}