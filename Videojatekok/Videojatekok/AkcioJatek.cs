using System;
using System.Collections.Generic;
using System.Text;

namespace Videojatekok
{
    public class AkcioJatek: Videojatek
    {
        private byte adrenalinFaktor;

        public byte AdrenalinFaktor
        {
            get { return adrenalinFaktor; }
            set {
                
                if(value < 1 || value > 9)
                {
                    throw new AdrenalinException("1-9 ig terjedhet max az adrenalin szint!");
                }
                adrenalinFaktor = value; 
            
            
            }
        }


        private string fegyverTipus;

        public string FegyverTipus
        {
            get { return fegyverTipus; }
            set { 
                
                if(value.Length == 5)
                {
                    throw new TipusException("Hibás fegyvertípus!");
                }
                fegyverTipus = value; 
            
            }
        }

        public AkcioJatek(uint azonosito, string nev, DateTime megjelenesiDatum, uint ar, ELETKOR eletkor, byte adrenalinfaktor, string fegyvertipus): base(azonosito,nev,megjelenesiDatum,ar,eletkor)
        {
            AdrenalinFaktor = adrenalinfaktor;
            FegyverTipus = fegyvertipus;
        }

        public override string ToString()
        {
            return string.Format("AKCIO: ID: {0} Név: {1} Megjelenés: {2} Ár: {3} Életkor: {4}, AdrenalinFaktor: {5}, FegyverTipus: {6}", Azonosito, Nev, MegjelenesiDatum, Ar, eletkor, AdrenalinFaktor, FegyverTipus);
        }
    }
}
