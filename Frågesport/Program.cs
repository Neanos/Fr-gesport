using System;

int poäng = 0;

Console.WriteLine("Vad ska en kanin äta mest utav? a) morötter, b) hö, c) bark");
string mat = Console.ReadLine();

if (mat == "b"){
    poäng = poäng + 1;
}

Console.WriteLine("Vad är det bästa underlaget för en kanin? a) trägolv, b) stenplattor, c) mjukta mattor");
string underlag = Console.ReadLine();

if (underlag == "c"){
    poäng = poäng + 1;
}

Console.WriteLine("När byter kaniner päls? a) aldrig, b) på hösten, c) på hösten och våren");
string päls = Console.ReadLine();

if (päls == "c"){
    poäng = poäng + 1;
}

Console.WriteLine("Vad betyder det om en kanin stampar i marken? a) den är hungrig, b) den är rädd, c) den varnar");
string stamp = Console.ReadLine();

if (stamp == "b och c"){
    poäng = poäng + 2;
}

if (poäng == 5){
    Console.WriteLine($"Du fick {poäng} poäng. Grattis!");
}

else {
    Console.WriteLine($"Du fick {poäng} poäng, lycka till nästa gång.");
}
Console.ReadLine();