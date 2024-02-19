// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajalt sisestada oma perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajata järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your lastname:");

string userLastname = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastname}!");
}

