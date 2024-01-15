// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nombre mystère");




        
        const int nombreADeviner = 42;

// boucle pour demander à l'utilisateur 
int tentative;
do
{
    Console.Write("Devinez le nombre : ");
    string saisieUtilisateur = Console.ReadLine();

    // conv
    if (int.TryParse(saisieUtilisateur, out tentative))

    /**if (string input = console.readLine();
    int saisieUtilisateur = int.Parse(input); )*/
            
            {
        // Comparer la tentative avec le nombre à deviner
        if (tentative < nombreADeviner)
        {
            Console.WriteLine("Le nombre est plus grand.");
        }
        else if (tentative > nombreADeviner)
        {
            Console.WriteLine("Le nombre est plus petit.");
        }
        else
        {
            Console.WriteLine("Félicitations ! Vous avez trouvé le nombre.");
        }
    }
            else
    {
        Console.WriteLine("Veuillez entrer un nombre entier valide.");
    }

} while (tentative != nombreADeviner);

Console.ReadLine(); 
