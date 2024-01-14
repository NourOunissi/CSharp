// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 42;
string s = i.ToString();

Console.WriteLine(s);

string s2 = "1234";
// Convertir une chaine en entier

int i2 = int.Parse(s2);

string sf = "1234.56"; // string float 
// convertir une chaine en float 
float f = float.Parse(sf);

string chaine123 = "123";
int i123 = Convert.ToInt32(chaine123);

// code pour convertir une chaine de c
Console.WriteLine( "Entrez votre age: ");
string input = Console.ReadLine(); // on stock dans une chaine 
int age = int.Parse(input); // convertie la chaine d ecaratere en  entier par int.parse
int annee = 2024 -age;

Console.WriteLine($"Vous êtes né en {2024-age}.")