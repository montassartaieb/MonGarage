using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLL.Garage;

namespace Rev
{
    public partial class MonGarage : Form
    {

        List<AutoMobile> listauto = new List<AutoMobile>();

        public Garage garage = new Garage();


        public MonGarage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void remplirListe()
        {
            listBox1.Items.Clear();
            foreach (AutoMobile a in listauto)
            {
                listBox1.Items.Add(a);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirListe();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (radioMoto.Checked)
            {
                Moto v = new Moto();
                NouveauMoto nv = new NouveauMoto(v);
                if (nv.ShowDialog() == DialogResult.Cancel)
                {
                    garage.AddAuto(v);
                }
                listauto = garage.AfficherAutomobiles(SubType.Moto);
                remplirListe();
            }

            }
        }
}
