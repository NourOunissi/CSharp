// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// demander le prenom et age
Console.Write("Entrez votre prenom : ");
        string prenom = Console.ReadLine();

Console.Write("Entrez votre âge : ");
        int age;
         while (!int.TryParse(Console.ReadLine(), out age))
         {
            Console.WriteLine("Veuillez entrer un nombre valide pour l'âge.");
            Console.Write("Entrez votre âge : ");
        }

Console.WriteLine($"Bonjour {prenom} ! Vous avez {age} ans.");

Console.ReadLine();