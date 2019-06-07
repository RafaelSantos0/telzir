using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FaleMais.Services;
using FaleMais.Models.ViewModel;
using FaleMais.Models;

namespace FaleMais.Controllers
{
    public class PlanesController : Controller
    {
        private readonly PlaneService _planeService;

        public PlanesController(PlaneService planeService)
        {
            _planeService = planeService;
        }
        
        public IActionResult Index()
        {
            var list = _planeService.FindAll();
            return View(list);
        }

        public IActionResult Simulation()
        {
            var planes = _planeService.FindAll();
            var origens = planes.Select(plane => plane.Origin);
            var destinos = planes.Select(plane => plane.Destiny);
            var newPlanes = new List<int>();
            newPlanes.Add(30);
            newPlanes.Add(60);
            newPlanes.Add(120);
            var viewModel = new PlaneFormViewModels { Origens = origens, Destinys = destinos, Planes = newPlanes };
            return View(viewModel);
        }


        public IActionResult Simulator(PlaneFormViewModels obj)
        {

            var newPlane = _planeService.SetNewPlane(_planeService.GetPlane(obj.Plane));

            if (newPlane == null)
            {
                return NotFound();
            }
            return View(newPlane);
        }

        public IActionResult Planes()
        {
            return View();
        }
    }
}