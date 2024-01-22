using System;

namespace poo
{
    public class MaClasse 
    {
        public void MaMethode() // void ne retourne rien 
        {
            Console.WriteLine("MaMethode"); //classe utilise la methode
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
