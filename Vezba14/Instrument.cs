using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba14
{
    public enum VrstaInstrumenta { zicani,duvacki,udaraljke,kombinovani}

    public abstract class Instrument
    {
        VrstaInstrumenta vrstaInstrumenta;
        protected string izvodjac;
        public Instrument(VrstaInstrumenta vrstaInstrumenta,string izvodjac)
        {
            this.vrstaInstrumenta = vrstaInstrumenta;
            this.izvodjac = izvodjac;
        }
        public VrstaInstrumenta VI
        {
            get { return vrstaInstrumenta; }
        }
        public string Izvodjac
        {
            get { return izvodjac; }
        }
        public abstract void Sviraj();
    }
}
