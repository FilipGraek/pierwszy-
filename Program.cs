// Console.WriteLine("jak masz na imie?");
// string imie = Console.ReadLine();
// Console.WriteLine($"Witaj {imie}!");

int a,b,c,d; 
// Console.WriteLine("Podaj pierwszą liczbę:");
// double pierwszaLiczba = double.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj drugą liczbę:");
// double drugaLiczba = double.Parse(Console.ReadLine() ?? "");
// double wynik = (pierwszaLiczba + drugaLiczba) / 2.0;
// Console.WriteLine($"Wynik: {wynik});


// Console.WriteLine("Podaj pierwszą liczbę:");
// double pierwszaLiczba = double.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj drugą liczbę:");
// double drugaLiczba = double.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj trzecią liczbę:");
// double trzeciaLiczba = double.Parse(Console.ReadLine() ?? "");
// if (pierwszaLiczba > drugaLiczba && pierwszaLiczba > trzeciaLiczba)
// {
//     Console.WriteLine($"Największa liczba to: {pierwszaLiczba}");
// }
// else if (drugaLiczba > pierwszaLiczba && drugaLiczba > trzeciaLiczba)
// {
//     Console.WriteLine($"Największa liczba to: {drugaLiczba}");
// }
// else
// {
//     Console.WriteLine($"Największa liczba to: {trzeciaLiczba}");
// }


// Console.WriteLine("Podaj pierwszą liczbę:");
// double pierwszaLiczba = double.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj drugą liczbę:");
// double drugaLiczba = double.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj trzecią liczbę:");
// double trzeciaLiczba = double.Parse(Console.ReadLine() ?? "");
// if ((pierwszaLiczba > drugaLiczba && pierwszaLiczba > trzeciaLiczba) ||
//     (drugaLiczba > pierwszaLiczba && drugaLiczba > trzeciaLiczba) ||
//     (trzeciaLiczba > pierwszaLiczba && trzeciaLiczba > drugaLiczba))
// {
//     Console.WriteLine($"Największa liczba to: {Math.Max(pierwszaLiczba, Math.Max(drugaLiczba, trzeciaLiczba))}");
// }
// else
// {
//     Console.WriteLine("Nie ma jednej największej liczby.");
// }


// Console.WriteLine("Podaj pierwszą liczbę:");
// double pierwszaLiczba = double.Parse(Console.ReadLine() ?? "");
// a = (int)pierwszaLiczba;
// Console.WriteLine("Podaj drugą liczbę:");
// double drugaLiczba = double.Parse(Console.ReadLine() ?? "");
//  b = (int)drugaLiczba;
// Console.WriteLine("Podaj trzecią liczbę:");
// double trzeciaLiczba = double.Parse(Console.ReadLine() ?? "");
//  c = (int)trzeciaLiczba;
// double trójmiankwadratowy = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
// Console.WriteLine($"Suma kwadratów liczb: {trójmiankwadratowy}");













// a = (int)Math.Sqrt(2);
// b= (int)Math.Sqrt(3);

// double pierwiastek_z_dwóch_do_potęgi_trzeciej = Math.Pow(a, 3);
// c =(int) pierwiastek_z_dwóch_do_potęgi_trzeciej;
// double pierwiastek_z_trzech_do_potęgi_drugiej = Math.Pow(b, 2);
// d = (int)pierwiastek_z_trzech_do_potęgi_drugiej;
// if (c > d)

// {
//     Console.WriteLine($"Pierwiastek z dwóch do potęgi trzeciej jest większy");
// }
// else if (c < d)
// {
//     Console.WriteLine($"Pierwiastek z trzech do potęgi drugiej jest większy");
// }
// else
// {
//     Console.WriteLine("Oba pierwiastki są równe.");
// }



// Console.WriteLine("podaj rok");
// d = int.Parse(Console.ReadLine() ?? "");
// if (d % 4 == 0 && (d % 100 != 0 || d % 400 == 0))
// {
//     Console.WriteLine($"Rok {d} jest przestępny");
// }
// else
// {
//     Console.WriteLine($"Rok {d} nie jest przestępny");
// }



// Console.WriteLine("Podaj pierwszą liczbę:");
// double pierwszaLiczba = double.Parse(Console.ReadLine() ?? "");
// a = (int)pierwszaLiczba;
// Console.WriteLine("Podaj drugą liczbę:");
// double drugaLiczba = double.Parse(Console.ReadLine() ?? "");
// b = (int)drugaLiczba;
// Console.WriteLine("Podaj trzecią liczbę:");
// double trzeciaLiczba = double.Parse(Console.ReadLine() ?? "");
// c = (int)trzeciaLiczba;
//     Console.WriteLine($"środkowa liczba to:{Math.Max(Math.Min(a,b), Math.Min(Math.Max(a,b), c))}");


// Console.WriteLine("Podaj pierwszą liczbę:");
// a = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj drugą liczbę:");
// b = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj trzecią liczbę:");
// c = int.Parse(Console.ReadLine() ?? "");
// a = System.Convert.ToByte(a);
// b = System.Convert.ToByte(b);
// c = System.Convert.ToByte(c);
// if(a > b && a > c && b > c)
// {
//     Console.WriteLine(c + " " + b + " " + a);
// }
// else if(a > b && a > c && c > b)
// {
//     Console.WriteLine(b + " " + c + " " + a);
// }
// else if(b > a && b > c && a > c)
// {
//     Console.WriteLine(c + " " + a + " " + b);
// }
// else if(b > a && b > c && c > a)
// {
//     Console.WriteLine(a + " " + c + " " + b);
// }
// else if(c > a && c > b && a > b)
// {
//     Console.WriteLine(b + " " + a + " " + c);
// }
// else
// {
//     Console.WriteLine(a + " " + b + " " + c);
// }


// Console.WriteLine("Podaj pierwszą liczbę:");
// a = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Podaj drugą liczbę:");
// b = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("wybierz działanie: 1. dodawanie, 2. odejmowanie");
// c = int.Parse(Console.ReadLine() ?? "");
// switch (c)
// {
//     case 1:
//         Console.WriteLine($"Wynik dodawania: {a + b}");
//         break;
//     case 2:
//         Console.WriteLine($"Wynik odejmowania: {a - b}");
//         break;
//     default:
//         Console.WriteLine("Nieprawidłowy wybór działania.");
//         break;
// }

// int s,dz,j;
// Console.WriteLine("Podajliczbę:");
// int Liczba = (int)double.Parse(Console.ReadLine() ?? "");
// s = (int)(Liczba / 100);
// dz = (int)((Liczba % 100) / 10);
// j = (int)(Liczba % 10);
// if (Liczba < 100 || Liczba > 999)
// {
//     Console.WriteLine("Podana liczba nie jest trzycyfrowa.");
// }
// else
// {
//     double wynik = (s + dz + j) ;
// if(wynik % 3 ==0)
// {
//     Console.WriteLine($"Suma cyfr liczby {Liczba} jest podzielna przez 3");
// }
// else
// {
//     Console.WriteLine($"Suma cyfr liczby {Liczba} nie jest podzielna przez 3");
// }
// }