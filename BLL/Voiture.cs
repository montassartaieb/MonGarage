using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture : AutoMobile
    {
        public string Couleur { get; set; }
        public string TypeV { get; set; }
        public string Marque { get; set; }

        public Voiture()
        {
        }

        public Voiture(int annee , string immatriculation, string couleur, string typeV, string marque):base(annee,immatriculation)
        {
            Couleur = couleur;
            TypeV = typeV;
            Marque = marque;
        }

        public override string ToString()
        {
            return base.ToString() + " Couleur :" + Couleur + " Marque : " + Marque + " TypeV : "+ TypeV;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine(Couleur);
            Console.WriteLine(TypeV);
            Console.WriteLine(Marque);
        }
    }
}
