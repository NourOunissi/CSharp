// Inclusion de l'espace de noms nécessaire pour utiliser la classe Console.
using System;

// Déclaration d'une classe appelée Program.
class Program
{
    // Définition de la méthode principale Main, qui est le point d'entrée du programme.
    static void Main(string[] args)
    {
        // Définition de l'encodage de sortie pour prendre en charge les caractères UTF-8.
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Déclaration de la variable nom et initialisation avec une chaîne vide.
        string nom = "";

        // Boucle while qui se répète tant que la variable nom est vide ou nulle.
        while (string.IsNullOrEmpty(nom))
        {
            // Affichage de la question pour obtenir le nom de l'utilisateur.
            Console.Write("Quel est ton nom ? ");

            // Lecture de la saisie de l'utilisateur et assignation à la variable nom.
            nom = Console.ReadLine();

            // Vérification si le nom peut être converti en un nombre entier.
            if (int.TryParse(nom, out _))
            {
                // Affichage d'une erreur si le nom est un chiffre.
                Console.WriteLine("Erreur : Le nom ne doit pas être un chiffre");

                // Réinitialisation de la variable nom pour redemander la saisie.
                nom = "";
            }
        }

        // Déclaration de la variable age_num et initialisation à 0.
        int age_num = 0;

        // Boucle while qui se répète tant que l'âge est inférieur ou égal à 0.
        while (age_num <= 0)
        {
            // Affichage de la question pour obtenir l'âge de l'utilisateur.
            Console.Write("Quel est ton âge ? ");

            // Lecture de la saisie de l'utilisateur et assignation à la variable age_str.
            string age_str = Console.ReadLine();

            // Bloc try-catch pour gérer les erreurs de conversion de la chaîne en entier.
            try
            {
                // Tentative de conversion de la chaîne en un nombre entier.
                age_num = int.Parse(age_str);

                // Vérification si l'âge est négatif.
                if (age_num < 0)
                {
                    // Affichage d'une erreur si l'âge est négatif.
                    Console.WriteLine("Erreur : L'âge ne doit pas être négatif");
                }
                // Vérification si l'âge est égal à 0.
                else if (age_num == 0)
                {
                    // Affichage d'une erreur si l'âge est égal à 0.
                    Console.WriteLine("Erreur : L'âge ne doit pas être égal à 0");
                }
            }
            // Gestion des erreurs de conversion.
            catch
            {
                // Affichage d'une erreur si la conversion échoue.
                Console.WriteLine("Erreur : Vous devez entrer un âge valide.");
            }
        }

        // À ce stade, age_num est forcément différent de 0.

        // Affichage d'un message de salutation avec le nom et l'âge de l'utilisateur.
        Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

        // Calcul de l'âge de l'utilisateur l'année prochaine.
        int age_prochain = age_num + 1;

        // Affichage d'un message indiquant l'âge de l'utilisateur l'année prochaine.
        Console.WriteLine("Bientôt vous aurez " + age_prochain + " ans");
    }
}
