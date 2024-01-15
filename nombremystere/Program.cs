


Console.WriteLine("Nombre mystère");

       
       
        Random random = new Random();
        int nombreADeviner = random.Next(1, 101);

        // Boucle pour demander à l'utilisateur
        int nombreSaisi;
        bool saisieValide;

        do
        {
            Console.Write("Devinez le nombre : ");
            string saisieUtilisateur = Console.ReadLine();

            // Conversion de la saisie utilisateur en entier
            saisieValide = int.TryParse(saisieUtilisateur, out nombreSaisi);

            if (!saisieValide)
            {
                Console.WriteLine("Veuillez entrer un nombre entier valide.");
                continue;
            }

          //comparer
            switch (nombreSaisi.CompareTo(nombreADeviner))
            {
                case -1:
                    Console.WriteLine("Le nombre est plus grand.");
                    break;
                case 1:
                    Console.WriteLine("Le nombre est plus petit.");
                    break;
                default:
                    Console.WriteLine("Félicitations ! Vous avez trouvé le nombre.");
                    break;
            }

        } while (nombreSaisi != nombreADeviner || !saisieValide);

        Console.ReadLine();
    
