using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Videojatekok
{
    public class ContainerG<T> : IContainer<T>
    {

        protected List<T> videojatekok = new List<T>();

        public List<T> ListaVissza
        {
            get
            {
                return videojatekok;
            }
        }


       
   
        public void HozzaAd(T elem)
        {
            if (videojatekok.Contains(elem))
            {
                throw new AlreadyExistsException("A lista már tartalmaz ilyen elemet!");
            }
            videojatekok.Add(elem);
        }

        public List<T> RendezesNovekvoben(Func<T, DateTime> ertek)
        {
            return videojatekok.OrderBy(ertek).ToList();
        }
        public List<T> RendezesCsokkenoben(Func<T, DateTime> ertek)
        {
            return videojatekok.OrderByDescending(ertek).ToList();
        }


        public uint LegnagyobbAr(Func<T, uint> ertek)
        {
            return videojatekok.Max(ertek);
        }





        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in videojatekok)
            {
                yield return item;
            }
        }

      
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
