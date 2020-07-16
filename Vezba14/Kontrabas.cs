using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba14
{
    public class Kontrabas : Instrument
    {
        public Kontrabas(VrstaInstrumenta vrstaInstrumenta, string izvodjac) : base(vrstaInstrumenta, izvodjac)
        {

        }
        public override void Sviraj()
        {
            Console.WriteLine("Trenutno sivra kontrabas! ");
        }
    }
}
