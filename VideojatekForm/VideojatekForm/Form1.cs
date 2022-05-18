using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videojatekok;

namespace VideojatekForm
{
    public partial class Form1 : Form
    {
        //Példány létrehozása
        ContainerV v = new ContainerV();
        public Form1()
        {

            InitializeComponent();
            KezdetiFeltoltes();

            Refreshing();
            legdragabbJatek.DataSource = Legdragabb();
          

        }

        //Lista kezdeti feltöltése
        public void KezdetiFeltoltes()
        {
            v.HozzaAd(new HorrorJatek(1, "Outlast 2", new DateTime(2020, 06, 13), 10000, ELETKOR.FELNOTT, 7, "Szellem"));
            v.HozzaAd(new HorrorJatek(2, "The Vanishing of Eathen Carter", new DateTime(2014, 07, 12), 15000, ELETKOR.GYEREK, 8, "Démon"));
            v.HozzaAd(new AkcioJatek(3, "It Takes Two", new DateTime(2021, 06, 13), 10000, ELETKOR.GYEREK, 7, "Plazmalövő"));
            v.HozzaAd(new AkcioJatek(4, "God of War", new DateTime(2018, 07, 12), 20000, ELETKOR.FELNOTT, 8, "Leviathan fejsze"));
        }

      
        public void RefreshAscendedList()
        {
            //jatekokListaja.DataSource = null;
            jatekokTabla.DataSource = null;
            jatekokTabla.DataSource = v.RendezesNovekvoben(r => r.MegjelenesiDatum);
            //jatekokListaja.DataSource = v.RendezesNovekvoben(r => r.MegjelenesiDatum);

        }
        private void orderByAscending_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAscendedList();
        }
        public void RefreshDescendedList()
        {
           
            jatekokTabla.DataSource = null;
            jatekokTabla.DataSource = v.RendezesCsokkenoben(r => r.MegjelenesiDatum);

        }
        private void orderByDescending_CheckedChanged(object sender, EventArgs e)
        {
           RefreshDescendedList();
        }

        public List<Videojatek> Legdragabb()
        {
            List<Videojatek> legdragabb = new List<Videojatek>();
            foreach (Videojatek item in v.ListaVissza)
            {
                if (item.Ar == v.LegnagyobbAr(a => a.Ar))
                {
                    legdragabb.Add(item);
                }
            }
            return legdragabb;
        }

        public void DeleteAll()
        {
            
           
            jatekokTabla.DataSource = null;
        }

        public void Refreshing()
        {
            jatekokTabla.DataSource = v.ListaVissza;
        }

        private void jatekokTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }


        private void deleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }

        private void addGame_Click(object sender, EventArgs e)
        {
            AddGame agF = new AddGame();
            agF.ShowDialog();
        }


        public void JatekHozzaad(Videojatek j)
        {
            v.HozzaAd(j);
            Refreshing();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Refreshing();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                jatekokTabla.DataSource = null;
                jatekokTabla.DataSource = v.AkcioValogatas();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                jatekokTabla.DataSource = null;
                jatekokTabla.DataSource = v.HorrorValogatas();
            }
        }
    }
}
