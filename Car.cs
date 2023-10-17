// Ignore Spelling: Serwis Aut

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis_Aut
{
    public class Car
    {
        public Car(int carId, string mark, string color)
        {
            CarId = carId;
            Mark = mark;
            Color = color;
        }

        public int CarId { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
    }
}
