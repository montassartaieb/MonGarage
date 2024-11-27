// See https://aka.ms/new-console-template for more information
using BLL;

Console.WriteLine("Hello, World!");

Moto m1 = new Moto();
m1.Annee = 2020;
m1.Immatriculation = "125 TN 4343";
m1.VitesseMax = 180;
m1.Cylindre = 2.5;

Moto m2 = new Moto(1990, "125 TN 4343", 250, 4);

Voiture v1 = new Voiture(1990, "125 TN 4343","Noir","V1", "VOLKSWAGEN");

string text = m1.ToString();
string text2 = m2.ToString();
string text3 = v1.ToString();

//Console.WriteLine(text);
//Console.WriteLine(text2);
//Console.WriteLine(text3);


Garage garage = new Garage();
garage.Adresse = "Rue mohamed el kinouni";
garage.AddAuto(m1);
garage.AddAuto(m2);
garage.AddAuto(v1);



List<AutoMobile> list = garage.GetAutos();

foreach (AutoMobile m in list)
{
    Console.WriteLine("--------------");
    Console.WriteLine(m.ToString());
}



