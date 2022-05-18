using System;
using System.Collections.Generic;
using System.Text;

namespace Videojatekok
{
    public class HorrorJatek: Videojatek
    {
        private byte paraFaktor;

        public byte ParaFaktor
        {
            get { return paraFaktor; }
            set {
                
                if(value < 1 || value > 9)
                {
                    throw new AdrenalinException("1-9 ig terjedhet a paraszint");
                }
                paraFaktor = value;
            
            
            }
        }


        private string idegen;

        public string Idegen
        {
            get { return idegen; }
            set {


                if (value.Length < 5)
                {
                    throw new TipusException("Hibás idegen!");
                }
                idegen = value; 
            
            }
        }

        public HorrorJatek(uint azonosito,string nev, DateTime megjelenesiDatum, uint ar, ELETKOR eletkor, byte parafaktor, string idegen) : base(azonosito,nev, megjelenesiDatum, ar, eletkor)
        {
            ParaFaktor = parafaktor;
            Idegen = idegen;
        }

        public override string ToString()
        {
            return string.Format("HORROR: ID: {0} Név: {1} Megjelenés: {2} Ár: {3} Életkor: {4}, Parafaktor: {5}, Idegen: {6}", Azonosito,Nev,MegjelenesiDatum, Ar, eletkor, ParaFaktor, Idegen);
        }

    }
}
