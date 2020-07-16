using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba14
{
    public class Saksofon : Instrument
    {
        public Saksofon(VrstaInstrumenta vrstaInstrumenta, string izvodjac) : base(vrstaInstrumenta, izvodjac)
        {

        }
        public override void Sviraj()
        {
            Console.WriteLine("Trenutno sivra saksofon! ");
        }
    }
}
