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

namespace Rev
{
    public partial class NouveauMoto : Form
    {
        Moto moto = new Moto();
        public NouveauMoto(Moto mo)
        {
            InitializeComponent();
            this.moto = mo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moto.Annee = int.Parse(textAnnee.Text);
            moto.Cylindre = double.Parse(textCylindre.Text);
            moto.Immatriculation = textImm.Text;
            moto.VitesseMax = int.Parse(textVitesse.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
