using System;

namespace poo
{
    public class Maclasse 
    {
        public void MaMethode() // void ne retourne rien 
        {
            Console.ReadLine("MaMethode"); //classe utilise la methode
        }

        public void Ecrire(string message)
        {
            Console.WriteLine(message); 

        }

        public string Lire()
        {
            return Console.ReadLine(); 

        }

        public override string ToString()
        {
            return "MaClasse";
        }
    }
}
