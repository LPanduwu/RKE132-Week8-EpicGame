string folderPath = @"C:\Users\Kasutaja\OneDrive\Dokumendid\@ TJ2021\2022-2023 õa\Kevadsemester\Programmeerimise algkursus\Nädal 8\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };
//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Bilbo Baggins", "Scooby-Doo" };
//string[] villains = {"Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}