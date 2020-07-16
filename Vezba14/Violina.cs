using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba14
{
    public class Violina : Instrument
    {
        public Violina(VrstaInstrumenta vrstaInstrumenta, string izvodjac) : base(vrstaInstrumenta, izvodjac) 
        {

        }
        public override void Sviraj()
        {
            Console.WriteLine("Izvodjac {0} Trenutno sivra violina! ",izvodjac);
        }
    }
}
