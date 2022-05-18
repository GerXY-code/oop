using System;

namespace Videojatekok
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerV v = new ContainerV();
            v.HozzaAd(new HorrorJatek(1, "Outlast 2", new DateTime(2020,06,13), 10000, ELETKOR.FELNOTT, 7, "Szellem"));
            v.HozzaAd(new HorrorJatek(2, "The Vanishing of Eathen Carter", new DateTime(2014,07,12), 15000, ELETKOR.GYEREK, 8, "Démon"));
            v.HozzaAd(new AkcioJatek(3, "It Takes Two", new DateTime(2021, 06, 13), 10000, ELETKOR.GYEREK, 7, "Plazmalövő"));
            v.HozzaAd(new AkcioJatek(4, "God of War", new DateTime(2018, 07, 12), 20000, ELETKOR.FELNOTT, 8, "Leviathan fejsze"));

            //Ez is jó megoldás
            /*foreach (var item in v.ListaVissza)
            {
                Console.WriteLine(item);
            }
            */

            //Mivel overrideoltuk az IEnumerable-t ezért ezt is használhatjuk
            foreach (var item in v)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("A legdrágább játék adatai: {0}",v.LegdragabbJatek());
            Console.WriteLine(" ");
            foreach (Videojatek item in v.RendezesNovekvo())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            foreach (HorrorJatek item in v.HorrorValogatas())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
