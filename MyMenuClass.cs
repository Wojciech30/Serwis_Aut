using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis_Aut
{
    public class MyMenuClass
    {
        private readonly IAgeProviader _ageProvider;

        

        public MyMenuClass(IAgeProviader ageProviader )
        {
            _ageProvider = ageProviader;


        }

        public string CheckAge()
        {
            var age = _ageProvider.GetAge();

            if (age < 0)
                return "Wiek powinien być dodatni";
            else if (age < 18)
                return "Za mało lat";
            if (age > 65)
                return "Za dużo lat";
            else return "Odpowiedni wiek";
            

        }
    }
    public class AgeProvider : IAgeProviader
    {
        public int GetAge()
        {
            Console.WriteLine("Podaj wiek");
            while (true)
            {
                var res = Console.ReadLine();
                if(int.TryParse(res, out var intResponse))
                {
                    return intResponse;
                }
                Console.WriteLine("To nie jest liczba!");
            }
        }

    }

    public interface IAgeProviader
    {
        int GetAge();
    }
}
