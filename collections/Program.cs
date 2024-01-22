// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/**Syntaxe générique
type[] nomDuTableau = new type[tailleDuTableau];

int[] tableauEntiers = new int[5];
tableauEntiers[0] = 11 ; // Element 0 du tableau (premier élément)
tableauEntiers[1] = 21 ; 
tableauEntiers[2] = 15 ; 
tableauEntiers[3] = 7 ; 
tableauEntiers[4] = 11 ; 

int [] tableauEntiers = new int[5]{11, 21, 15, 7, 101}; **/

string[]  tableauChaines = new string[] {"Bonjour", "à", "tous"};

string[] mois = new string[] {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre, "Novembre", "Décembre"};

Console.WriteLine(mois[0]); // Afficher "Janvier"
//01/12/2024 -> 01 janvier 2024
//Console.Writeline(jour + "" +mois[mois-1] + "" + annee);

for (int i = 0; i < mois.Length; i++)
{
    Console.WriteLine(mois[i];)
}

// Les listes

// syntaxe générique
// List<type> nomDeLaListe = newList<type>();

// Exemple 
List<<int> listeEntiers = new List<int>();
listeEntiers.Add(11); //add ajouter un element si il y add il y a remove supprimer de la liste
listeEntiers.Add(21);
listeEntiers.Add(15);

/** Console.WriteLine(listeEntiers[0]); //Affiche 11
Console.WriteLine(listeEntiers[1]);
Console.WriteLine(listeEntiers[2]); */

listeEntiers.remove(21);
console.WriteLine($"{listeEntiers.Count} éléments dans la liste") ;

for (int i = 0; i < listeEntiers; i++)
{
    Console.WriteLine(mois[i];)
}