using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Moto : AutoMobile
    {
        public double Cylindre { get; set; }
        public int VitesseMax { get; set; }

        public Moto() { }

        public Moto(int annee, string immatriculation, double Cylindre, int vitesseMax):base(annee, immatriculation)
        {
            this.Cylindre = Cylindre;
            VitesseMax = vitesseMax;
        }

        public override string ToString()
        {
            return base.ToString() + "Cylindre est :" +Cylindre + " , VitesseMax : "+ VitesseMax;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine(Cylindre);
            Console.WriteLine(VitesseMax);

        }
    }
}
