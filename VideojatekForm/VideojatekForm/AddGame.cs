using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Videojatekok;

namespace VideojatekForm
{
    public partial class AddGame : Form
    {
        Form1 f1 = (Form1)Application.OpenForms["Form1"];
        public AddGame()
        {
            InitializeComponent();
            EnumUploads();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddGame_Load(object sender, EventArgs e)
        {

        }

        public void EnumUploads()
        {
            comboBox1.DataSource = Enum.GetNames(typeof(ELETKOR));
            comboBox2.DataSource = Enum.GetNames(typeof(ELETKOR));

        }
        public void AddActionGame()
        {
            try
            {
                f1.JatekHozzaad(new AkcioJatek((uint)numericUpDown1.Value, textBox1.Text, dateTimePicker1.Value, (uint)numericUpDown2.Value, (ELETKOR)comboBox1.SelectedIndex, (byte)numericUpDown3.Value, textBox2.Text));

            }
            catch (AlreadyExistsException e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void AddHorrorGame()
        {
            try
            {
            f1.JatekHozzaad(new AkcioJatek((uint)numericUpDown4.Value, textBox3.Text, dateTimePicker2.Value, (uint)numericUpDown5.Value, (ELETKOR)comboBox2.SelectedIndex, (byte)numericUpDown6.Value, textBox4.Text));

            }
            catch (AlreadyExistsException e)
            {

                MessageBox.Show(e.Message);
            }
        }



        private void actBtnAdd_Click(object sender, EventArgs e)
        {
            
            AddActionGame();
        }

        private void hrBtnAdd_Click(object sender, EventArgs e)
        {
            AddHorrorGame();
        }
    }
}
