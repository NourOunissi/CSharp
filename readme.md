git init = cree un dossier git. dans c#
git add . = ajouter les fichier (commit )
git commit -m "Commit initial" = gi
git branch -M main = renommer master en main
git remote add origin https://github.com/NourOunissi/CSharp.git = nouveau depot distant
git remote -v = afficher les origin 
git push -u origin main = push
dotnet --version = verifier
dotnet --list-sdks = sdk
céer un projet = dotnet new console -n exercice1
cd exercice1 = aller dans
dotnet run = 
cd.. = revenir à la racine
Depot pour travail sur c#

// Utilisation de l'objet Console 
Console.writeline ("Hi Barbie") ;  = methode + ("chaine de caractére") virgule pour compiler
. = -> acceder
// declaration et affectation
variable typé =  int i ;
declaration = type (string , bool , int) + nom de la variable + initiation de la valeur 
var = un type de données implicite qui detrminé 

//réaffectation de variable 
i = 5 apres i = 8

// affectation par valeur de retour d'une méthode 
Console.ReadLine = methode qui retoune la valaur saisit par l'utilisateur 

const float tva = 19.6 f; = contante fixe pendant tout le programme exemple cnt pi 

// exo2
different type entier =

//entiers signés (positif ou négatif = 8 bit binaire le premier chiffre est 1= negatif 0 = positif)
system.Sbyte i 0; =  8bits(1byte signé) ->  128 = sbyte
system.Int16 i = 0; = 16bits(2bytes signé) -> 32 768 =short
system.Int32 i = 0; = 32bits(bytes signé) -> 2 147 483 648 = veritable nom du type de "int"
system.Int64 i = 0; = 64bits(8bytes signé) -> 9 223 372 036 854 775 808 = long

// entier non signés(le 1er bit fait partie de la valeur)
Systeme.Byte i = 0; = 8bits(1byte non signé) -> 255 = byte
system.UInt16 i = 0; = 16bits(2bytes non  signé) -> 65 535 = unshort
system.UInt32 i = 0; = 32bits(bytes non signé) -> 4 294 967 295 = uint 
system.UInt64 i = 0; = 64bits(8bytes non  signé) -> 18 446 744 073 709 551 615 = ulong

//nombre décimaux
system.Single i = 0; =32bits(4bytes) ->3.402823e28 = float
Systém.Double i = 0; = 64bits(8bytes) -> 1.79769313486232e308 = double
System.Decimal i = 0; = 128bits(bytes) -> 7.92281625142643e28 = decimal 

//Types vraiment utiles 
int, byte, decimal 

//suffixes
var i = 0.5 f ; = float
