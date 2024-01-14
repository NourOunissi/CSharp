// See https://aka.ms/new-console-template for more information
//consigne créer un programme qui demande le nom puis l'age mais pas de nombre négatif

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Quel est ton nom ? ");
        string nom = Console.ReadLine();

        int age_num = 0;

        while (age_num <= 0)
        {
            Console.Write("Quel est ton age ?");
            string age_str = Console.ReadLine();

            try
            {
                age_num = int.Parse(age_str);

                if (age_num < 0)
                {
                    Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                }
            }
            catch
            {
                Console.WriteLine("Erreur : vous devez rentrer un age valide.");
            }

        }

        // ici age_num est forcément différent de 0

        Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

        int age_prochain = age_num + 1;
        Console.WriteLine(" binetot vous aurez" + age_prochain + "ans");
    }
}