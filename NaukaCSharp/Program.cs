Console.WriteLine("Dzisiaj uczymy się matematyki!");
// Console.WriteLine(4.0/6.0);
 
Console.WriteLine("Podaj pierwszą liczbę:");
double pierwszaLiczba = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Podaj drugą liczbę:");
double drugaLiczba = double.Parse(Console.ReadLine() ?? "");
double wynik = pierwszaLiczba + drugaLiczba;
Console.WriteLine($"Wynik: {wynik}");