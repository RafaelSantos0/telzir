using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaleMais.Models
{
    public class Plane
    {
        public int Id { get; set; }

        [Display(Name = "DDD Origem")]
        public string Origin { get; set; }

        [Display(Name = "DDD Destino")]
        public string Destiny { get; set; }

        [Display(Name = "Preço por min")]
        [DisplayFormat(DataFormatString = "R$ {0:F2}")]
        public double PricePerMinute { get; set; }

        [Display(Name = "Tempo da Ligação")]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        [Display(Name = "Plano FaleMais")]
        [DisplayFormat(DataFormatString = "FaleMais {0}")]
        public int SpeakMorePlane { get; set; }

        [Display(Name = "Sem FaleMais")]
        [DisplayFormat(DataFormatString = "R$ {0:F2}")]
        public double CallValue { get; set; }

        [Display(Name = "Com FaleMais")]
        [DisplayFormat(DataFormatString = "R$ {0:F2}")]
        public double PlaneCallValue { get; set; }
        
        public Plane()
        {
        }

        public Plane(int id, string origin, string destiny, double pricePerMinute)
        {
            Id = id;
            Origin = origin;
            Destiny = destiny;
            PricePerMinute = pricePerMinute;
        }

        public Plane(int id, string origin, string destiny, double pricePerMinute, TimeSpan time, int speakMorePlane, double callValue, double planeCallValue) : this(id, origin, destiny, pricePerMinute)
        {
            Time = time;
            SpeakMorePlane = speakMorePlane;
            CallValue = callValue;
            PlaneCallValue = planeCallValue;
        }
    }
}
