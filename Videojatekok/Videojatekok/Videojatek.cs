using System;
using System.Collections.Generic;
using System.Text;

namespace Videojatekok
{
    public class Videojatek
    {
        private uint azonosito;

        public uint Azonosito
        {
            get { return azonosito; }
            set { 


                azonosito = value;
            
                }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            set {

                if (value.Length == 0)
                {
                    throw new NevException("A név megadása kötelező!");
                }
                nev = value; 
            }
        }


        private DateTime megjelenesiDatum;

        public DateTime MegjelenesiDatum
        {
            get { return megjelenesiDatum; }
            set {

                if (value > DateTime.Now)
                {
                    throw new DateTimeException("A dátum nem lehet korábbi a mainál!");
                }  
                megjelenesiDatum = value; 

            
            }
        }

        private uint ar;

        public uint Ar
        {
            get { return ar; }
            set {
                
               
                ar = value; 
            }
        }


        public ELETKOR eletkor;

        public Videojatek(uint azonosito, string nev, DateTime megjelenesiDatum, uint ar, ELETKOR eletkor)
        {
            Azonosito = azonosito;
            Nev = nev;
            MegjelenesiDatum = megjelenesiDatum;
            Ar = ar;
            this.eletkor = eletkor;
        }


        public override bool Equals(object obj)
        {
            if (obj is AkcioJatek)
            {
                AkcioJatek a = obj as AkcioJatek;
                return this.Azonosito == a.Azonosito;
            }
            if (obj is HorrorJatek)
            {
                HorrorJatek a = obj as HorrorJatek;
                return this.Azonosito == a.Azonosito;
            }
            return default;
        }

       
    }
}
