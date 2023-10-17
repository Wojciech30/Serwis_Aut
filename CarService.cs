using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis_Aut
{
    public class CarService
    {
        
        public void InsertNewCar(int carId, string Mark,  string Color) 
        {
            if (carId > 0 && Mark.Length > 5 && Color.Length > 5 && Color.Any(c=> char.IsDigit(c)))
            {
                Console.WriteLine("To auto jest poprawne!");
            }
            else 
            {
                Console.WriteLine("To auto jest nie poprawne!");
            }
        }
    }
}
