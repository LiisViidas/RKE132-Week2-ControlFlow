﻿// See https://aka.ms/new-console-template for more information


// rakendus kusib kasutajal valida tema sugu (m/f)
//rakendus kusib kasutajalt sisestada tema perekonnanime
//lahtudes kasutaja valikust, raksendus tervitab jargmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb maha andmeid string(sone) formaadis

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName} !");
} 
else
{
    Console.WriteLine("Welcome!");
}

