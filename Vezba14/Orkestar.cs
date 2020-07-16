using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba14
{
    class Orkestar : Instrument
    {
        Dictionary<int, Instrument> instrumenti = new Dictionary<int, Instrument>();
        static int key = 1;

        //metoda za dodavanje instrumenata u kolekciju 
        public void DodajInstrument(Instrument instrument)
        {
            instrumenti.Add(key, instrument);
            key++;
        }

        //metodu za brisanje instrumenata iz kolekcije,
        public bool ObrisiInstrument(int kljuc)
        {
            if (instrumenti.ContainsKey(kljuc))
            {
                instrumenti.Remove(kljuc);
                return true;
            }
            else
                return false;
        }

        //metodu za pronalženje elemenata po ključu,
        public Instrument NadjiInstrument(int kljuc)
        {
            Instrument instrument = null;
            if (instrumenti.TryGetValue(kljuc, out instrument))
            {
                return instrument;
            }
            return null;

        }

        //metodu koja kao parametar prima kog je tipa instrument(žičani, duvački, udarački, kombinovani), a
        //kao povratnu vrednost vraća broj koji predstavlja koliko takvih tipova instrumenata ima u kolekciji,
        public int BrojInstrumenataPoVrsti(VrstaInstrumenta vrstaInstrumenta)
        {
            int count = 0;
            foreach (KeyValuePair<int, Instrument> keyValuePair in instrumenti)
            {
                
                if (keyValuePair.Value.VI.Equals(vrstaInstrumenta))
                {
                    count++;
                }
            }
            return count;

        }


        //metodu bez parametara koja kao povratnu vrednost vraća broj violina u kolekciji,
        public int BrojViolinaUKolekciji()
        {
            int count = 0;
            foreach (KeyValuePair<int, Instrument> keyValuePair in instrumenti)
            {
                if (keyValuePair.Value is Violina)
                {
                    count++;
                }
                return count;

            }
            return count;

        }

        //metodu bez parametara koja kao povratnu vrednost vraća broj kontrabasa u kolekciji,
        public int BrojKontrabasaUKolekciji()
        {
            int count = 0;
            foreach (KeyValuePair<int, Instrument> keyValuePair in instrumenti)
            {
                if (keyValuePair.Value is Kontrabas)
                {
                    count++;
                }
                return count;

            }
            return count;

        }
        //metodu bez parametara koja kao povratnu vrednost vraća broj frula u kolekciji,
        public int BrojFrulaUKolekciji()
        {
            int count = 0;
            foreach (KeyValuePair<int, Instrument> keyValuePair in instrumenti)
            {
                if (keyValuePair.Value is Frula)
                {
                    count++;
                }
                return count;

            }
            return count;

        }

        //metodu bez parametara koja kao povratnu vrednost vraća broj saksofona u kolekciji,
        public int BrojSaksofonaUKolekciji()
        {
            int count = 0;
            foreach (KeyValuePair<int, Instrument> keyValuePair in instrumenti)
            {
                if (keyValuePair.Value is Saksofon)
                {
                    count++;
                }
                return count;

            }
            return count;

        }

        //metodu Simfonija koja poziva redom metodu Sviraj svakog instrumenta koji se nalazi u kolekciji
        public void Simfonija()
        {
            foreach (KeyValuePair<int, Instrument> keyValuePair in instrumenti)
            {
                keyValuePair.Value.Sviraj();
            }

        }
    }
}
