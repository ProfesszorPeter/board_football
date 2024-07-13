// See https://aka.ms/new-console-template for more information

// 1. SZövegbekérés
// Console.WriteLine("Szia, hogy hívnak?");
// var nev = Console.ReadLine();
// Console.WriteLine("Szia " + nev + ", legyen szép napod!");

//2. szám kiiratás
// var eredmeny = 2+2;
// Console.WriteLine("2 + 2 = " + eredmeny);

//3. feltételek
// Console.WriteLine("Szia, hogy hívnak?");
// var nev = Console.ReadLine();
// if (nev == "Péter") {
//     Console.WriteLine("Ügyes vagy!");
//     Console.WriteLine("Blö");
// } else {
//     Console.WriteLine("Nem Péter vagy, béna vagy!");
// }

//4. ciklus
// for (var i=1; i<=10; i++) {
//     Console.WriteLine(i + ". szám");
// }

//5. függvények
using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        var sushi = new Kutya();
        sushi.Nev = "Sushi";
        sushi.Ugat();

        var kutymorgo = new Kutya();
        kutymorgo.Nev = "Kutymorgó";
        kutymorgo.Ugat();
    }
}

public class Kutya {
    public string Nev = "";

    public void Ugat() {
        Console.WriteLine(Nev + ":Vaú");
    }
}
