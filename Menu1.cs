using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis_Aut
{
    public class Printer : IPrinter
    {
        public string Print(string msg)
        {
            Console.WriteLine(msg);
            return msg;
        }
    }
    public class Menu1
    {
        public void Menu()
        {
            var printer = new Printer();

            while (true)
            {
                Console.Clear();
                var res = Console.ReadLine();
                switch (res)
                {
                    case "1":
                        {
                            printer.Print("Ok");
                            break;
                        }
                    case "2":
                        {
                            printer.Print("Not ok");
                            break;
                        }
                    case "X":
                        {
                            printer.Print("Do widzenia");
                            return;
                        }
                    default:
                        {
                            printer.Print("Nie ma takiej opcji");
                            break;
                        }
                }
                Console.ReadLine();
            }
        }
    }
    public interface IPrinter
    {
        public string Print(string msg);
    }
}
