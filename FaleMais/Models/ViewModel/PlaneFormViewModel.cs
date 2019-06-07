using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Services;

namespace FaleMais.Models.ViewModel
{
    public class PlaneFormViewModels
    {
        public Plane Plane { get; set; }
        public IEnumerable<String> Origens { get; set; }
        public IEnumerable<String> Destinys { get; set; }
        public ICollection<int> Planes { get; set; }
    }
}
