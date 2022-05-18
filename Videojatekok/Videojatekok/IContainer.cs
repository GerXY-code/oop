using System;
using System.Collections.Generic;
using System.Text;

namespace Videojatekok
{
    public interface IContainer<T>: IEnumerable<T>
    {
        void HozzaAd(T elem);

        List<T> ListaVissza { get; }



    }
}
