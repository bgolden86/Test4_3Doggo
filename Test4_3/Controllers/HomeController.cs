using Microsoft.AspNetCore.Mvc;
using Test4_3.Models;


namespace FTest4_3.Controllers
{
    public class HomeController : Controller
    {
        private static List<DogViewModel> dog = new();
        public IActionResult Index()
        {

            // DogViewModel doggo = new DogViewModel();
            {

                return View();
            }
        }



        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dog.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ManagerData()
        {
            DogViewModel doggo = new DogViewModel();
            return View(dog);
        }

    }
}
