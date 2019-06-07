using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Models;

namespace FaleMais.Data
{
    public class SeedingPlane
    {

        private FaleMaisContext _context;

        public SeedingPlane(FaleMaisContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Plane.Any())
            {
                return;
            }

            var plane1 = new Plane(1, "011", "016", 1.90);
            var plane2 = new Plane(2, "016", "011", 2.90);
            var plane3 = new Plane(3, "011", "017", 1.70);
            var plane4 = new Plane(4, "017", "011", 2.70);
            var plane5 = new Plane(5, "011", "018", 0.90);
            var plane6 = new Plane(6, "018", "011", 1.90);

            _context.Plane.AddRange(plane1, plane2, plane3, plane4, plane5, plane6);
            _context.SaveChanges();
        }
    }
}
