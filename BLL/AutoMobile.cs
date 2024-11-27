using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AutoMobile
    {
        public int Annee { get; set; }
        public string Immatriculation { get; set; }
        //public string Adresse { get; set; } = "Tunis";   // par defaut 


        public AutoMobile() { }



        public AutoMobile(int Annee, String Immatriculation)
        {
            this.Annee = Annee;
            this.Immatriculation = Immatriculation;

        }


        public override String ToString()
        {
            return "automobile annee :"+Annee + " immat :"+ Immatriculation;

        } 
        public virtual void Afficher()
        {
            Console.WriteLine(Annee);
            Console.WriteLine(Immatriculation);
        }
    }
}
