using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba14
{
    class Program
    {
        static void Main(string[] args)
        {

            Orkestar orkestar = new Orkestar();

            orkestar.DodajInstrument(new Violina(VrstaInstrumenta.zicani, "Jovan Jovic"));
            orkestar.DodajInstrument(new Violina(VrstaInstrumenta.zicani, "Lena Lekic"));
            orkestar.DodajInstrument(new Violina(VrstaInstrumenta.zicani, "Pera Peric"));
            orkestar.DodajInstrument(new Kontrabas(VrstaInstrumenta.zicani, "Mika Mikic"));
            orkestar.DodajInstrument(new Kontrabas(VrstaInstrumenta.zicani, "Milica Milic"));
            orkestar.DodajInstrument(new Saksofon(VrstaInstrumenta.duvacki, "Ivan Ivic"));
            orkestar.DodajInstrument(new Saksofon(VrstaInstrumenta.duvacki, "Gorana Goric"));
            orkestar.DodajInstrument(new Frula(VrstaInstrumenta.duvacki, "Milan Milic"));
            orkestar.DodajInstrument(new Frula(VrstaInstrumenta.duvacki, "Milos Misic"));
            orkestar.DodajInstrument(new Frula(VrstaInstrumenta.kombinovani, "Milos Misic"));
            orkestar.DodajInstrument(new Frula(VrstaInstrumenta.udaraljke, "Milos Misic"));
            orkestar.DodajInstrument(new Frula(VrstaInstrumenta.udaraljke, "Milos Misic"));

            orkestar.ObrisiInstrument(2);


            Console.WriteLine("Broj frula u orkestrue je " + orkestar.BrojFrulaUKolekciji());
            Console.WriteLine("Broj violina u orkestru je " + orkestar.BrojViolinaUKolekciji());
            Console.WriteLine("Broj saksofona u orkestru je " + orkestar.BrojSaksofonaUKolekciji());
            Console.WriteLine("Broj kontrabasa u orkestru je " + orkestar.BrojKontrabasaUKolekciji());


            orkestar.Simfonija();
        }
    }
}
