using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage
    {
        public string Adresse { get; set; }
        public List<AutoMobile> Autos;


        public enum SubType
        {
            Voiture, Moto
        }

        public Garage()
        {
            Autos = new List<AutoMobile>();

        }

        public Garage(string Adresse)
        {
            this.Adresse = Adresse;
            Autos = new List<AutoMobile>();

        }


        public string AddAuto(AutoMobile auto)
        {
            try
            {
                Autos.Add(auto);
                return string.Empty;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string AddAuto1(AutoMobile auto)
        {
           
                Autos.Add(auto);
                return string.Empty;
            }


        public List<AutoMobile> GetAutos()
        {
            return Autos;
        }


        public AutoMobile GetAuto(string immatriculation)
        {
            foreach (var item in Autos)
            {
                if (item.Immatriculation == immatriculation)
                    return item;
            }
            return null;
            // return autos.FirstOrDefault
            // (a => a.Immatriculation == immatriculation);

        }



        public string DeleteAuto(string immatriculation)
        {
            try
            {

                AutoMobile au = GetAuto(immatriculation);
                if (au != null)
                    Autos.Remove(au);
                return "";

            }

            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public List<AutoMobile> AfficherAutomobiles(SubType soustype)
        {
            List<AutoMobile> temp = new List<AutoMobile>();
            switch (soustype)
            {
                case SubType.Voiture:
                    foreach (AutoMobile a in Autos)
                    {
                        if (a is Voiture)
                            temp.Add(a);
                    }
                    break;
                case SubType.Moto:
                    foreach (AutoMobile a in Autos)
                    {
                        if (a is Moto)
                            temp.Add(a);
                    }
                    break;
            }
            return temp;
        }



        public int GetIndexAuto(AutoMobile a1)
        {
            for (int i = 0; i < Autos.Count; i++)
            {
                if (Autos[i].Immatriculation ==
                    a1.Immatriculation)

                    return i;
            }
            return -1;
            //  return autos.FindIndex(a => a == a1);

        }


        public string UpdateAuto(AutoMobile au)
        {
            try
            {

                int pos = GetIndexAuto(au);
                if (pos != -1)
                {
                    Autos[pos] = au;
                }
                else
                {
                    return "Auto not exist";
                }
                return "";

            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }

    }
