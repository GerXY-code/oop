using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Videojatekok
{
    public class ContainerV: ContainerG<Videojatek>
    {
        
        public Videojatek LegdragabbJatek()
        {
            var max = LegnagyobbAr(m => m.Ar);
            foreach (Videojatek item in videojatekok)
            {
                if (item.Ar == max)
                {
                    return item;
                }
            }
            return default;
        }

        public List<HorrorJatek> HorrorValogatas()
        {
            return videojatekok.OfType<HorrorJatek>().ToList();
        }
        public List<AkcioJatek> AkcioValogatas()
        {
            return videojatekok.OfType<AkcioJatek>().ToList();
        }

        public List<Videojatek> RendezesNovekvo()
        {
           return RendezesNovekvoben(r => r.MegjelenesiDatum);
        }
        public void RendezesCsokkeno()
        {
            RendezesCsokkenoben(r => r.MegjelenesiDatum);
        }





    }
}
