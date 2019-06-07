using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Models;
using Microsoft.EntityFrameworkCore;

namespace FaleMais.Services
{
    public class PlaneService
    {
        private FaleMaisContext _context;

        public PlaneService(FaleMaisContext context)
        {
            _context = context;
        }

        public List<Plane> FindAll()
        {
            return _context.Plane.ToList();
        }

        public Plane GetPlane(Plane obj)
        {
            var _obj = _context.Plane.Where(planes => planes.Origin == obj.Origin && planes.Destiny == obj.Destiny).First();
            _obj.Time = obj.Time;
            _obj.SpeakMorePlane = obj.SpeakMorePlane;

            return  _obj;
        }

        public Plane SetNewPlane(Plane obj)
        {
            var newPlane = obj;
            int time = int.Parse(newPlane.Time.TotalMinutes.ToString());
            newPlane.CallValue = time * newPlane.PricePerMinute;
            switch (newPlane.SpeakMorePlane)
            {
                case 30:
                    if(time <= 30)
                    {
                        newPlane.PlaneCallValue = 0.0;
                    }
                    else
                    {
                        newPlane.PlaneCallValue = ((time - 30) * newPlane.PricePerMinute) * 1.10;
                    }
                    break;
                case 60:
                    if (time <= 60)
                    {
                        newPlane.PlaneCallValue = 0.0;
                    }
                    else
                    {
                        newPlane.PlaneCallValue = ((time - 60) * newPlane.PricePerMinute) * 1.10;
                    }
                    break;
                case 120:
                    if (time <= 120)
                    {
                        newPlane.PlaneCallValue = 0.0;
                    }
                    else
                    {
                        newPlane.PlaneCallValue = ((time - 120) * newPlane.PricePerMinute) * 1.10;
                    }
                    break;

            }

            return newPlane;

        }
    }
}
